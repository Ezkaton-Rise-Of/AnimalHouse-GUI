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
    public partial class AnimalHouseGui_DyrRegister : Form
    {

        MainController controller = new MainController();
        public AnimalHouseGui_DyrRegister()
        {
            InitializeComponent();
        }

        private void label_Underart_Click(object sender, EventArgs e)
        {

        }

        private void button_RegDyr_Click(object sender, EventArgs e)
        {
            //string answer = controller.OpretDyr(textBox_EjerNavn.Text, textBox_Art.Text, textBox_Race.Text, textBox_Køn.Text, textBox_Alder.Text);
            //MessageBox.Show(answer);
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main main = new AnimalHouseGui_Main();
            main.ShowDialog();
        }
    }
}
