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

            UpdateUI();

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
            UpdateUI();
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextField.Text;
            string code = codeTextField.Text;

            if (name != "" && code != "")
            {
                parking.AddUser(code, name);
            }
            else
            {
                MessageBox.Show("Debes ingresar todos los datos", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            UpdateUsers();
            UpdateVehicles();
            availableLabel.Text = "Cupos: " + parking.AvailableSpace;
        }

        private void UpdateUsers()
        {
            LinkedList<User> users = parking.Users;
            codesComboBox.Items.Clear();
            if (users.Count == 0)
            {
                studentCheckBox.Enabled = false;
                studentCheckBox.Checked = false;

            }
            else
            {
                studentCheckBox.Enabled = true;
                foreach (User u in users)
                {
                    codesComboBox.Items.Add(u);
                }
                codesComboBox.SelectedIndex = 0;
            }
            codesComboBox.Enabled = studentCheckBox.Checked;
        }

        private void UpdateVehicles()
        {
            LinkedList<Vehicle> vehicles = parking.CurrentVehicles;
            vehiclesListView.Items.Clear();
            plateComboBox.Items.Clear();
            if (vehicles.Count == 0)
            {
                plateComboBox.Enabled = false;
                removeVehicleButton.Enabled = false;
            }
            else
            {
                plateComboBox.Enabled = true;
                removeVehicleButton.Enabled = true;
                foreach (Vehicle v in vehicles)
                {
                    vehiclesListView.Items.Add(v);
                    plateComboBox.Items.Add(v);
                }

                
                plateComboBox.SelectedIndex = 0;
            }
        }

        private void enterVehicleButton_Click(object sender, EventArgs e)
        {
            string plate = plateTextField.Text;
            bool student = studentCheckBox.Checked;
            if (plate != "")
            {
                User owner = null;
                if(student)
                {
                    owner = (User)codesComboBox.SelectedItem;
                }
                parking.EnterVehicle(owner, plate);
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Debes ingresar la placa", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeVehicleButton_Click(object sender, EventArgs e)
        {
            if (plateComboBox.Enabled)
            {
                parking.RemoveVehicle((Vehicle)plateComboBox.SelectedItem);
                UpdateUI();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
     
            MessageBox.Show(parking.showUsers(), "Lista", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vehiclesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
