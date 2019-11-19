namespace Vehicle_Inventory_Zafar
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Time_Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.More_Info_BTN = new System.Windows.Forms.Button();
            this.Create_Vehicle_BTN = new System.Windows.Forms.Button();
            this.Car_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Truck_Radio_BTN = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Make_SZ_M_TexTBox = new System.Windows.Forms.TextBox();
            this.Model_SZ_M_TexTBox = new System.Windows.Forms.TextBox();
            this.Date_Purchased_M_TexTBox = new System.Windows.Forms.TextBox();
            this.Mileage_SZ_M_TexTBox = new System.Windows.Forms.TextBox();
            this.Invoice_SZ_Price_M_TexTBox = new System.Windows.Forms.TextBox();
            this.Vehicle_Year_SZ_M_TexTBox = new System.Windows.Forms.TextBox();
            this.WinNum_M_TexTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Museo Sans For Dell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.Location = new System.Drawing.Point(389, 472);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(42, 19);
            this.Date_Label.TabIndex = 54;
            this.Date_Label.Text = "Date";
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("Museo Sans For Dell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.Location = new System.Drawing.Point(429, 444);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(44, 19);
            this.Time_Label.TabIndex = 53;
            this.Time_Label.Text = "Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(230, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.label9.Font = new System.Drawing.Font("Museo Sans For Dell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(104, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "Please Enter Your Information";
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Exit_BTN.ForeColor = System.Drawing.Color.White;
            this.Exit_BTN.Location = new System.Drawing.Point(389, 521);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(149, 38);
            this.Exit_BTN.TabIndex = 49;
            this.Exit_BTN.Text = "Exit";
            this.Exit_BTN.UseVisualStyleBackColor = false;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // More_Info_BTN
            // 
            this.More_Info_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.More_Info_BTN.ForeColor = System.Drawing.Color.White;
            this.More_Info_BTN.Location = new System.Drawing.Point(207, 521);
            this.More_Info_BTN.Name = "More_Info_BTN";
            this.More_Info_BTN.Size = new System.Drawing.Size(149, 38);
            this.More_Info_BTN.TabIndex = 48;
            this.More_Info_BTN.Text = "View More Information";
            this.More_Info_BTN.UseVisualStyleBackColor = false;
            this.More_Info_BTN.Click += new System.EventHandler(this.More_Info_BTN_Click);
            // 
            // Create_Vehicle_BTN
            // 
            this.Create_Vehicle_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Create_Vehicle_BTN.ForeColor = System.Drawing.Color.White;
            this.Create_Vehicle_BTN.Location = new System.Drawing.Point(25, 521);
            this.Create_Vehicle_BTN.Name = "Create_Vehicle_BTN";
            this.Create_Vehicle_BTN.Size = new System.Drawing.Size(149, 38);
            this.Create_Vehicle_BTN.TabIndex = 47;
            this.Create_Vehicle_BTN.Text = "Create A Vehicle";
            this.Create_Vehicle_BTN.UseVisualStyleBackColor = false;
            this.Create_Vehicle_BTN.Click += new System.EventHandler(this.Create_Vehicle_BTN_Click);
            // 
            // Car_Radio_Button
            // 
            this.Car_Radio_Button.AutoSize = true;
            this.Car_Radio_Button.Font = new System.Drawing.Font("Museo Sans For Dell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car_Radio_Button.Location = new System.Drawing.Point(382, 181);
            this.Car_Radio_Button.Name = "Car_Radio_Button";
            this.Car_Radio_Button.Size = new System.Drawing.Size(51, 23);
            this.Car_Radio_Button.TabIndex = 44;
            this.Car_Radio_Button.TabStop = true;
            this.Car_Radio_Button.Text = "Car";
            this.Car_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // Truck_Radio_BTN
            // 
            this.Truck_Radio_BTN.AutoSize = true;
            this.Truck_Radio_BTN.Font = new System.Drawing.Font("Museo Sans For Dell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Truck_Radio_BTN.Location = new System.Drawing.Point(382, 255);
            this.Truck_Radio_BTN.Name = "Truck_Radio_BTN";
            this.Truck_Radio_BTN.Size = new System.Drawing.Size(64, 23);
            this.Truck_Radio_BTN.TabIndex = 43;
            this.Truck_Radio_BTN.TabStop = true;
            this.Truck_Radio_BTN.Text = "Truck";
            this.Truck_Radio_BTN.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.label8.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(385, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Vehicle Type";
            // 
            // Make_SZ_M_TexTBox
            // 
            this.Make_SZ_M_TexTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Make_SZ_M_TexTBox.ForeColor = System.Drawing.Color.White;
            this.Make_SZ_M_TexTBox.Location = new System.Drawing.Point(162, 188);
            this.Make_SZ_M_TexTBox.Name = "Make_SZ_M_TexTBox";
            this.Make_SZ_M_TexTBox.Size = new System.Drawing.Size(156, 20);
            this.Make_SZ_M_TexTBox.TabIndex = 41;
            // 
            // Model_SZ_M_TexTBox
            // 
            this.Model_SZ_M_TexTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Model_SZ_M_TexTBox.ForeColor = System.Drawing.Color.White;
            this.Model_SZ_M_TexTBox.Location = new System.Drawing.Point(162, 245);
            this.Model_SZ_M_TexTBox.Name = "Model_SZ_M_TexTBox";
            this.Model_SZ_M_TexTBox.Size = new System.Drawing.Size(156, 20);
            this.Model_SZ_M_TexTBox.TabIndex = 40;
            // 
            // Date_Purchased_M_TexTBox
            // 
            this.Date_Purchased_M_TexTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Date_Purchased_M_TexTBox.ForeColor = System.Drawing.Color.White;
            this.Date_Purchased_M_TexTBox.Location = new System.Drawing.Point(162, 473);
            this.Date_Purchased_M_TexTBox.Name = "Date_Purchased_M_TexTBox";
            this.Date_Purchased_M_TexTBox.Size = new System.Drawing.Size(156, 20);
            this.Date_Purchased_M_TexTBox.TabIndex = 39;
            // 
            // Mileage_SZ_M_TexTBox
            // 
            this.Mileage_SZ_M_TexTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Mileage_SZ_M_TexTBox.ForeColor = System.Drawing.Color.White;
            this.Mileage_SZ_M_TexTBox.Location = new System.Drawing.Point(162, 416);
            this.Mileage_SZ_M_TexTBox.Name = "Mileage_SZ_M_TexTBox";
            this.Mileage_SZ_M_TexTBox.Size = new System.Drawing.Size(156, 20);
            this.Mileage_SZ_M_TexTBox.TabIndex = 38;
            // 
            // Invoice_SZ_Price_M_TexTBox
            // 
            this.Invoice_SZ_Price_M_TexTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Invoice_SZ_Price_M_TexTBox.ForeColor = System.Drawing.Color.White;
            this.Invoice_SZ_Price_M_TexTBox.Location = new System.Drawing.Point(162, 359);
            this.Invoice_SZ_Price_M_TexTBox.Name = "Invoice_SZ_Price_M_TexTBox";
            this.Invoice_SZ_Price_M_TexTBox.Size = new System.Drawing.Size(156, 20);
            this.Invoice_SZ_Price_M_TexTBox.TabIndex = 37;
            // 
            // Vehicle_Year_SZ_M_TexTBox
            // 
            this.Vehicle_Year_SZ_M_TexTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Vehicle_Year_SZ_M_TexTBox.ForeColor = System.Drawing.Color.White;
            this.Vehicle_Year_SZ_M_TexTBox.Location = new System.Drawing.Point(162, 302);
            this.Vehicle_Year_SZ_M_TexTBox.Name = "Vehicle_Year_SZ_M_TexTBox";
            this.Vehicle_Year_SZ_M_TexTBox.Size = new System.Drawing.Size(156, 20);
            this.Vehicle_Year_SZ_M_TexTBox.TabIndex = 36;
            // 
            // WinNum_M_TexTBox
            // 
            this.WinNum_M_TexTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.WinNum_M_TexTBox.ForeColor = System.Drawing.Color.White;
            this.WinNum_M_TexTBox.Location = new System.Drawing.Point(162, 131);
            this.WinNum_M_TexTBox.Name = "WinNum_M_TexTBox";
            this.WinNum_M_TexTBox.Size = new System.Drawing.Size(156, 20);
            this.WinNum_M_TexTBox.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Date Purchased:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Mileage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Invoice Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Vehicle Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Make:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "VIN Number:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vehicle_Inventory_Zafar.Properties.Resources.pinterest_board_photo1;
            this.pictureBox3.Location = new System.Drawing.Point(108, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(301, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vehicle_Inventory_Zafar.Properties.Resources.Hd7Ye6;
            this.pictureBox2.Location = new System.Drawing.Point(444, 244);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vehicle_Inventory_Zafar.Properties.Resources._325535;
            this.pictureBox1.Location = new System.Drawing.Point(444, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(633, 585);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Time_Label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.More_Info_BTN);
            this.Controls.Add(this.Create_Vehicle_BTN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Car_Radio_Button);
            this.Controls.Add(this.Truck_Radio_BTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Make_SZ_M_TexTBox);
            this.Controls.Add(this.Model_SZ_M_TexTBox);
            this.Controls.Add(this.Date_Purchased_M_TexTBox);
            this.Controls.Add(this.Mileage_SZ_M_TexTBox);
            this.Controls.Add(this.Invoice_SZ_Price_M_TexTBox);
            this.Controls.Add(this.Vehicle_Year_SZ_M_TexTBox);
            this.Controls.Add(this.WinNum_M_TexTBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.Button More_Info_BTN;
        private System.Windows.Forms.Button Create_Vehicle_BTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Car_Radio_Button;
        private System.Windows.Forms.RadioButton Truck_Radio_BTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Make_SZ_M_TexTBox;
        private System.Windows.Forms.TextBox Model_SZ_M_TexTBox;
        private System.Windows.Forms.TextBox Date_Purchased_M_TexTBox;
        private System.Windows.Forms.TextBox Mileage_SZ_M_TexTBox;
        private System.Windows.Forms.TextBox Invoice_SZ_Price_M_TexTBox;
        private System.Windows.Forms.TextBox Vehicle_Year_SZ_M_TexTBox;
        private System.Windows.Forms.TextBox WinNum_M_TexTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}