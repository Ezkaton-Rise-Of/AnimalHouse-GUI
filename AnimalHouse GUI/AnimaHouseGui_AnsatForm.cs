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
using AnimalHouseBLL;


namespace AnimalHouse_GUI
{
    public partial class AnimaHouseGui_AnsatForm : Form
    {
        MainController controller = new MainController();
        private int id;
        public AnimaHouseGui_AnsatForm()
        {
            InitializeComponent();
        }

        private void buttonTilbage_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AnimalHouseGui_Main main = new AnimalHouseGui_Main();
            main.ShowDialog();
        }
        private void FillDataGridView()
        {
            dataGridView1.DataSource = controller.HentAlleAnsate();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = controller.HentAnsatByNavn2(textBox_ansatNavn.Text.Trim());
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controller.OpretAnsat(textBox_navn.Text.Trim(), comboBox_stelling.SelectedItem.ToString(),textBox_tlf.Text.Trim()), "Oprettelse af ny ansat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView();
        }

        private void button_Hent_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void button_Slet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker?", "Slette ansat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(controller.SletAnsat(id), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                FillDataGridView();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    button_Slet.Enabled = true;
                    button_Update.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker?", "Update ansat information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(controller.UpdateAnsat(id,textBox_navn.Text.Trim(), comboBox_stelling.SelectedItem.ToString().Trim(), textBox_tlf.Text.Trim()), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
            }
        }

        private void ClearForm()
        {
            textBox_navn.Text = "";
            comboBox_stelling.Text = "";
            textBox_tlf.Text = "";
        }
    }
}
