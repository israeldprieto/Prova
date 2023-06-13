namespace Prova
{
    public partial class Correcao : Form
    {
        public Correcao()
        {
            InitializeComponent();
        }

        private void button1click(object sender, EventArgs e)
        {
            Gabarito gb = new Gabarito();
            gb.ShowDialog();
        }
    }
}