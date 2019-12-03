using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimaleHouseModel;
using System.Diagnostics;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouse_MailForm : Form
    {
        EmailSystem email = new EmailSystem();
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

        private void button_Send_Click(object sender, EventArgs e)
        {
            
            email.CreateEmail();
        }

        private void button_tilføj_Click(object sender, EventArgs e)
        {
            //email.EmailList.Add();
        }
    }
}
