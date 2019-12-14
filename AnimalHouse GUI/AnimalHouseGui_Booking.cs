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
        Servicetype servicetype = new Servicetype();
        Service service = new Service();
        Dyr Dyr = new Dyr();

        public AnimalHouseGui_Booking()
        {
            InitializeComponent();
        }
        private void Hentbookinger()
        {
            dataGridView2.DataSource = controller.HentAlleBooking(controller.K[0]);
        }

        private void AnimalHouseGui_Booking_Load(object sender, EventArgs e)   
        {
        }
        private void SearchKunde_Click(object sender, EventArgs e)
        {//holger 
            try
            {       
                //henter kunder
                controller.HentKundeByTlf(Convert.ToString(textBox_EjerIdBooking.Text));
                Navn_empty.Text = controller.K[0].Fnavn + " " + controller.K[0].Lnavn;
                Addresse_empty.Text = controller.K[0].Adresse;
                By_empty.Text = controller.K[0].By;
                Postnummer_empty.Text = controller.K[0].Postnummer;
                try
                {
                    FillDyrComboBox();
                    Hentbookinger();
                }
                catch
                {
                    throw;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("problemer med forbindelsen");

                throw;
            }
        }

        private void FillDyrComboBox()
        {
            foreach (Dyr item in controller.HentAlleKundesDyr(controller.K[0].Id))
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.DyrId + " " + item.Art + " " + item.Race;
                citem.Value = item;
                Dyr_comboBox.Items.Add(citem);
            }
        }
        private void ComboBoxDyr_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbiDyr = (ComboBoxItem)Dyr_comboBox.SelectedItem;
            Dyr = (Dyr)cbiDyr.Value;

            foreach (Ansat item in controller.HentAlleAnsate())
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.Navn + " (" + item.Stelling + ")";
                citem.Value = item;
                Combobox_ansat.Items.Add(citem);
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
        private void ComboBoxAnsat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)Combobox_ansat.SelectedItem;
            ansat = (Ansat)cbi.Value;
            foreach (Servicetype item in controller.HentAlleServiceType())
            {
                if (item.ServiceType != "Bur") {
                    ComboBoxItem citem = new ComboBoxItem();
                    citem.Text = item.ServiceType;
                    citem.Value = item;
                    comboBox_ServiceType.Items.Add(citem);
                }  
            }
        }

        private void comboBox_ServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbiserviceType = (ComboBoxItem)comboBox_ServiceType.SelectedItem;
            servicetype = (Servicetype)cbiserviceType.Value;
            foreach (Service item in controller.HentAlleService(servicetype))
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.Navn;
                citem.Value = item;
                Service_combobox.Items.Add(citem);
            }
        }

        private void Service_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbiservice = (ComboBoxItem)Service_combobox.SelectedItem;
            service = (Service)cbiservice.Value;
            foreach (BookingTime item in controller.HentAlleFritider(ansat, dateTimePicker1.Value))
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.time;
                citem.Value = item;
                StartTid_Combo.Items.Add(citem);
            }
        }

        private void StartTime_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbistarttid = (ComboBoxItem)StartTid_Combo.SelectedItem;
            starttid = (BookingTime)cbistarttid.Value;
            foreach (BookingTime item in controller.HentAlleHentMuligeSlutTider(ansat, starttid, dateTimePicker1.Value))
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.time;
                citem.Value = item;
                SlutTid_Combo.Items.Add(citem);
            }
        }
        private void button_tilbage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label12_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Booking Form.txt");
        }


        private void SlutTid_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbistarttid = (ComboBoxItem)SlutTid_Combo.SelectedItem;
            sluttid = (BookingTime)cbistarttid.Value;
        }

        private void button_Søgning_Click_1(object sender, EventArgs e)
        {
            bool answer = controller.Opretbooking(textBox1.Text, starttid, sluttid, ansat, service, Dyr, dateTimePicker1.Value, dateTimePicker1.Value);
            
            if (answer == true)
            {
                Hentbookinger();
            }
            else
            {
                MessageBox.Show("Der er sket en fejl i oprettelse");
            }
        }

        private void button_AnulBooking_Click(object sender, EventArgs e)
        {

        }
    }
}
