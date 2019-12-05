using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AnimalHouseBLL;
using AnimalHouse_Entities;
using System_Entities;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGUI_JournalForm : Form
    {
        private int id;
        private MainController controller;
        private List<Dyr> d;
        private int kundeid;

        public AnimalHouseGUI_JournalForm()
        {
            InitializeComponent();
            controller = new MainController();
            comboBox_behandler.DataSource = controller.HentAlleAnsate();
            comboBox_behandler.DisplayMember = "GetName";
            comboBox_behandler2.DataSource = controller.HentAlleAnsate();
            comboBox_behandler2.DisplayMember = "GetName";
            d = new List<Dyr>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main mainform = new AnimalHouseGui_Main();
            mainform.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    button_slet.Enabled = true;
                    button_hent_record.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_gem_Click(object sender, EventArgs e)
        {
            try
            {

                int ansatid = controller.HentAnsatId(comboBox_behandler.Text.Trim());
                int dyrid = d[comboBox_dyr.SelectedIndex].DyrId;
                string beskrivelse = textBox_beskrivelse.Text.Trim();
                string res = controller.Opretjournal(ansatid, dyrid, beskrivelse);
                MessageBox.Show(res);
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }

        }

        private void test()
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Ejer er ikke registeret!");
            }
        }

        private void button_slet_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Er du sikker?", "Slette Journal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(controller.SletJournal(id), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGridView();
                }
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }
        }

        private void button_annulere_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBox_beskrivelse.Text = "";
            comboBox_behandler.Text = "";
            comboBox_dyr.Text = "";
            comboBox_ejer.Text = "";
            comboBox_behandler2.Text = "";
        }

        private void button_søg_Click(object sender, EventArgs e)
        {
            //henter Kunder iden
            var kundenavn = comboBox_ejer.Text.Split(' ');
            kundeid = controller.HentKundeId(kundenavn[0]);
            d = controller.HentAlleKundesDyr(kundeid);
            foreach (Dyr item in d)
            {
                comboBox_dyr.Items.Add(item.DyrId + " " + item.Art + " " + item.Race);
            }
        }

        private void comboBox_ejer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AnimalHouseGUI_JournalForm_Load(object sender, EventArgs e)
        {
            //henter kunder
            comboBox_ejer.DataSource = controller.HentAlleKunde();
            comboBox_ejer.DisplayMember = "GetName";
            ClearForm();
        }

        private void FillDataGridView()
        {
            dataGridView1.DataSource = controller.HentAlleJournale();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button_søgning_Click(object sender, EventArgs e)
        {
            int ansatid = controller.HentAnsatId(comboBox_behandler2.Text.Trim());
            dataGridView1.DataSource = controller.HentAlleAnsateJournale(ansatid);
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Ansat a = controller.HentAnsatById(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
                textBox_info1.Text = a.Navn;
                Dyr d = controller.HentDyr(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
                textBox_info2.Text = d.DyrId + " " + d.Art + " " + d.Race + " " + d.Alder;
                textBox_info3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox_info4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); 
            }
            else
            {
                throw new Exception("No row is selected!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
