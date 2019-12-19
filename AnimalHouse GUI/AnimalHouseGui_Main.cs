using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using AnimaleHouseModel;
namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Main : Form
    {
        public AnimalHouseGui_Main()
        {
            InitializeComponent();
            AutomatikProductUpdate auto = new AutomatikProductUpdate();

            Thread autothread = new Thread(new ThreadStart(auto.Autorun));
            autothread.Start();
        }
        private void button_EjerReg_Click(object sender, EventArgs e)
        {

            AnimalHouseGui_Register formR = new AnimalHouseGui_Register();
            formR.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            AnimaHouseGui_AnsatForm ansatForm = new AnimaHouseGui_AnsatForm();
            ansatForm.ShowDialog();
        }

        private void button_DyrReg_Click_1(object sender, EventArgs e)
        {

            AnimalHouseGui_DyrRegister dyrRegister = new AnimalHouseGui_DyrRegister();
            dyrRegister.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Main Form.txt");
        }

        private void button_mail_Click(object sender, EventArgs e)
        {

            AnimalHouse_MailForm mailForm = new AnimalHouse_MailForm();
            mailForm.ShowDialog();
        }

        private void button_lagerStatus_Click(object sender, EventArgs e)
        {

            AnimalHouseGui_Lager lager = new AnimalHouseGui_Lager();
            lager.ShowDialog();
        }

        private void button_Booking_Click_1(object sender, EventArgs e)
        {

            AnimalHouseGui_Booking Booking = new AnimalHouseGui_Booking();
            Booking.ShowDialog();


        }

        private void button_Journal_Click(object sender, EventArgs e)
        {

            AnimalHouseGUI_JournalForm journalForm = new AnimalHouseGUI_JournalForm();
            journalForm.ShowDialog();
        }

        private void button_Salg_Click_1(object sender, EventArgs e)
        {

            AnimalHouseGUI_SalgForm salgForm = new AnimalHouseGUI_SalgForm();
            salgForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // Lager Tilføj
        {
            //AnimalHouseGui_Lager.tabTilføj.SelectTab(2);
        }
    }
}

