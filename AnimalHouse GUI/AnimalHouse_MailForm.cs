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
using AnimaleHouseModel;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouse_MailForm : Form
    {
        EmailSystem emailSystem = new EmailSystem();
        
        public AnimalHouse_MailForm()
        {
            InitializeComponent();
        }

        private void label_hjælpe_Click(object sender, EventArgs e)
        {
            //Process.Start();
        }

        private void button_Tilbage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main mailForm = new AnimalHouseGui_Main();
            mailForm.ShowDialog();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
           
        }
    }
}
