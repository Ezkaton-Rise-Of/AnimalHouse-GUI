using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Service : Form
    {
        public AnimalHouseGui_Service()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_InsertNewService_Click(object sender, EventArgs e)
        {

        }

        private void textBox_InsertNewService_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AnimalHouseGui_Service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test102DataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.test102DataSet.Service);

        }
    }
}
