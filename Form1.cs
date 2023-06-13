using WinFormsApp3.Properties;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
            ChangeBackgroundImage(@"C:\Users\Влад\Desktop\usa.jpg");
        }

        private void UkrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("uk-UA");
            ChangeBackgroundImage(@"C:\Users\Влад\Desktop\ua.jpg");
        }

        private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("fr-FR");
            ChangeBackgroundImage(@"C:\Users\Влад\Desktop\fr.jpg");
        }

        private void ChangeLanguage(string cultureName)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureName);            
        }

        private void ChangeBackgroundImage(string imageName)
        {            
            this.BackgroundImage = Image.FromFile(imageName);
        }        
    }
}