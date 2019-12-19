// Radwan
using AnimaleHouseModel;
using AnimalHouse_Entities;
using AnimalHouseBLL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGUI_SalgForm : Form
    {
        SalgSystem salgSystem;
        MainController controller;
        List<Produkt> Salgpordukter = new List<Produkt>();
        private string produkter = "";
        public AnimalHouseGUI_SalgForm()
        {
            InitializeComponent();
            controller = MainController.GetInstance;
            salgSystem = new SalgSystem();
            comboBox_kunde.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_kategori.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_produkter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_kunde2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_tilbage_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void label_hjælpe_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Text_Fiels\Salg Form.txt");
        }

        private void button_gem_Click(object sender, EventArgs e)
        {
            //henter Kunder iden
            var kundenavn = comboBox_kunde2.Text.Split(' ');
            int kundeid = controller.HentKundeId(kundenavn[0]);
            string res = controller.GemFaktura(kundeid,label_res.Text,textBox_rabat.Text.Trim(),produkter);
            MessageBox.Show(res);
        }

        private void button_fjerne_Click(object sender, EventArgs e)
        {
            listBox_produkter.Items.Remove(listBox_produkter.SelectedItem);

        }

        private void textBox_rabat_TextChanged(object sender, EventArgs e)
        {
            if (textBox_rabat.Text.Length > 2)
            {
                MessageBox.Show("rabat værdi er ikke kort!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_rabat.Text = "12";
            }
        }

        private void button_søg_Click(object sender, EventArgs e)
        {
            //henter Kunder iden
            var kundenavn = comboBox_kunde2.Text.Split(' ');
            int kundeid = controller.HentKundeId(kundenavn[0]);
            dataGridView1.DataSource = controller.HentKundesFaktura(kundeid);
            dataGridView1.Columns[0].Visible = false;
        }

        private void button_hentAlle_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.HentAlleFaktura();
            dataGridView1.Columns[0].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown_antal.Value != 0)
            {
                listBox_produkter.Items.Add(comboBox_produkter.Text + " *" + numericUpDown_antal.Value.ToString());
                produkter += comboBox_produkter.Text + " *" + numericUpDown_antal.Value.ToString() + "\n";
                foreach (Produkt item in controller.HentAlleProdukter())
                {
                    if (item.HentInfo == comboBox_produkter.Text)
                    {
                        salgSystem.TilføjeItemLine(item, int.Parse(numericUpDown_antal.Value.ToString()));
                    }
                }
            }
            else
            {
                MessageBox.Show("Vælg antal af produkt! Produkt antal var 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            listBox_produkter.Items.Clear();
            label_res.Text = "0Kr.";
            numericUpDown_antal.Value = 0;
            textBox_rabat.Text = "0";

        }

        private void button_beregn_Click(object sender, EventArgs e)
        {
            label_res.Text = salgSystem.HentTotal(double.Parse(textBox_rabat.Text.Trim())).ToString() + "Kr.";
        }

        private void button_annullere_Click(object sender, EventArgs e)
        {
            ClearForm();
            salgSystem = new SalgSystem();
        }

        private void comboBox_kunde2_MouseEnter(object sender, EventArgs e)
        {
            comboBox_kunde2.DataSource = controller.HentAlleKunde();
            comboBox_kunde2.DisplayMember = "GetName";
        }
        private void comboBox_kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in controller.kategorier)
            {
                if (item.KategoriNavn == comboBox_kategori.Text)
                {
                    comboBox_produkter.DataSource = controller.HentAlleProduktByKategori(item);
                    comboBox_produkter.DisplayMember = "Hentinfo";
                }
            }
        }
        private void AnimalHouseGUI_SalgForm_Load(object sender, EventArgs e)
        {
            comboBox_kunde.DataSource = controller.HentAlleKunde();
            comboBox_kunde.DisplayMember = "GetName";
        }

        private void comboBox_kunde_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_kategori.DataSource = controller.HentAlleKategorier();
            comboBox_kategori.DisplayMember = "HentNavn";
        }

        private void button_visRecord_Click(object sender, EventArgs e)
        {
            textBox_info1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_info2.Text = controller.HentKundeById(int.Parse( dataGridView1.CurrentRow.Cells[1].Value.ToString())).GetName;
            textBox_info5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_info4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_info3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_info6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            button_print.Enabled = true;
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            using (StreamWriter tw = new StreamWriter(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Faktura Example.txt"))
            {
                tw.WriteLine("\t\t\t\t Dato:"+textBox_info3.Text);
                tw.WriteLine("Faktura ID: "+ textBox_info1.Text);
                tw.WriteLine("Kunde: "+textBox_info2.Text);
                tw.WriteLine("Produkter:\n"+textBox_info6.Text);
                tw.WriteLine("\t\t\t\t Rabat i %: " + textBox_info4.Text);
                tw.WriteLine("\t\t\t\t Total: " + textBox_info5.Text);
            }
            Process.Start(@"C:\Users\Radwan\source\repos\AnimalHouse-GUI\AnimalHouse GUI\Text_Fiels\Faktura Example.txt");
        }
    }
}
