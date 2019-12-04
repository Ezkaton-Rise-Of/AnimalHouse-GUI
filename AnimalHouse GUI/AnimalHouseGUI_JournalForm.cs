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
using AnimalHouseBLL;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGUI_JournalForm : Form
    {
        private MainController controller;
        private int id;
        
        public AnimalHouseGUI_JournalForm()
        {
            InitializeComponent();
            controller = new MainController();
            comboBox_behandler.DataSource = controller.HentAlleAnsate();
            comboBox_behandler.DisplayMember = "HentNavn";
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_Gem_Click(object sender, EventArgs e)
        {
            int ansatid = 14;//controller.HentAnsatId(comboBox_behandler.Text);
            comboBox_dyr.DataSource = controller.HentAlleKundesDyr(5);
            int dyrid = 18;
            string beskrivelse = textBox_beskrivelse.Text.Trim();
            string res = controller.OpretJournal(dyrid, ansatid, beskrivelse);
            MessageBox.Show(res);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Slet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
