namespace Rollenspiel_24_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kartenView1.Karte = new Logik.Karte();
            kartenView1.Invalidate();
        }
    }
}
