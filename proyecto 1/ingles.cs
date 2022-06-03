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
    public partial class ingles : Form
    {
        public ingles()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginingles si = new loginingles();
            si.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 xd = new Form1();
            xd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            quieningles hola = new quieningles();
            hola.Show();
        }
    }
}
