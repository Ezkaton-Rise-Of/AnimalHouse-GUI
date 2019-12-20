using AnimaleHouseModel;
using AnimalHouseBLL;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouse_MailForm : Form
    {
        EmailSystem emailSystem = new EmailSystem();
        MainController controller = MainController.GetInstance;
        public AnimalHouse_MailForm()
        {
            InitializeComponent();
        }
        private void button_Tilbage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {

        }

        private void button_tilføj_Click(object sender, EventArgs e)
        {
            listBox_modtagere.Items.Add(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }

        private void button_visAlle_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.MailSendelse().Tables[0].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.MailSendelse2(int.Parse(textBox_days.Text.Trim())).Tables[0].DefaultView;

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            controller.HentAlleDyr();
            string path = @"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Email list.txt";
            using (TextWriter tw = new StreamWriter(path))
            {
                tw.WriteLine("Kundes fornavn\t Kundes efternavn\t Kundes email adresse\t Sidste besøg dato\t DyrId\t DyrArt\t DyrRace\n");
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}\t");

                        if (j != dataGridView1.Columns.Count - 1)
                        {
                            tw.Write("\t");
                        }
                    }
                    tw.WriteLine();
                }
                Process.Start(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Email list.txt");
            }

        }

        private bool Validateform()
        {
            if (listBox_modtagere.Items.Count != 0
                && textBox_subjekt.Text.Length != 0
                && textBox_inhold.Text.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.MailSendelse2(int.Parse(textBox_days.Text)).Tables[0].DefaultView; ;
        }

        private void button_annullere_Click(object sender, EventArgs e)
        {
            listBox_modtagere.Items.Clear();
            textBox_subjekt.Text = "";
            textBox_inhold.Text = "";
        }

        private void button_send_Click_1(object sender, EventArgs e)
        {
            if (Validateform())
            {
                var modtagerList = listBox_modtagere.Items.Cast<String>().ToList();
                bool res = emailSystem.CreateEmail(textBox_subjekt.Text, textBox_inhold.Text, modtagerList);
                if (res is true)
                {
                    MessageBox.Show("mail blev sendt");
                }
                else
                {
                    MessageBox.Show("der sket en fejl!");
                }
            }
            else
            {
                MessageBox.Show("Invald data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_fjern_Click_1(object sender, EventArgs e)
        {
            listBox_modtagere.Items.Remove(listBox_modtagere.SelectedItem);
        }

        private void label_hjælpe_Click_1(object sender, EventArgs e)
        {
            Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Text_Fiels\Mail Form.txt");
        }
    }
}
