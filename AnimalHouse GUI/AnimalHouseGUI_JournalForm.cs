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

        public AnimalHouseGUI_JournalForm()
        {
            InitializeComponent();
            controller = MainController.GetInstance();
            comboBox_behandler.DataSource = controller.HentAlleBehandler();
            comboBox_behandler.DisplayMember = "HentNavn";
            comboBox_behandler2.DataSource = controller.HentAlleBehandler();
            comboBox_behandler2.DisplayMember = "HentNavn";
            this.comboBox_behandler.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_behandler2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_ejer.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_dyr.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

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
            if (ValidateForm())
            {
                try
                {
                    controller.HentAlleDyr();
                    int ansatid = controller.HentAnsatId(comboBox_behandler.Text.Trim());
                    int dyrid = controller.D[comboBox_dyr.SelectedIndex].DyrId;
                    string beskrivelse = textBox_beskrivelse.Text.Trim();
                    string res = controller.Opretjournal(ansatid, dyrid, beskrivelse);
                    MessageBox.Show(res);
                }
                catch (Exception er)
                {

                    MessageBox.Show(er.Message);
                } 
            }
            else
            {
                MessageBox.Show("Invald data!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    ClearForm();
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
            textBox_info1.Text = "";
            textBox_info2.Text = "";
            textBox_info3.Text = "";
            textBox_info4.Text = "";
        }

        private void button_søg_Click(object sender, EventArgs e)
        {
            //henter Kunder iden
            var kundenavn = comboBox_ejer.Text.Split(' ');
            int  kundeid = controller.HentKundeId(kundenavn[0]);
            foreach (Dyr item in controller.HentAlleKundesDyr(kundeid))
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
                controller.HentAlleDyr();
               
                textBox_info1.Text = controller.HentAnsatNavn((int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())));
               
                foreach (var item in controller.HentAlleDyr())
                {
                    if (item.DyrId == int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()))
                    {
                        textBox_info2.Text = item.Art + " " + item.Race + " " + item.Alder;
                    }
                }
                textBox_info3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox_info4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); 
            }
            else
            {
                throw new Exception("No row was selected!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Journal Form.txt");
        }

        private bool ValidateForm()
        {
            if (comboBox_behandler.Text.Length != 0
                && comboBox_ejer.Text.Length != 0
                && comboBox_dyr.Text.Length != 0
                && textBox_beskrivelse.Text.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
