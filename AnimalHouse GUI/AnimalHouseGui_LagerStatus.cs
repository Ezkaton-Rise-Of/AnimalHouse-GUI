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

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_LagerStatus : Form
    {
        MainController controller = new MainController();
        private List<LagerStatus> L;
        private int statusid;
        private string varenummer;


        public AnimalHouseGui_LagerStatus()
        {
            //Initialized
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            dataGridView_LagerStatus.DataSource = controller.HentLagerStatuses();
            dataGridView_LagerStatus.Columns[0].Visible = false;
        }

        private void AnimalHouseGui_Lager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test_LagerDataSet.LagerStatus' table. You can move, or remove it, as needed.
            this.lagerStatusTableAdapter.Fill(this.test_LagerDataSet.LagerStatus);

        }

        private void FillDataGridview()
        {
  
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Tilbage_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main lagerForm = new AnimalHouseGui_Main();
            lagerForm.ShowDialog();
        }

        private void button_SøgLager_Click(object sender, EventArgs e)
        {
            dataGridView_LagerStatus.DataSource = controller.HentLagerStatuses();
            FillDataGridView();
        }

        private void dataGridView_LagerStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
