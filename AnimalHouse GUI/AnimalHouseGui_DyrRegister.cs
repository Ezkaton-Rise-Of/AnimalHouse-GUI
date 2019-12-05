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
        private List<Kunde> k;
        private int id;
        private int BehandlerId;
        public AnimalHouseGui_DyrRegister()
        {
            InitializeComponent();
        }

        private void label_Underart_Click(object sender, EventArgs e)
        {

        }

        private void button_RegDyr_Click(object sender, EventArgs e)
        {
            string answer = controller.OpretDyr(k[0].Id, textBox_Art.Text, textBox_Race.Text,int.Parse(textBox_Alder.Text.Trim()), sex);
            MessageBox.Show(answer);
            FilleDataGridView();
        }

        private void FilleDataGridView()
        {
            dataGridView_Dyr.DataSource = controller.HentAlleDyr();
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

        private void textBox_EjerNavn_Leave(object sender, EventArgs e)
        {
            k = controller.K;
            if (k is null)
            {
                if (MessageBox.Show("Kunde er ikke registeret!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Hide();
                    AnimalHouseGui_Register register = new AnimalHouseGui_Register();
                    register.ShowDialog();
                }
            }
        }

        private void dataGridView_Dyr_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Dyr.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView_Dyr.CurrentRow.Cells[0].Value.ToString());
                    dataGridView_Dyr.Enabled = true;
                    dataGridView_Dyr.Enabled = true;
                    button_SletDyr.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_SøgningDyr_Click(object sender, EventArgs e)
        {
            FilleDataGridView();
        }

        private void button_SletDyr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker?", "Slette Dyr", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(controller.SletDyr(id), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FilleDataGridView();
            }
        }

        private void label_hjælpe_Click(object sender, EventArgs e)
        {

        }

        private void button_Søg_Click(object sender, EventArgs e)
        {
            dataGridView_Dyr.DataSource = controller.HentAlleKundesDyr(k[0].Id);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Visible = true;
                comboBox1.DataSource = controller.HentAlleAnsate();
                comboBox1.DisplayMember = "GetName";
                BehandlerId = controller.HentAnsatId(comboBox1.Text.Trim());

            }
            else
            {
                comboBox1.Visible = false;
            }
        }
    }
}
