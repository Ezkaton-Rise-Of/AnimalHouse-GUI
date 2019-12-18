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
namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_vedligeHoldProdukter : Form
    {
        ProductController pcont = new ProductController();
        public AnimalHouseGui_vedligeHoldProdukter()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = pcon  
        }

        private void Navn_InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
