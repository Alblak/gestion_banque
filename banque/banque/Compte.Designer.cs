namespace banque
{
    partial class Compte
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumCompte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLieuNaissance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEtatCivil = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTypeCompte = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonChoisirPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(445, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creer un compte";
            // 
            // txtNumCompte
            // 
            this.txtNumCompte.Enabled = false;
            this.txtNumCompte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCompte.Location = new System.Drawing.Point(441, 99);
            this.txtNumCompte.Name = "txtNumCompte";
            this.txtNumCompte.Size = new System.Drawing.Size(292, 32);
            this.txtNumCompte.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero compte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNom.Location = new System.Drawing.Point(441, 147);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 32);
            this.txtNom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "PostNom:";
            // 
            // txtPostnom
            // 
            this.txtPostnom.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPostnom.Location = new System.Drawing.Point(441, 189);
            this.txtPostnom.Name = "txtPostnom";
            this.txtPostnom.Size = new System.Drawing.Size(292, 32);
            this.txtPostnom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prénom:";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPrenom.Location = new System.Drawing.Point(441, 232);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(292, 32);
            this.txtPrenom.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date de naissance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lieu de naissancce:";
            // 
            // txtLieuNaissance
            // 
            this.txtLieuNaissance.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtLieuNaissance.Location = new System.Drawing.Point(442, 311);
            this.txtLieuNaissance.Name = "txtLieuNaissance";
            this.txtLieuNaissance.Size = new System.Drawing.Size(291, 32);
            this.txtLieuNaissance.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(758, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telephone:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTelephone.Location = new System.Drawing.Point(942, 232);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(314, 32);
            this.txtTelephone.TabIndex = 19;
            this.txtTelephone.TextChanged += new System.EventHandler(this.txtTelephone_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(758, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Adresse:";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAdresse.Location = new System.Drawing.Point(942, 192);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(314, 32);
            this.txtAdresse.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(758, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 23);
            this.label12.TabIndex = 16;
            this.label12.Text = "Profession:";
            // 
            // txtProfession
            // 
            this.txtProfession.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtProfession.Location = new System.Drawing.Point(942, 150);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(314, 32);
            this.txtProfession.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(758, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "Etat civil:";
            // 
            // txtEtatCivil
            // 
            this.txtEtatCivil.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEtatCivil.Location = new System.Drawing.Point(942, 111);
            this.txtEtatCivil.Name = "txtEtatCivil";
            this.txtEtatCivil.Size = new System.Drawing.Size(314, 32);
            this.txtEtatCivil.TabIndex = 13;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.White;
            this.buttonAjouter.Location = new System.Drawing.Point(799, 351);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(126, 47);
            this.buttonAjouter.TabIndex = 25;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click_1);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.White;
            this.buttonModifier.Location = new System.Drawing.Point(942, 352);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(138, 46);
            this.buttonModifier.TabIndex = 26;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimer.Location = new System.Drawing.Point(1095, 352);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(136, 46);
            this.buttonSupprimer.TabIndex = 28;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 274);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 32);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Type compte:";
            // 
            // comboBoxTypeCompte
            // 
            this.comboBoxTypeCompte.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBoxTypeCompte.FormattingEnabled = true;
            this.comboBoxTypeCompte.Items.AddRange(new object[] {
            "USD",
            "Franc"});
            this.comboBoxTypeCompte.Location = new System.Drawing.Point(441, 350);
            this.comboBoxTypeCompte.Name = "comboBoxTypeCompte";
            this.comboBoxTypeCompte.Size = new System.Drawing.Size(292, 31);
            this.comboBoxTypeCompte.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(239, 434);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 218);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.ErrorImage = null;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(1008, 270);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(129, 73);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 35;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonChoisirPhoto
            // 
            this.buttonChoisirPhoto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoisirPhoto.Location = new System.Drawing.Point(762, 285);
            this.buttonChoisirPhoto.Name = "buttonChoisirPhoto";
            this.buttonChoisirPhoto.Size = new System.Drawing.Size(209, 32);
            this.buttonChoisirPhoto.TabIndex = 36;
            this.buttonChoisirPhoto.Text = "Choisir une image";
            this.buttonChoisirPhoto.UseVisualStyleBackColor = true;
            this.buttonChoisirPhoto.Click += new System.EventHandler(this.buttonChoisirPhoto_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChoisirPhoto);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxTypeCompte);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtProfession);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEtatCivil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLieuNaissance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPostnom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumCompte);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Compte";
            this.Size = new System.Drawing.Size(1286, 782);
            this.Load += new System.EventHandler(this.Compte_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLieuNaissance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEtatCivil;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTypeCompte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonChoisirPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
