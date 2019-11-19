namespace Vehicle_Inventory_Zafar
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.Login_BTN = new System.Windows.Forms.Button();
            this.Pwd_TextBox = new System.Windows.Forms.TextBox();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Museo Sans For Dell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.Location = new System.Drawing.Point(48, 389);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(42, 19);
            this.Date_Label.TabIndex = 20;
            this.Date_Label.Text = "Date";
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("Museo Sans For Dell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.Location = new System.Drawing.Point(91, 362);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(44, 19);
            this.Time_Label.TabIndex = 19;
            this.Time_Label.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vehicle_Inventory_Zafar.Properties.Resources.pinterest_board_photo1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Exit_BTN.ForeColor = System.Drawing.Color.Transparent;
            this.Exit_BTN.Location = new System.Drawing.Point(142, 295);
            this.Exit_BTN.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(63, 41);
            this.Exit_BTN.TabIndex = 17;
            this.Exit_BTN.Text = "Exit";
            this.Exit_BTN.UseVisualStyleBackColor = false;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click_1);
            // 
            // Login_BTN
            // 
            this.Login_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Login_BTN.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Login_BTN.Location = new System.Drawing.Point(43, 295);
            this.Login_BTN.Margin = new System.Windows.Forms.Padding(2);
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Size = new System.Drawing.Size(63, 41);
            this.Login_BTN.TabIndex = 16;
            this.Login_BTN.Text = "Login";
            this.Login_BTN.UseVisualStyleBackColor = false;
            this.Login_BTN.Click += new System.EventHandler(this.Login_BTN_Click_1);
            // 
            // Pwd_TextBox
            // 
            this.Pwd_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Pwd_TextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Pwd_TextBox.Location = new System.Drawing.Point(43, 259);
            this.Pwd_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Pwd_TextBox.Name = "Pwd_TextBox";
            this.Pwd_TextBox.PasswordChar = '*';
            this.Pwd_TextBox.Size = new System.Drawing.Size(162, 20);
            this.Pwd_TextBox.TabIndex = 15;
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
            this.Email_TextBox.ForeColor = System.Drawing.Color.White;
            this.Email_TextBox.Location = new System.Drawing.Point(43, 187);
            this.Email_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(162, 20);
            this.Email_TextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Museo Sans For Dell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter Your Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Museo Sans For Dell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Your Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Museo Sans For Dell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Please Log In";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(298, 442);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Time_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit_BTN);
            this.Controls.Add(this.Login_BTN);
            this.Controls.Add(this.Pwd_TextBox);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login_Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.Button Login_BTN;
        private System.Windows.Forms.TextBox Pwd_TextBox;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

