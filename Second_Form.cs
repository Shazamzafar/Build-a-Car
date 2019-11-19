//Name:         Shazam Zafar
// Claas:       C#
//Date:         04/27/2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Inventory_Zafar
{
    public partial class Second_Form : Form
    {
        public Second_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Live Time 
            Time_Label.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Second_Form_Load(object sender, EventArgs e)
        {
            // Live date and Time
            timer1.Start();
            Time_Label.Text = DateTime.Now.ToLongTimeString();

            Date_Label.Text = DateTime.Now.ToLongDateString();

            //load list box with correct vehicle info ( vehicle selection 1 = car 2 = truck)
            if (Vehicle_SZ.vehicleSelection == 1)
            {
                // This is car information
                foreach (Car_SZ car in Vehicle_SZ.Car_List_SZ)
                {
                    WinNum_ListBox.Items.Add(car.VIN_SZ);
                }
            }
            else if (Vehicle_SZ.vehicleSelection == 2)
            {
                foreach (Truck_SZ truck in Vehicle_SZ.Truck_List_SZ)
                {
                    // this is truck information
                    WinNum_ListBox.Items.Add(truck.VIN_SZ);
                }
            }

        }

        private void WinNum_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WinNum_ListBox.SelectedIndex != -1)
            {
                //if statment to find out if its a car or truck
                int row = WinNum_ListBox.SelectedIndex;
                if (Vehicle_SZ.vehicleSelection == 1)
                {
                    // if its equal one then its car then displays all values in the correct labels
                    WinNum_S_Label.Text = Vehicle_SZ.Car_List_SZ[row].VIN_SZ;
                    Make_SZ_S_LabeL.Text = Vehicle_SZ.Car_List_SZ[row].Make_SZ;
                    Model_SZ_S_Label.Text = Vehicle_SZ.Car_List_SZ[row].Model_SZ;
                    Year_SZ_S_LBL.Text = Vehicle_SZ.Car_List_SZ[row].Year_SZ.ToString();
                    Invoice_SZ_Price_S_Label.Text = Vehicle_SZ.Car_List_SZ[row].Invoice_SZ.ToString("C");
                    Mileage_SZ_S_Label.Text = Vehicle_SZ.Car_List_SZ[row].Mileage_SZ.ToString();
                    Date_Purchased_S_label.Text = Vehicle_SZ.Car_List_SZ[row].PurchaseDate_SZ;
                }
                else if (Vehicle_SZ.vehicleSelection == 2)
                    // if user selected 2 then its truck then display all the values in truck labels
                {
                    WinNum_S_Label.Text = Vehicle_SZ.Truck_List_SZ[row].VIN_SZ;
                    Make_SZ_S_LabeL.Text = Vehicle_SZ.Truck_List_SZ[row].Make_SZ;
                    Model_SZ_S_Label.Text = Vehicle_SZ.Truck_List_SZ[row].Model_SZ;
                    Year_SZ_S_LBL.Text = Vehicle_SZ.Truck_List_SZ[row].Year_SZ.ToString();
                    Invoice_SZ_Price_S_Label.Text = Vehicle_SZ.Truck_List_SZ[row].Invoice_SZ.ToString("C");
                    Mileage_SZ_S_Label.Text = Vehicle_SZ.Truck_List_SZ[row].Mileage_SZ.ToString();
                    Date_Purchased_S_label.Text = Vehicle_SZ.Truck_List_SZ[row].PurchaseDate_SZ;
                }
                else
                {
                    MessageBox.Show("Error" + Environment.NewLine +"You Need To Select A Vehicle To View Items");
                }
            }
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            // closes the application
            this.Close();
        }
    }
    }

