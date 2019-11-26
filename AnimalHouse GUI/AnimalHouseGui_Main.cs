using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Main : Form
    {
        public AnimalHouseGui_Main()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_AnimalHouse1_Click(object sender, EventArgs e)
        {

        }

        private void button_EjerReg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AnimalHouseGui_Register ejerRegister = new AnimalHouseGui_Register();
            ejerRegister.Visible = true;
        }

        private void button_DyrReg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AnimalHouseGui_DyrRegister dyrRegister = new AnimalHouseGui_DyrRegister();
            dyrRegister.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AnimaHouseGui_AnsatForm ansatForm = new AnimaHouseGui_AnsatForm();
            ansatForm.ShowDialog();
        }
    }
}

