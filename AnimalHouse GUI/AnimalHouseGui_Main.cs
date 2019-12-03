using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Main : Form
    {
        public AnimalHouseGui_Main()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label_AnimalHouse1_Click(object sender, EventArgs e)
        {

        }

        private void button_EjerReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Register formR = new AnimalHouseGui_Register();
            formR.ShowDialog();
        }

        private void button_Booking_Click(object sender, EventArgs e)
        {
            AnimalHouseGui_Booking formB = new AnimalHouseGui_Booking();
            formB.ShowDialog();
        }

        private void button_Salg_Click(object sender, EventArgs e)
        {
            AnimalHouseGui_Sales formS = new AnimalHouseGui_Sales();
            formS.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AnimaHouseGui_AnsatForm ansatForm = new AnimaHouseGui_AnsatForm();
            ansatForm.ShowDialog();
        }

        private void button_DyrReg_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            AnimalHouseGui_DyrRegister dyrRegister = new AnimalHouseGui_DyrRegister();
            dyrRegister.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\obj\Debug\Main Form.txt");
        }

        private void button_mail_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouse_MailForm mailForm = new AnimalHouse_MailForm();
            mailForm.ShowDialog();
        }

        private void button_lagerStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_LagerStatus lagerForm = new AnimalHouseGui_LagerStatus();
            lagerForm.ShowDialog();
        }

        private void button_Journal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGUI_JournalForm journalForm = new AnimalHouseGUI_JournalForm();
            journalForm.ShowDialog();
        }
    }
}

