using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGUI_JournalForm : Form
    {
        public AnimalHouseGUI_JournalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            DataSet set = new DataSet();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * from Kunde INNER JOIN Postnr on Kunde.Postnummer = Postnr.Postnummer";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(set);
                dataGridView1.DataSource = set.Tables[0].DefaultView;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main mainform = new AnimalHouseGui_Main();
            mainform.ShowDialog();
        }
    }
}
