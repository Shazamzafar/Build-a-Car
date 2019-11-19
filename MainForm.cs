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
using System.IO; // For file
namespace Vehicle_Inventory_Zafar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Live date and Time
            timer1.Start();
            Time_Label.Text = DateTime.Now.ToLongTimeString();

            Date_Label.Text = DateTime.Now.ToLongDateString();
            try
            {
                //create the list object for car and truck
                Vehicle_SZ.Car_List_SZ = new List<Car_SZ>(); // Car List Object
                Vehicle_SZ.Truck_List_SZ = new List<Truck_SZ>(); // Truck List Object

                StreamReader Car_Reader_SZ = new StreamReader("Cars.txt"); // car file 
                StreamReader Truck_Reader_SZ = new StreamReader("Trucks.txt"); // truck file

                string Each_Object_SZ = ""; 
                string[] Spilt_Object_SZ = new string[7]; // 7 spaces for my 7 values

                while (!Car_Reader_SZ.EndOfStream) // loop puts every value in order
                {
                    Car_SZ carVehicle = new Car_SZ(); //declare
                    Each_Object_SZ = Car_Reader_SZ.ReadLine();
                    Spilt_Object_SZ = Each_Object_SZ.Split(',');
                    carVehicle.VIN_SZ = Spilt_Object_SZ[0];
                    carVehicle.Make_SZ = Spilt_Object_SZ[1];
                    carVehicle.Model_SZ = Spilt_Object_SZ[2];
                    carVehicle.Year_SZ = int.Parse(Spilt_Object_SZ[3]);
                    carVehicle.Invoice_SZ = int.Parse(Spilt_Object_SZ[4]);
                    carVehicle.Mileage_SZ = int.Parse(Spilt_Object_SZ[5]);
                    carVehicle.PurchaseDate_SZ = Spilt_Object_SZ[6];
                    Vehicle_SZ.Car_List_SZ.Add(carVehicle);
                }
                //close car reader
                Car_Reader_SZ.Close();

                while (!Truck_Reader_SZ.EndOfStream) // same loop for truck
                {
                    Truck_SZ truckVehicle = new Truck_SZ(); //declare
                    Each_Object_SZ = Truck_Reader_SZ.ReadLine(); 
                    Spilt_Object_SZ = Each_Object_SZ.Split(',');
                    truckVehicle.VIN_SZ = Spilt_Object_SZ[0];
                    truckVehicle.Make_SZ = Spilt_Object_SZ[1];
                    truckVehicle.Model_SZ = Spilt_Object_SZ[2];
                    truckVehicle.Year_SZ = int.Parse(Spilt_Object_SZ[3]);
                    truckVehicle.Invoice_SZ = int.Parse(Spilt_Object_SZ[4]);
                    truckVehicle.Mileage_SZ = int.Parse(Spilt_Object_SZ[5]);
                    truckVehicle.PurchaseDate_SZ = Spilt_Object_SZ[6];
                    Vehicle_SZ.Truck_List_SZ.Add(truckVehicle);
                }
                //close truck reader
                Truck_Reader_SZ.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Exception
            }


        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Live Time 
            Time_Label.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void More_Info_BTN_Click(object sender, EventArgs e)
        {
            //Radio Button Selection

            if (Car_Radio_Button.Checked)
                Vehicle_SZ.vehicleSelection = 1;
            else if (Truck_Radio_BTN.Checked)
                Vehicle_SZ.vehicleSelection = 2;
            else
                Vehicle_SZ.vehicleSelection = 0;

            //go to vehicle information form
            if (Vehicle_SZ.vehicleSelection != 0)
            {
                Second_Form aVehicleForm = new Second_Form();
                aVehicleForm.ShowDialog();
            }
            else
                MessageBox.Show("Select A Vehicle To Procced."); // Message box if nothing is selected
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //asking the user if they want to save their changes
                DialogResult Result_SZ;
                Result_SZ = MessageBox.Show("Save data?", "Save", MessageBoxButtons.YesNoCancel);
                if (Result_SZ == System.Windows.Forms.DialogResult.Yes) //if yes to save data
                {
                    StreamWriter Car_Writer_SZ = new StreamWriter("Cars.txt"); // writing to file
                    foreach (Car_SZ aVehicle in Vehicle_SZ.Car_List_SZ) // loop put , between each value
                    {
                        Car_Writer_SZ.Write(aVehicle.VIN_SZ + ",");
                        Car_Writer_SZ.Write(aVehicle.Make_SZ + ",");
                        Car_Writer_SZ.Write(aVehicle.Model_SZ + ",");
                        Car_Writer_SZ.Write(aVehicle.Year_SZ + ",");
                        Car_Writer_SZ.Write(aVehicle.Invoice_SZ + ",");
                        Car_Writer_SZ.Write(aVehicle.Mileage_SZ + ",");
                        Car_Writer_SZ.WriteLine(aVehicle.PurchaseDate_SZ);
                    }
                    //closing the car writer file
                    Car_Writer_SZ.Close();

                    StreamWriter Truck_Writer_SZ = new StreamWriter("Trucks.txt"); // writing to file
                    foreach (Truck_SZ aVehicle in Vehicle_SZ.Truck_List_SZ) // loop put , between each value
                    {
                        Truck_Writer_SZ.Write(aVehicle.VIN_SZ + ",");
                        Truck_Writer_SZ.Write(aVehicle.Make_SZ + ",");
                        Truck_Writer_SZ.Write(aVehicle.Model_SZ + ",");
                        Truck_Writer_SZ.Write(aVehicle.Year_SZ + ",");
                        Truck_Writer_SZ.Write(aVehicle.Invoice_SZ + ",");
                        Truck_Writer_SZ.Write(aVehicle.Mileage_SZ + ",");
                        Truck_Writer_SZ.WriteLine(aVehicle.PurchaseDate_SZ);
                    }
                    //closing the truck writer file
                    Truck_Writer_SZ.Close();

                }
                else if (Result_SZ == System.Windows.Forms.DialogResult.Cancel) //if cancle don't close program and dont save
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Exception
            }
        }

        private void Create_Vehicle_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (Car_Radio_Button.Checked)
                {
                    // variable for textboxes
                    int Year_SZ, Invoice_SZ, Mileage_SZ;
                    int.TryParse(Vehicle_Year_SZ_M_TexTBox.Text, out Year_SZ);
                    int.TryParse(Invoice_SZ_Price_M_TexTBox.Text, out Invoice_SZ);
                    int.TryParse(Mileage_SZ_M_TexTBox.Text, out Mileage_SZ);
                    // date variable
                    DateTime PurchaseDate_SZ;
                    DateTime.TryParse(Date_Purchased_M_TexTBox.Text, out PurchaseDate_SZ);

                    //Calling my data Valdation 
                    bool Validation_M_SZ;
                    Validation_M_SZ = CheckValid(Year_SZ, Invoice_SZ, Mileage_SZ, PurchaseDate_SZ);

                    if (Validation_M_SZ)
                    {
                        //If everything passeses create the car and set its properties

                        Car_SZ My_Car_SZ = new Car_SZ();
                        My_Car_SZ.VIN_SZ = WinNum_M_TexTBox.Text;
                        My_Car_SZ.Make_SZ = Make_SZ_M_TexTBox.Text;
                        My_Car_SZ.Model_SZ = Model_SZ_M_TexTBox.Text;
                        My_Car_SZ.Year_SZ = Year_SZ;
                        My_Car_SZ.Invoice_SZ = Invoice_SZ;
                        My_Car_SZ.Mileage_SZ = Mileage_SZ;
                        My_Car_SZ.PurchaseDate_SZ = PurchaseDate_SZ.ToString();
                        //adding car to my list
                        Vehicle_SZ.Car_List_SZ.Add(My_Car_SZ);
                        MessageBox.Show("Congratulations" + Environment.NewLine + " New Car Added.");

                        //clear text boxes for next vehicle
                        WinNum_M_TexTBox.Text = "";
                        Make_SZ_M_TexTBox.Text = "";
                        Model_SZ_M_TexTBox.Text = "";
                        Vehicle_Year_SZ_M_TexTBox.Text = "";
                        Invoice_SZ_Price_M_TexTBox.Text = "";
                        Mileage_SZ_M_TexTBox.Text = "";
                        Date_Purchased_M_TexTBox.Text = "MM/DD/YYYY";
                    }
                }
                else if (Truck_Radio_BTN.Checked)
                {
                    // variable for textboxes
                    int Year_SZ, Invoice_SZ, Mileage_SZ;
                    int.TryParse(Vehicle_Year_SZ_M_TexTBox.Text, out Year_SZ);
                    int.TryParse(Invoice_SZ_Price_M_TexTBox.Text, out Invoice_SZ);
                    int.TryParse(Mileage_SZ_M_TexTBox.Text, out Mileage_SZ);
                    // date variable
                    DateTime PurchaseDate_SZ;
                    DateTime.TryParse(Date_Purchased_M_TexTBox.Text, out PurchaseDate_SZ);

                    //Calling my data Valdation 
                    bool Validation_M_SZ;
                    Validation_M_SZ = CheckValid(Year_SZ, Invoice_SZ, Mileage_SZ, PurchaseDate_SZ);

                    if (Validation_M_SZ)
                    {
                        //If everything passeses create the car and set its properties
                        Truck_SZ My_Truck_SZ = new Truck_SZ();
                        My_Truck_SZ.VIN_SZ = WinNum_M_TexTBox.Text;
                        My_Truck_SZ.Make_SZ = Make_SZ_M_TexTBox.Text;
                        My_Truck_SZ.Model_SZ = Model_SZ_M_TexTBox.Text;
                        My_Truck_SZ.Year_SZ = Year_SZ;
                        My_Truck_SZ.Invoice_SZ = Invoice_SZ;
                        My_Truck_SZ.Mileage_SZ = Mileage_SZ;
                        My_Truck_SZ.PurchaseDate_SZ = PurchaseDate_SZ.ToString();
                        //Adding truck to my list
                        Vehicle_SZ.Truck_List_SZ.Add(My_Truck_SZ);
                        MessageBox.Show("Congratulations" + Environment.NewLine + " New Truck Added.");

                        //clear text boxes for next vehicle
                        WinNum_M_TexTBox.Text = "";
                        Make_SZ_M_TexTBox.Text = "";
                        Model_SZ_M_TexTBox.Text = "";
                        Vehicle_Year_SZ_M_TexTBox.Text = "";
                        Invoice_SZ_Price_M_TexTBox.Text = "";
                        Mileage_SZ_M_TexTBox.Text = "";
                        Date_Purchased_M_TexTBox.Text = "MM/DD/YYYY";
                    }
                    else
                    {
                        // if none vehicle type is selected show this message
                        MessageBox.Show("Error" + Environment.NewLine + "Select a vehicle Type.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Exception
            }
        }

        //Create a long validation method 
        private bool CheckValid(int Year_SZ, int Invoice_SZ, int Mileage_SZ, DateTime PurchaseDate_SZ)
        {
            if (WinNum_M_TexTBox.Text.Trim() == "" || WinNum_M_TexTBox.TextLength > 10 || WinNum_M_TexTBox.TextLength < 10 || !char.IsDigit(WinNum_M_TexTBox.Text[0]) || !char.IsDigit(WinNum_M_TexTBox.Text[1]) || !char.IsLower(WinNum_M_TexTBox.Text[2]) || !char.IsLower(WinNum_M_TexTBox.Text[3]) || !char.IsSymbol(WinNum_M_TexTBox.Text[4]) || !char.IsDigit(WinNum_M_TexTBox.Text[5]) || !char.IsDigit(WinNum_M_TexTBox.Text[6]) || !char.IsDigit(WinNum_M_TexTBox.Text[7]) || !char.IsDigit(WinNum_M_TexTBox.Text[8]) || !char.IsDigit(WinNum_M_TexTBox.Text[9]))
            {
                // validation for VIN Number
                MessageBox.Show("Error" + Environment.NewLine + "VIN Number Must Be Unique" + Environment.NewLine+ "VIN# must be 10 characters. First two must be numbers, next two must be lower case letters, fifth must be a special character and the rest must be numbers");
                return false;
            }
            if (Make_SZ_M_TexTBox.Text.Trim() == "")
            {
                // validation for make 
                MessageBox.Show("Error" + Environment.NewLine + "Make is a Required ");
                return false;
            }
            if (Model_SZ_M_TexTBox.Text.Trim() == "")
            {
                // Validation for Model
                MessageBox.Show("Error" + Environment.NewLine + "Model is a Required ");
                return false;
            }
            if (Vehicle_Year_SZ_M_TexTBox.Text.Trim() == "" || Year_SZ < 1900 || Year_SZ > 2018)
            {
                // Validation for Year
                MessageBox.Show("Error" + Environment.NewLine + " Year Must between 1900 - 2018");
                return false;
            }
            if (Invoice_SZ_Price_M_TexTBox.Text.Trim() == "" || Invoice_SZ < 0 || Invoice_SZ > 100000)
            {
                // Validation for Year
                MessageBox.Show("Price  must be between 0 to 100000(inclusive).");
                return false;
            }
            if (Mileage_SZ_M_TexTBox.Text.Trim() == "" || Mileage_SZ < 0)
            {
                // Validation for Mileage
                MessageBox.Show("Error" + Environment.NewLine + "Mileage must be Greater Than Or Equal to 0.");
                return false;
            }
            if (Date_Purchased_M_TexTBox.Text.Trim() == "" || Date_Purchased_M_TexTBox.Text == "MM/DD/YYYY" || PurchaseDate_SZ > DateTime.Today)
            {
                MessageBox.Show("Error" + Environment.NewLine + "Date Entry Must Be Today's Or Earlier.");
                return false;
            }
            return true;
        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            // close the program
            Close();
        }
    }
}
