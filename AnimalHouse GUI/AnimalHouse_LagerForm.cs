using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouse_LagerForm : Form
    {
        public AnimalHouse_LagerForm()
        {
            InitializeComponent();
        }

        private void button_Tilbage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main mainForm = new AnimalHouseGui_Main();
            mainForm.ShowDialog();
        }
    }
}
