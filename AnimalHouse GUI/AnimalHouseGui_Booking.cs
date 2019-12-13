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
        Ansat ansat = new Ansat(); 
        BookingTime starttid = new BookingTime();
        BookingTime sluttid = new BookingTime();
        Service service = new Service();
        Dyr Dyr = new Dyr();

        public AnimalHouseGui_Booking()
        {
            InitializeComponent();



        }

            private void AnimalHouseGui_Booking_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//holger 
            try
            {
                //henter kunder
                controller.HentKundeByTlf(Convert.ToString(textBox_EjerIdBooking.Text));
                //henter dyr for kunden.

                foreach (Dyr item in controller.HentAlleKundesDyr(controller.K[0].Id))
                {
                    ComboBoxItem citem = new ComboBoxItem();
                    citem.Text = item.DyrId + " " + item.Art + " " + item.Race;
                    citem.Value = item;
                    comboBox1.Items.Add(citem);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Ansat item in controller.HentAlleAnsate())
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.Navn + " (" + item.Stelling + ")";
                citem.Value = item;
                comboBox2.Items.Add(citem);
            }



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

            foreach (Service item in controller.HentAlleServiceType())
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.ServiceType;
                citem.Value = item;
                comboBox1.Items.Add(citem);
            }

        }

        private void StartTime_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbiAnsat = (ComboBoxItem)comboBox1.SelectedItem;
            ansat = (Ansat)cbiAnsat.Value;
            ComboBoxItem cbistarttid = (ComboBoxItem)StartTime_Combo.SelectedItem;
            starttid = (BookingTime)cbistarttid.Value;
            foreach (BookingTime item in controller.HentAlleHentMuligeSlutTider(ansat, starttid))
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.time;
                citem.Value = item;
                comboBox3.Items.Add(citem);
            }

        }


        private void comboBox_ServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBoxItem cbiAnsat = (ComboBoxItem)comboBox1.SelectedItem;
            ansat = (Ansat)cbiAnsat.Value;
            ComboBoxItem cbiservice = (ComboBoxItem)comboBox1.SelectedItem;
            service = (Service)cbiservice.Value;

            foreach (BookingTime item in controller.HentAlleFritider(service.ServiceTypeId, dateTimePicker1.Value))
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.time;
                citem.Value = Convert.ToString(item.timeId);
                comboBox3.Items.Add(citem);
            }
        }

        private void button_Søgning_Click(object sender, EventArgs e)
        {
            bool answer = controller.Opretbooking(textBox1.Text, starttid, sluttid, ansat, service, Dyr, dateTimePicker1.Value, dateTimePicker1.Value);

            
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
