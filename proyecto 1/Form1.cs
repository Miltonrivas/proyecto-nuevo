namespace proyecto_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            vinoblanco si = new vinoblanco();
            si.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login si = new login();
            si.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            dato no = new dato();
            no.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarUsuario si = new AgregarUsuario();
            si.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            quienessomos no = new quienessomos();
                no.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            vinotinto yes = new vinotinto();
                yes.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ingles nop = new ingles();
            nop.Show();


        }
    }
}