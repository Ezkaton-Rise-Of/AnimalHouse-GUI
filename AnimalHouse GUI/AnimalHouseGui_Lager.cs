using AnimalHouseBLL;
using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System_Entities;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Lager : Form
    {
        MainController controller = MainController.GetInstance;

        public AnimalHouseGui_Lager()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void AnimalHouseGui_Lager_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_LagerStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Udfylder dataGridView
        private void FillDataGridView()
        {
            dataGridView_LagerStatus.DataSource = controller.HentLager();
            dataGridView_LagerTilføj.DataSource = controller.HentLager(); 
            //dataGridView_LagerStatus.Rows[]
            //dataGridView_LagerStatus.Rows
            //dataGridView_LagerStatus.Columns
            //dataGridView_LagerStatus.Columns
            //dataGridView_LagerTilføj.Rows
            //dataGridView_LagerTilføj.Rows
            //dataGridView_LagerTilføj.Columns
            //dataGridView_LagerTilføj.Columns

        }

        private void ClearDataGridView()
        {
            dataGridView_LagerTilføj.DataSource = null;
            dataGridView_LagerTilføj.Rows.Clear();
            dataGridView_LagerTilføj.Refresh();
        }


        private void button_PrintStatus_Click_1(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\Users\Kenneth\Desktop\Lager Status\Lager.txt");
            writer.Write(richTextBox_UdskrivStatus.Text);
            writer.Close();
            MessageBox.Show("Fil Eksporteret");
        }

        //Går tilbage til hoved menu
        private void button_Tilbage_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main main = new AnimalHouseGui_Main();
            main.ShowDialog();
        }

        //Skriver lager til RichTextBox
        private void button_UdskriftStatus_Click_1(object sender, EventArgs e)
        {

                
                foreach (DataGridViewRow row in dataGridView_LagerStatus.Rows)
                {
                    var cell1 = row.Cells[0].Value;
                    if (cell1 != null)

                    {

                    richTextBox_UdskrivStatus.Text += cell1.ToString();
                    richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text + "     Pris  ";

                }

                var cell2 = row.Cells[1].Value;
                if (cell2 != null)

                {

                    richTextBox_UdskrivStatus.Text += cell2.ToString();
                    richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text + "     Antal  ";

                }

                var cell3 = row.Cells[2].Value;
                if (cell3 != null)

                {

                    richTextBox_UdskrivStatus.Text += cell3.ToString();
                    richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text + "     Produkt  ";
                }

                for (int i = 0; i < dataGridView_LagerStatus.Rows.Count; i++)
                {


                   richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text + "_____________";

                   
                }

                for (int j = 0; j < dataGridView_LagerStatus.Columns.Count; j++)
                {
                    richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text + "  ";
                }
            }


        }


        //Søg i lageret ved hjælp af ProduktId
        private void button_SøgLagerStatus_Click_1(object sender, EventArgs e)
        {
            // dataGridView_LagerStatus.DataSource = controller.SøgId(textBox_SøgId.Text.Trim());
            if (dataGridView_LagerStatus.Rows.Count == 0)
            {
                MessageBox.Show("Id ikke fundet");
            }
        }

        private void dataGridView_LagerStatus_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox_UdskrivStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label_hjælpe_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//button_Tilføj
        {
            //MessageBox.Show(controller.TilføjLager(textBox_Pris.Text.Trim(), textBox_Antal.Text.Trim(), textBox_Produkt.Text.Trim(), "Lagervare tilføjet", MessageBoxButtons.OK, MessageBoxIcon.Information));
            //FillDataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//dataGridView_Lager
        {
 
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            FillDataGridView();
        }

        private void textBox_Pris_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Antal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Produkt_TextChanged(object sender, EventArgs e)
        {

        }
    }

}