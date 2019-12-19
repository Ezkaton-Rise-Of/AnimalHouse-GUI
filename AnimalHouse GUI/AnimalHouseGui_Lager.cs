using AnimalHouseBLL;
using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
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



        //Udfylder dataGridView
        private void FillDataGridView()
        {
            dataGridView_LagerStatus.DataSource = controller.HentLager();
            dataGridView_LagerTilføj.DataSource = controller.HentLager(); 

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
            for (int i = 0; i < dataGridView_LagerStatus.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView_LagerStatus.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView_LagerStatus.Rows[i].Cells[j].Value.ToString()
                    + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("____________________________________________________________");
            }
            writer.Close();
            Process.Start(@"C:\Users\Kenneth\Desktop\Lager Status\Lager.txt");
        }

    private void button_Tilbage_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_Main main = new AnimalHouseGui_Main();
            main.ShowDialog();
        }

        //Skriver lager til RichTextBox
        private void button_UdskriftStatus_Click_1(object sender, EventArgs e)
        {
            dataGridView_LagerStatus.Columns[0].Name = "Pris";
            dataGridView_LagerStatus.Columns[1].Name = "Antal";
            dataGridView_LagerStatus.Columns[2].Name = "ProduktId";
            
            

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
                   richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text = richTextBox_UdskrivStatus.Text + "     ProduktId  ";
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
            dataGridView_LagerStatus.DataSource = controller.SøgId (int.Parse( textBox_SøgId.Text));
            if (dataGridView_LagerStatus.Rows.Count == 0)
            {
                MessageBox.Show("Id ikke fundet");
            }
        }

        private void dataGridView_LagerStatus_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)//button_Tilføj
        {
            string Tilføj = controller.TilføjLager(double.Parse(textBox_Pris.Text), int.Parse(textBox_Antal.Text), int.Parse(textBox_Produkt.Text));
            MessageBox.Show(Tilføj);
            FillDataGridView();
        }

        private void label_hjælpe_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Kenneth\Desktop\Lager Status\Hjælp - Lager Status.pdf");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Kenneth\Desktop\Lager Status\Hjælp - Lager Tilføj.pdf");
        }


        private void button_Update_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            FillDataGridView();
        } 
        
        private void AnimalHouseGui_Lager_Load(object sender, EventArgs e)
        {

        }
        private void DataGridView_LagerStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//dataGridView_Lager
        {
 
        }
        private void richTextBox_UdskrivStatus_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

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
        private void tabTilføj_Click(object sender, EventArgs e)
        {

        }
        private void textBox_SøgId_TextChanged(object sender, EventArgs e)
        {

        }

     
    }

}