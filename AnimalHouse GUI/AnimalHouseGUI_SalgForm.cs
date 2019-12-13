using AnimalHouseBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimaleHouseModel;
using System.Threading;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGUI_SalgForm : Form
    {
        SalgSystem salgSystem;   
        MainController controller;
        public AnimalHouseGUI_SalgForm()
        {
            InitializeComponent();
            controller = new MainController();
            salgSystem = new SalgSystem();
        }

        private void button_tilbage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main mainform = new AnimalHouseGui_Main();
            mainform.ShowDialog();
        }

        private void label_hjælpe_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Radwan\Source\Repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Salg Form.txt");
        }

        private void button_gem_Click(object sender, EventArgs e)
        {
            string res = controller.GemFaktura();
        }

        private void AnimalHouseGUI_SalgForm_Load(object sender, EventArgs e)
        {
            comboBox_kunde.DataSource = controller.HentAlleKunde();
            comboBox_kunde.DisplayMember = "GetName";
            
        }

        private void test()
        {
           
        }

        private void button_fjerne_Click(object sender, EventArgs e)
        {
            comboBox_kategori.DataSource = controller.HentAlleKategorier();
            comboBox_kategori.DisplayMember = "HentNavn";
        }
    }
}
