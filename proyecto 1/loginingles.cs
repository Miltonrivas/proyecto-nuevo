using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_1
{
    public partial class loginingles : Form
    {
        public loginingles()
        {
            InitializeComponent();
        }

        private void loginingles_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ingles no = new ingles();
            no.Show();
        }
    }
}
