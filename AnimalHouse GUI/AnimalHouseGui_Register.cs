using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouseBLL;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Register : Form
    {

        MainController controller = new MainController();

        public AnimalHouseGui_Register()
        {
            InitializeComponent();
        }

        private void Label_ForNavn_Click(object sender, EventArgs e)
        {

        }

        private void Label_Sygdom_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AnimalHouseGui_Register_Load(object sender, EventArgs e)
        {

        }

        private void button_RegEjer_Click(object sender, EventArgs e)
        {
            //string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string email
            string answer = controller.OpretKunde(textBox_Fornavn.Text, textBox_Efternavn.Text,textBox_Vejnavn.Text, textBox_Postnummer.Text, textBox_Telefon.Text, textBox_EjerType.Text, textBox_By.Text = controller.HentBynavn(textBox_Postnummer.Text), textBox_Email.Text);
            MessageBox.Show(answer);
            ; 
        }

        private void button_SletEjer_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Søgning_Click(object sender, EventArgs e)
        {

        }
    }
}
