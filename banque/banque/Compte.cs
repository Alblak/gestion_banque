using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace banque
{
    public partial class Compte : UserControl
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=gestion_banque;uid=root;pwd=''");

        private int selectedID = -1; // Variable pour gérer l'ID sélectionné

        public Compte()
        {
            InitializeComponent();
        }

        private void Compte_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Chargement des données dans le DataGridView
        private void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string query = "SELECT id, num_compte, nom, postnom, prenom, date_naissance, lieu_naissance, etat_civil, profession, adresse, telephone, type_compte, photo FROM compte";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Génération du numéro de compte
        private string GenerateAccountNumber()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string query = "SELECT MAX(num_compte) FROM compte";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                string lastAccountNumber = result != DBNull.Value ? result.ToString() : "22010000000";

                // Incrémenter le dernier numéro
                long newAccountNumber = long.Parse(lastAccountNumber) + 1;
                return newAccountNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du numéro de compte : " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        // Vérification si un compte existe déjà
        private bool AccountExists(string numCompte)
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string query = "SELECT COUNT(*) FROM compte WHERE num_compte = @numCompte";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numCompte", numCompte);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification du compte : " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        private bool AccountDuplicateExists(string nom, string prenom, DateTime date_naissance)
        {
            using (MySqlConnection connection = new MySqlConnection(conn.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM compte WHERE nom = @nom AND prenom = @prenom AND date_naissance = @date_naissance";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@date_naissance", date_naissance.ToString("yyyy-MM-dd"));
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la vérification des doublons : " + ex.Message);
                    return false;
                }
            }
        }

        private void buttonChoisirPhoto_Click_1(object sender, EventArgs e)
        {
    // Choisir une photo à partir de la machine
    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Filter = "Images (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

    if (ofd.ShowDialog() == DialogResult.OK)
    {
        try
        {
            // Tente de charger l'image et l'affiche dans le PictureBox
            pictureBoxPhoto.Image = Image.FromFile(ofd.FileName);
            pictureBoxPhoto.Tag = ofd.FileName; // Stocke le chemin de l'image dans la propriété Tag
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
            pictureBoxPhoto.Image = null;
        }
    }
   }
        // Ajouter un compte
        private void buttonAjouter_Click_1(object sender, EventArgs e)
        {
          
        try
        {
            // Validation du champ téléphone : seuls les chiffres sont autorisés
            if (!txtTelephone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Le champ Téléphone doit contenir uniquement des chiffres.");
                return;
            }

            // Vérifier si un compte avec le même nom, prénom et date de naissance existe déjà
            if (AccountDuplicateExists(txtNom.Text, txtPrenom.Text, dateTimePicker1.Value))
            {
                MessageBox.Show("Ce compte existe déjà.");
                return;
            }
        
            string newAccountNumber = GenerateAccountNumber();

            if (string.IsNullOrEmpty(newAccountNumber))
            {
                MessageBox.Show("Impossible de générer un numéro de compte.");
                return;
            }

            // (Optionnel) Vérifier si le numéro de compte existe déjà
            if (AccountExists(newAccountNumber))
            {
                MessageBox.Show("Le numéro de compte existe déjà.");
                return;
            }

            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();

            string query = "INSERT INTO compte (num_compte, nom, postnom, prenom, date_naissance, lieu_naissance, etat_civil, profession, adresse, telephone, type_compte, photo) " +
                           "VALUES (@num_compte, @nom, @postnom, @prenom, @date_naissance, @lieu_naissance, @etat_civil, @profession, @adresse, @telephone, @type_compte, @photo)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@num_compte", newAccountNumber);
            cmd.Parameters.AddWithValue("@nom", txtNom.Text.Replace("'", "''"));
            cmd.Parameters.AddWithValue("@postnom", txtPostnom.Text.Replace("'", "''"));
            cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text.Replace("'", "''"));
            cmd.Parameters.AddWithValue("@date_naissance", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@lieu_naissance", txtLieuNaissance.Text.Replace("'", "''"));
            cmd.Parameters.AddWithValue("@etat_civil", txtEtatCivil.Text.Replace("'", "''"));
            cmd.Parameters.AddWithValue("@profession", txtProfession.Text.Replace("'", "''"));
            cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text.Replace("'", "''"));
            cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text.Replace("'", "''"));
            cmd.Parameters.AddWithValue("@type_compte", comboBoxTypeCompte.Text.Replace("'", "''"));

            // Gestion de la photo
            if (pictureBoxPhoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);
                    byte[] photoArray = ms.ToArray();
                    cmd.Parameters.AddWithValue("@photo", photoArray);
                }
            }
            else
            {
                cmd.Parameters.AddWithValue("@photo", DBNull.Value);
            }

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Compte ajouté avec succès !");
                // Réinitialiser les champs
                txtNom.Text = "";
                txtPostnom.Text = "";
                txtPrenom.Text = "";
                dateTimePicker1.Text = "";
                txtLieuNaissance.Text = "";
                txtEtatCivil.Text = "";
                txtProfession.Text = "";
                txtAdresse.Text = "";
                txtTelephone.Text = "";
                comboBoxTypeCompte.Text = "";
                pictureBoxPhoto.Image = null;
                LoadData();
            }
            else
            {
                MessageBox.Show("Échec de l'ajout du compte.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur : " + ex.Message);
        }
        finally
        {
            conn.Close();
        }


        }
        // Click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
           {
          
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    // Assurez-vous que la colonne "id" existe dans le DataGridView
                    if (row.Cells["id"].Value != null && row.Cells["id"].Value != DBNull.Value)
                    {
                        int id;
                        if (int.TryParse(row.Cells["id"].Value.ToString(), out id))
                        {
                            selectedID = id;
                        }
                        else
                        {
                            selectedID = -1;
                            MessageBox.Show("L'ID n'est pas un nombre valide.");
                        }
                    }
                    else
                    {
                        selectedID = -1;
                    }
            
                    // Remplissage des autres champs
                    txtNumCompte.Text = row.Cells["num_compte"].Value != DBNull.Value ? row.Cells["num_compte"].Value.ToString() : "";
                    txtNom.Text = row.Cells["nom"].Value != DBNull.Value ? row.Cells["nom"].Value.ToString() : "";
                    txtPostnom.Text = row.Cells["postnom"].Value != DBNull.Value ? row.Cells["postnom"].Value.ToString() : "";
                    txtPrenom.Text = row.Cells["prenom"].Value != DBNull.Value ? row.Cells["prenom"].Value.ToString() : "";
                    dateTimePicker1.Value = row.Cells["date_naissance"].Value != DBNull.Value
                        ? Convert.ToDateTime(row.Cells["date_naissance"].Value)
                        : DateTime.Now;
                    txtLieuNaissance.Text = row.Cells["lieu_naissance"].Value != DBNull.Value ? row.Cells["lieu_naissance"].Value.ToString() : "";
                    txtEtatCivil.Text = row.Cells["etat_civil"].Value != DBNull.Value ? row.Cells["etat_civil"].Value.ToString() : "";
                    txtProfession.Text = row.Cells["profession"].Value != DBNull.Value ? row.Cells["profession"].Value.ToString() : "";
                    txtAdresse.Text = row.Cells["adresse"].Value != DBNull.Value ? row.Cells["adresse"].Value.ToString() : "";
                    txtTelephone.Text = row.Cells["telephone"].Value != DBNull.Value ? row.Cells["telephone"].Value.ToString() : "";
                    comboBoxTypeCompte.Text = row.Cells["type_compte"].Value != DBNull.Value ? row.Cells["type_compte"].Value.ToString() : "";

                    // Charger la photo si disponible
                    if (row.Cells["photo"].Value != null && row.Cells["photo"].Value != DBNull.Value)
                    {
                        byte[] photoArray = row.Cells["photo"].Value as byte[];
                        if (photoArray != null && photoArray.Length > 0)
                        {
                            try
                            {
                                using (MemoryStream ms = new MemoryStream(photoArray))
                                {
                                    pictureBoxPhoto.Image = Image.FromStream(ms);
                                }
                            }
                            catch
                            {
                                pictureBoxPhoto.Image = null;
                            }
                        }
                        else
                        {
                            pictureBoxPhoto.Image = null;
                        }
                    }
                    else
                    {
                        pictureBoxPhoto.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du remplissage des champs : " + ex.Message);
                }
            }
        }

        // Modifier un compte
        private void buttonModifier_Click(object sender, EventArgs e)
        
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Veuillez sélectionner un compte à modifier.");
                return;
            }
    
            // Validation du champ téléphone pour modification
            if (!txtTelephone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Le champ Téléphone doit contenir uniquement des chiffres.");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                string query = "UPDATE compte SET nom = @nom, postnom = @postnom, prenom = @prenom, date_naissance = @date_naissance, " +
                               "lieu_naissance = @lieu_naissance, etat_civil = @etat_civil, profession = @profession, adresse = @adresse, " +
                               "telephone = @telephone, type_compte = @type_compte, photo = @photo WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedID);
                cmd.Parameters.AddWithValue("@nom", txtNom.Text.Replace("'", "''"));
                cmd.Parameters.AddWithValue("@postnom", txtPostnom.Text.Replace("'", "''"));
                cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text.Replace("'", "''"));
                cmd.Parameters.AddWithValue("@date_naissance", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@lieu_naissance", txtLieuNaissance.Text.Replace("'", "''"));
                cmd.Parameters.AddWithValue("@etat_civil", txtEtatCivil.Text.Replace("'", "''"));
                cmd.Parameters.AddWithValue("@profession", txtProfession.Text.Replace("'", "''"));
                cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text.Replace("'", "''"));
                cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text.Replace("'", "''"));
                cmd.Parameters.AddWithValue("@type_compte", comboBoxTypeCompte.Text.Replace("'", "''"));

                // Gestion de la photo avec clonage pour éviter le verrouillage de l'image
                if (pictureBoxPhoto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        new Bitmap(pictureBoxPhoto.Image).Save(ms, pictureBoxPhoto.Image.RawFormat);
                        byte[] photoArray = ms.ToArray();
                        cmd.Parameters.AddWithValue("@photo", photoArray);
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@photo", DBNull.Value);
                }

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Compte modifié avec succès !");
                    // Réinitialiser les champs
                    txtNom.Text = "";
                    txtPostnom.Text = "";
                    txtPrenom.Text = "";
                    dateTimePicker1.Text = "";
                    txtLieuNaissance.Text = "";
                    txtEtatCivil.Text = "";
                    txtProfession.Text = "";
                    txtAdresse.Text = "";
                    txtTelephone.Text = "";
                    comboBoxTypeCompte.Text = "";
                    pictureBoxPhoto.Image = null;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Échec de la modification du compte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        // Supprimer un compte
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("Veuillez sélectionner un compte à supprimer.");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                string query = "DELETE FROM compte WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", selectedID);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Compte supprimé avec succès !");
                    txtNom.Text = "";
                    txtPostnom.Text = "";
                    txtPrenom.Text = "";
                    dateTimePicker1.Text = "";
                    txtLieuNaissance.Text = "";
                    txtEtatCivil.Text = "";
                    txtProfession.Text = "";
                    txtAdresse.Text = "";
                    txtTelephone.Text = "";
                    comboBoxTypeCompte.Text = "";
                    pictureBoxPhoto.Text = "";
                    LoadData();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Échec de la suppression du compte.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
