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

        MainController controller = new MainController();
        private char sex;
        private int BehandlerId;
        public AnimalHouseGui_DyrRegister()
        {
            InitializeComponent();
        }

        private void button_RegDyr_Click(object sender, EventArgs e)
        {
            string answer = controller.OpretDyr(controller.HentKundeByTlforNavn(textBox_Søg.Text.Trim())[0].Id, textBox_Art.Text, textBox_Race.Text,int.Parse(textBox_Alder.Text.Trim()), sex);
            MessageBox.Show(answer);
            FilleDataGridView();
        }

        private void FilleDataGridView()
        {
            controller.HentAlleDyr();
            dataGridView_Dyr.DataSource = controller.D;
            dataGridView_Dyr.Columns[0].Visible = false;
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main main = new AnimalHouseGui_Main();
            main.ShowDialog();
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

        }

        private void button_Søg_Click(object sender, EventArgs e)
        {
            int kundeid = controller.HentKundeByTlforNavn(textBox_Søg.Text.Trim())[0].Id;
            dataGridView_Dyr.DataSource = controller.HentAlleKundesDyr(kundeid);
            dataGridView_Dyr.Columns[0].Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Visible = true;
                comboBox1.DataSource = controller.HentAlleBehandler();
                comboBox1.DisplayMember = "HentNavn";
                BehandlerId = controller.HentAnsatId(comboBox1.Text.Trim());

            }
            else
            {
                comboBox1.Visible = false;
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
    }
}
