using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouse_MailForm : Form
    {
        public AnimalHouse_MailForm()
        {
            InitializeComponent();
        }

        private void label_hjælpe_Click(object sender, EventArgs e)
        {

        }

        private void button_Tilbage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main mailForm = new AnimalHouseGui_Main();
            mailForm.ShowDialog();
        }
    }
}
