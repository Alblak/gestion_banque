using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal Pr = new Principal();
            Pr.Show();
            this.Hide();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void Principal_Load_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel4.Visible = true;
            panel2.Controls.Clear();
            Compte Co = new Compte();
            panel2.Controls.Add(Co);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Controls.Clear();
            Compte Co = new Compte();
            panel2.Controls.Add(Co);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Compte Co = new Compte();
            panel2.Controls.Add(Co);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
