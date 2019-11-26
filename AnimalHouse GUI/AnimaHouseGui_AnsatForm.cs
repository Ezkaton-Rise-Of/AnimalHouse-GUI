using AnimalHouseBLL;
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
    public partial class AnimaHouseGui_AnsatForm : Form
    {
        MainController controller = new MainController();
        public AnimaHouseGui_AnsatForm()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void buttonTilbage_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AnimalHouseGui_Main main = new AnimalHouseGui_Main();
            main.ShowDialog();
        }
        private void FillDataGridView()
        {
            dataGridView1.DataSource = controller.HentAlleAnsate();
        }
    }
}
