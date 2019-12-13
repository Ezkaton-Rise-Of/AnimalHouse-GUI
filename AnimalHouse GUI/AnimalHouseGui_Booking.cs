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
using AnimalHouse_Entities;
using System.Diagnostics;
using System_Entities;
namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Booking : Form
    {
        MainController controller = new MainController();
        List<Dyr> dyr = null;
        List<Ansat> ansatte = null;
        public AnimalHouseGui_Booking()
        {
            InitializeComponent();



        }

            private void AnimalHouseGui_Booking_Load(object sender, EventArgs e)
        {

        }

        private void textBox_DyrIdBooking_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_EjerIdBooking_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {//holger 
            try
            {
                //henter kunder
                controller.HentKundeByTlf(Convert.ToString(textBox_EjerIdBooking.Text));
                //henter dyr for kunden.
                dyr = controller.HentAlleKundesDyr(controller.K[0].Id);

                foreach (Dyr item in dyr)
                {
                    comboBox1.Items.Add(item.DyrId + " " + item.Art + " " + item.Race);
                }
                Navn_empty.Text = controller.K[0].Fnavn + " " + controller.K[0].Lnavn;
                Addresse_empty.Text = controller.K[0].Adresse;
                By_empty.Text = controller.K[0].By;
                Postnummer_empty.Text = controller.K[0].Postnummer;
                

                foreach (Ansat item in controller.HentAlleAnsate())
                {
                    ComboBoxItem citem = new ComboBoxItem();
                    citem.Text = item.Navn + " (" + item.Stelling + ")";
                    citem.Value = item;
                    comboBox2.Items.Add(citem);
                }


                //foreach(Service item in controller.HentAlleService())
                //{
                //    ComboBoxItem citem = new ComboBoxItem();
                //    citem.Text = item.ServiceType;
                //    citem.Value = item;
                //    comboBox1.Items.Add(citem);
                //}

                //foreach (Booking item in controller.HentFrieTider(comboBox1.Items.))
                //{

                //}

                //foreach (Booking item in controller.HentFrieTider(comboBox1.Items.))
                //{

                //}


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void textBox_EjerIdBooking_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {




            //holger
            //tjekker om der er tilføjes en kunde
            //if (comboBox1.SelectedValue. ==  null)
            //{
            //    MessageBox.Show("vælg en Kunde først");
            //}
            controller.BookingHentFriBur(dateTimePicker1.Value, dateTimePicker2.Value);

            dataGridView1.DataSource = controller.Bur;
 

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartTime_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_tilbage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main mainform = new AnimalHouseGui_Main();
            mainform.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Booking Form.txt");
        }
    }
}
