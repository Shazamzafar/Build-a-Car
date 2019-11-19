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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Login_BTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Email_TextBox.Text.Trim() == "user" && Pwd_TextBox.Text.Trim() == "1234")


                {
                    // Next Page
                    MainForm MyMainPage = new MainForm();
                    MyMainPage.ShowDialog();
                }

                else
                {
                    MessageBox.Show("User Name or Password  is Incorrect"); // Error Message
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Exception
            }
        }
         

        private void Exit_BTN_Click_1(object sender, EventArgs e)
        {
            // close the application 
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Live date and Time
            timer1.Start();
            Time_Label.Text = DateTime.Now.ToLongTimeString();

            Date_Label.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Live Time 
            Time_Label.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
