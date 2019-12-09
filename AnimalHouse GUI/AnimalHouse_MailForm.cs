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
            var modtagerList = listBox_modtager_list.Items.Cast<String>().ToList();
            bool res =emailSystem.CreateEmail(textBox_subjekt.Text,textBox_inhold.Text,modtagerList);
            if (res is true)
            {
                MessageBox.Show("mail blev sendt");
            }
            else
            {
                MessageBox.Show("der sket en fejl!");
            }
        }

        private void button_tilføj_Click(object sender, EventArgs e)
        {
            listBox_modtager_list.Items.Add(textBox4.Text);
        }
    }
}
