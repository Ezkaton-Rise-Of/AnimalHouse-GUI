//Holger
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
using System.IO;
namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Booking : Form
    {

        // instanserere maincontroller
        MainController controller = MainController.GetInstance;
        // Opretter entities;
        Ansat ansat = null;
        BookingTime starttid = null;
        BookingTime sluttid = null;
        Servicetype servicetype = null;
        Service service = null;
        Dyr Dyr = null;

        public AnimalHouseGui_Booking()
        {
            InitializeComponent();
        }
        private void Hentbookinger()
        {
            try
            {
                //tilføre alle bookinger til datasource
                dataGridView2.DataSource = controller.HentAlleBooking(controller.K[0]);
            }
            catch (Exception)
            {

                throw new ArgumentException("Der er sket en fejl med at hente booking for kunden");
            }

        }
        private void AnimalHouseGui_Booking_Load(object sender, EventArgs e)   
        {
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;
        }
        private void SearchKunde_Click(object sender, EventArgs e)
        {//holger 
            try
            {
                //henter kunder
                controller.HentKundeByTlf(Convert.ToString(textBox_EjerIdBooking.Text));
                //tilføre informationer til labes
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
            catch 
            {
                MessageBox.Show("problemer med forbindelsen");


               
            }
        }
        private void FillDyrComboBox()
        {
            // reset Dyr_ComboBox
            Dyr_comboBox.Items.Clear();
            Dyr = null;

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
            //reset combobox_ansat
            Combobox_ansat.Items.Clear();
            ansat = null;

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
            // tjekker om der er tilføjes en kunde
            if (string.IsNullOrEmpty(Dyr_comboBox.Text))
            {
                MessageBox.Show("vælg en dyr først");
            }
            else {
                controller.BookingHentFriBur(dateTimePicker1.Value, dateTimePicker2.Value);
                dataGridView1.DataSource = controller.Bur;
            }
        }
        private void ComboBoxAnsat_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_ServiceType.Items.Clear();
            servicetype = null;

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
            //reset
            Service_combobox.Items.Clear();
            service = null;


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
            StartTid_Combo.Items.Clear();
            starttid = null;
            ComboBoxItem cbiservice = (ComboBoxItem)Service_combobox.SelectedItem;
            service = (Service)cbiservice.Value;
            foreach (BookingTime item in controller.HentAlleFritider(ansat, dateTimePicker1.Value, servicetype))
            {
                ComboBoxItem citem = new ComboBoxItem();
                citem.Text = item.time;
                citem.Value = item;
                StartTid_Combo.Items.Add(citem);
            }
        }
        private void StartTime_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlutTid_Combo.Items.Clear();
            sluttid = null;

            ComboBoxItem cbistarttid = (ComboBoxItem)StartTid_Combo.SelectedItem;
            starttid = (BookingTime)cbistarttid.Value;
            foreach (BookingTime item in controller.HentAlleHentMuligeSlutTider(ansat, starttid, dateTimePicker1.Value, servicetype))
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

            Process.Start(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + @"\Text_Fiels\Booking.pdf");
        }
        private void SlutTid_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem cbistarttid = (ComboBoxItem)SlutTid_Combo.SelectedItem;
            sluttid = (BookingTime)cbistarttid.Value;
        }
        private void button_tilføj_Click_1(object sender, EventArgs e)
        {
            List<string> mangler = new List<string>(); 

            if(starttid == null)
            {
                mangler.Add("starttid");
            }
            if(sluttid == null)
            {
                mangler.Add("sluttid");
            }
            if(service == null)
            {
                mangler.Add("service");
            }
            if(ansat == null)
            {
                mangler.Add("ansat");
            }
            if(Dyr == null)
            {
                mangler.Add("Dyr");
            }
            if (mangler.Count == 0)
            {
                if(service.Servicetype.ServiceType == "Operation")
                {
                    MessageBox.Show("Husk at Booke bur");

                }

                bool answer = controller.Opretbooking(textBox1.Text, starttid, sluttid, ansat, service, Dyr, dateTimePicker1.Value, dateTimePicker1.Value);
                if (answer == true)
                {

                    // reset 
                    starttid = null;
                    sluttid = null;
                    service = null;
                    ansat = null;
                    Combobox_ansat.Items.Clear();
                    Combobox_ansat.Text = "";
                    comboBox_ServiceType.Items.Clear();
                    comboBox_ServiceType.Text = "";
                    SlutTid_Combo.Items.Clear();
                    SlutTid_Combo.Text = "";
                    StartTid_Combo.Items.Clear();
                    StartTid_Combo.Text = "";
                    Service_combobox.Items.Clear();
                    Service_combobox.Text = "";

                    Hentbookinger();
                }
                else
                {
                    MessageBox.Show("Der er sket en fejl i oprettelse");
                }
                
            }
            else
            {
                Mangler(mangler);
            }
        }
        private void Mangler(List<string> mangler)
        {
            string answer = "Du mangler at udfylde: ";
            for (int i = 0; i < mangler.Count; i++)
            {
                answer += mangler[i];
            }

            MessageBox.Show(answer);
        }
        private void button_AnulBooking_Click(object sender, EventArgs e)
        {
            Booking b = (Booking)dataGridView2.CurrentRow.DataBoundItem;
            bool answer = controller.SletBooking(b);
            if (answer == true)
            {
                Hentbookinger();
            }
            else
            {
                MessageBox.Show("Der er sket en fejl i sletningen");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            AnimalHouseGui_Register form = new AnimalHouseGui_Register();
            form.ShowDialog();
        }
        private void button_BurBooking_Click(object sender, EventArgs e)
        {
            List<string> mangler = new List<string>();

            if (Dyr == null)
            {
                mangler.Add("Dyr");
            }if (mangler.Count() == 0)
            {
                bool answer = controller.OpretbookingBur(textBox1.Text, Dyr, dateTimePicker1.Value, dateTimePicker1.Value, (Bur)dataGridView1.CurrentRow.DataBoundItem);
                if (answer == true)
                {
                    Hentbookinger();
                }
                else
                {
                    MessageBox.Show("Der er sket en fejl i oprettelse");
                }
            }
            else
            {
                Mangler(mangler);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
