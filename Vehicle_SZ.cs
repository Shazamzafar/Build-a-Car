//Name:         Shazam Zafar
// Claas:       C#
//Date:         04/27/2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inventory_Zafar
{
    class Vehicle_SZ
    {
        // 4 string variable and 3 integ variable for all my 7 values 
        string vehicleVIN_SZ;
        string Vehicle_Make_SZ_SZ;
        string Vehicle_Model_SZ_SZ;

        int Vehicle_Year_SZ_SZ;
        int Vehicle_Invoice_SZ_SZ;
        int Vehicle_Mileage_SZ_SZ;

        string Vehicle_vehiclePurchase_Date_SZ;

        //Create two  public lists for the 2 vehicles
        public static List<Car_SZ> Car_List_SZ;
        public static List<Truck_SZ> Truck_List_SZ;

        // Public int variable for radio button
        public static int vehicleSelection;

        public Vehicle_SZ()
        {
            // initializing the values
            vehicleVIN_SZ = "";
            Vehicle_Make_SZ_SZ = "";
            Vehicle_Model_SZ_SZ = "";

            Vehicle_Year_SZ_SZ = 0;
            Vehicle_Invoice_SZ_SZ = 0;
            Vehicle_Mileage_SZ_SZ = 0;

            Vehicle_vehiclePurchase_Date_SZ = "";
        }

        public string VIN_SZ
        {
            // Vehicle VIN Property
            get { return vehicleVIN_SZ; }
            set { vehicleVIN_SZ = value; }
        }

        public string Make_SZ
        {
            // Vehicle Make Property
            get { return Vehicle_Make_SZ_SZ; }
            set { Vehicle_Make_SZ_SZ = value; }
        }

        public string Model_SZ
        {
            // Vehicle Model Property
            get { return Vehicle_Model_SZ_SZ; }
            set { Vehicle_Model_SZ_SZ = value; }
        }

        public int Year_SZ
        {
            // Vehicle Year Property
            get { return Vehicle_Year_SZ_SZ; }
            set { Vehicle_Year_SZ_SZ = value; }
        }

        public int Invoice_SZ
        {
            // Vehicle Invoice Property
            get { return Vehicle_Invoice_SZ_SZ; }
            set { Vehicle_Invoice_SZ_SZ = value; }
        }

        public int Mileage_SZ
        {
            // Vehicle Milage Property
            get { return Vehicle_Mileage_SZ_SZ; }
            set { Vehicle_Mileage_SZ_SZ = value; }
        }

        public string PurchaseDate_SZ
        {
            // Vehicle Purchase Date Property
            get { return Vehicle_vehiclePurchase_Date_SZ; }
            set { Vehicle_vehiclePurchase_Date_SZ = value; }
        }
    }
}
