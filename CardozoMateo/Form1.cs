namespace CardozoMateo
{
    public partial class Form1 : Form
    {
        Teatros teatros = new Teatros();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teatros.CrearEscenario();
            Controls.Add(teatros.imgEscenario);

        }
    }
}
