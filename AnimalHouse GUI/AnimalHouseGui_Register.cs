// Radwan
using AnimalHouseBLL;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Register : Form
    {
        private int id;
        private string kundetype;
        MainController controller = MainController.GetInstance;

        public AnimalHouseGui_Register()
        {
            InitializeComponent();
        }

        private void button_RegEjer_Click(object sender, EventArgs e)
        {
            //string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string email
            if (Validateform())
            {
                string answer = controller.OpretKunde(textBox_Fornavn.Text, textBox_Efternavn.Text, textBox_Vejnavn.Text, textBox_Postnummer.Text, textBox_Telefon.Text, kundetype, textBox_By.Text = controller.HentBynavn(textBox_Postnummer.Text), textBox_Email.Text);
                MessageBox.Show(answer);
                FillDataGridView();
                button_tilføje.Enabled = true;
                ClearForm();
            }
            else
            {
                MessageBox.Show("Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_SletEjer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker? Alle de dyr, der er rigistret under denne kunde, vil blive slettet!", "Slette kunde", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(controller.SletEjer(id), "Slette kunde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                FillDataGridView();
            }
        }

        private void FillDataGridView()
        {
            dataGridView_Ejer.DataSource = controller.HentAlleKunde();
            dataGridView_Ejer.Columns[0].Visible = false;
            dataGridView_Ejer.Columns[10].Visible = false;
        }

        private void button_Søgning_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Postnummer_Leave(object sender, EventArgs e)
        {
            textBox_By.Text = controller.HentBynavn(textBox_Postnummer.Text);
        }

        private void ClearForm()
        {
            textBox_Fornavn.Text = "";
            textBox_Efternavn.Text = "";
            textBox_By.Text = "";
            textBox_Email.Text = "";
            textBox_Postnummer.Text = "";
            textBox_Telefon.Text = "";
            textBox_Vejnavn.Text = "";
        }

        private void dataGridView_Ejer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Ejer.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView_Ejer.CurrentRow.Cells[0].Value.ToString());
                    textBox_Fornavn.Text = dataGridView_Ejer.CurrentRow.Cells[1].Value.ToString();
                    textBox_Efternavn.Text = dataGridView_Ejer.CurrentRow.Cells[2].Value.ToString();
                    textBox_By.Text = dataGridView_Ejer.CurrentRow.Cells[7].Value.ToString();
                    textBox_Email.Text = dataGridView_Ejer.CurrentRow.Cells[9].Value.ToString();
                    textBox_Postnummer.Text = dataGridView_Ejer.CurrentRow.Cells[4].Value.ToString();
                    textBox_Telefon.Text = dataGridView_Ejer.CurrentRow.Cells[5].Value.ToString();
                    textBox_Vejnavn.Text = dataGridView_Ejer.CurrentRow.Cells[3].Value.ToString();
                    if (dataGridView_Ejer.CurrentRow.Cells[6].Value.ToString() == "Private")
                    {
                        radioButton_Private.Checked = true;
                        radioButton_Erhverv.Checked = false;
                    }
                    else
                    {
                        radioButton_Private.Checked = false;
                        radioButton_Erhverv.Checked = true;
                    }
                    button_SletEjer.Enabled = true;
                    UpdateEjerBtn.Enabled = true;
                    button_tilføje.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateEjerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(controller.UpdateKunde(Convert.ToInt32(dataGridView_Ejer.CurrentRow.Cells[0].Value.ToString()), textBox_Fornavn.Text.Trim(), textBox_Efternavn.Text.Trim(), textBox_Vejnavn.Text.Trim(), textBox_Postnummer.Text.Trim(), textBox_Telefon.Text.Trim(), kundetype, textBox_By.Text = controller.HentBynavn(textBox_Postnummer.Text).Trim(), textBox_Email.Text.Trim()));
                ClearForm();
                FillDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label_Help_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + @"\Text_Fiels\Register Form.txt");
        }

        private void radioButton_Private_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Private.Checked)
            {
                radioButton_Erhverv.Checked = false;
                kundetype = "Private";
            }
            if (radioButton_Erhverv.Checked)
            {
                radioButton_Private.Checked = false;
                kundetype = "Erhverv";
            }
        }

        private void button_Søg_Click(object sender, EventArgs e)
        {
            dataGridView_Ejer.DataSource = controller.HentKundeByTlforNavn(textBox_Søg.Text.Trim());
            if (dataGridView_Ejer.Rows.Count == 0)
            {
                MessageBox.Show("Kunden kunne ikke findes!");
            }
        }

        private void button_tilføje_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalHouseGui_DyrRegister dyrRegister = new AnimalHouseGui_DyrRegister();
            dyrRegister.ReturnKundeId(int.Parse(dataGridView_Ejer.CurrentRow.Cells[0].Value.ToString()));
            dyrRegister.ShowDialog();
        }

        private bool Validateform()
        {
            if (textBox_Telefon.Text.Trim().All(char.IsDigit) && textBox_Telefon.Text.Length != 0
                && !textBox_Fornavn.Text.Trim().Any(char.IsDigit) && textBox_Fornavn.Text.Trim().Length != 0
                && !textBox_Efternavn.Text.Trim().Any(char.IsDigit) && textBox_Efternavn.Text.Trim().Length != 0
                && textBox_Email.Text.Trim().Length != 0
                && textBox_Vejnavn.Text.Trim().Length != 0
                && textBox_Postnummer.Text.Trim().All(char.IsDigit)
                && textBox_By.Text.Length != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
