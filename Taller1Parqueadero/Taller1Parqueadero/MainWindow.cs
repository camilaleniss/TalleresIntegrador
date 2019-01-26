using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Taller1Parqueadero.Model;

namespace Taller1Parqueadero
{
    public partial class MainWindow : Form
    {

        private Parking parking;

        public MainWindow()
        {
            InitializeComponent();

            parking = new Parking();
    
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void studentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            codesComboBox.Enabled = studentCheckBox.Checked;
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
