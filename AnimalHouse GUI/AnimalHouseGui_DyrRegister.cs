using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouse_Entities;
using AnimalHouseBLL;
using System.Diagnostics;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_DyrRegister : Form
    {

        MainController controller = MainController.GetInstance();
        private char sex;
        private int BehandlerId;
        public AnimalHouseGui_DyrRegister()
        {
            InitializeComponent();
        }

        private void button_RegDyr_Click(object sender, EventArgs e)
        {
            string answer = controller.OpretDyr(controller.HentKundeByTlforNavn(textBox_Søg.Text.Trim())[0].Id, textBox_Art.Text, textBox_Race.Text,int.Parse(textBox_Alder.Text.Trim()), sex, comboBox_behandler.Text);
            MessageBox.Show(answer);
            FilleDataGridView();
        }

        private void FilleDataGridView()
        {
            dataGridView_Dyr.DataSource = controller.HentAlleDyr();
            //dataGridView_Dyr.DataSource = controller.D;
            dataGridView_Dyr.Columns[0].Visible = false;
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_female.Checked = false;
            sex = 'm';
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_male.Checked = false;
            sex = 'f';
        }

        private void button_SøgningDyr_Click(object sender, EventArgs e)
        {
            FilleDataGridView();
        }

        private void button_SletDyr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker?", "Slette Dyr", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(controller.SletDyr(int.Parse(dataGridView_Dyr.CurrentRow.Cells[0].Value.ToString())), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label_hjælpe_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Dyr Form.txt");
        }

        private void button_Søg_Click(object sender, EventArgs e)
        {
            try
            {
                int kundeid = controller.HentKundeByTlforNavn(textBox_Søg.Text.Trim())[0].Id;
                dataGridView_Dyr.DataSource = controller.HentAlleKundesDyr(kundeid);
                dataGridView_Dyr.Columns[0].Visible = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Kunde er ikke registeret i systemet!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox_behandler.Visible = true;
                button_tilknyt.Visible = true;
                comboBox_behandler.DataSource = controller.HentAlleBehandler();
                comboBox_behandler.DisplayMember = "HentNavn";
                BehandlerId = controller.HentAnsatId(comboBox_behandler.Text.Trim());

            }
            else
            {
                comboBox_behandler.Visible = false;
            }
        }

        public void ReturnKundeId(int id)
        {
            int KundeId = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Dyr_DoubleClick(object sender, EventArgs e)
        {
            button_SletDyr.Enabled = true;
        }

        private void button_tilknyt_Click(object sender, EventArgs e)
        {
            bool res =controller.TilknytBehandler(int.Parse(dataGridView_Dyr.CurrentRow.Cells[0].Value.ToString()),comboBox_behandler.Text);
            if (res)
            {
                MessageBox.Show("Behandleren blev tilknyttet");
            }
            else
            {
                MessageBox.Show("Der sket en file","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            FilleDataGridView();
        }
    }
}
