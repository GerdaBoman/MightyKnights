namespace UI
{
    partial class FormSettings
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
            this.edit_btn = new System.Windows.Forms.Button();
            this.carPrice_lbl = new System.Windows.Forms.Label();
            this.mcPrice_lbl = new System.Windows.Forms.Label();
            this.garageSize_lbl = new System.Windows.Forms.Label();
            this.cPrice_txt = new System.Windows.Forms.TextBox();
            this.mcPrice_txt = new System.Windows.Forms.TextBox();
            this.gSize_txt = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // edit_btn
            // 
            this.edit_btn.AutoSize = true;
            this.edit_btn.Location = new System.Drawing.Point(488, 409);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(97, 54);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // carPrice_lbl
            // 
            this.carPrice_lbl.AutoSize = true;
            this.carPrice_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carPrice_lbl.Location = new System.Drawing.Point(490, 154);
            this.carPrice_lbl.Name = "carPrice_lbl";
            this.carPrice_lbl.Size = new System.Drawing.Size(96, 28);
            this.carPrice_lbl.TabIndex = 5;
            this.carPrice_lbl.Text = "Car Price";
            // 
            // mcPrice_lbl
            // 
            this.mcPrice_lbl.AutoSize = true;
            this.mcPrice_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mcPrice_lbl.Location = new System.Drawing.Point(492, 237);
            this.mcPrice_lbl.Name = "mcPrice_lbl";
            this.mcPrice_lbl.Size = new System.Drawing.Size(94, 28);
            this.mcPrice_lbl.TabIndex = 6;
            this.mcPrice_lbl.Text = "Mc Price";
            // 
            // garageSize_lbl
            // 
            this.garageSize_lbl.AutoSize = true;
            this.garageSize_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.garageSize_lbl.Location = new System.Drawing.Point(488, 314);
            this.garageSize_lbl.Name = "garageSize_lbl";
            this.garageSize_lbl.Size = new System.Drawing.Size(123, 28);
            this.garageSize_lbl.TabIndex = 7;
            this.garageSize_lbl.Text = "Garage Size";
            // 
            // cPrice_txt
            // 
            this.cPrice_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cPrice_txt.Location = new System.Drawing.Point(633, 165);
            this.cPrice_txt.Name = "cPrice_txt";
            this.cPrice_txt.ReadOnly = true;
            this.cPrice_txt.Size = new System.Drawing.Size(97, 16);
            this.cPrice_txt.TabIndex = 8;
            this.cPrice_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cPrice_txt.ReadOnlyChanged += new System.EventHandler(this.edit_btn_Click);
            // 
            // mcPrice_txt
            // 
            this.mcPrice_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcPrice_txt.Location = new System.Drawing.Point(633, 243);
            this.mcPrice_txt.Name = "mcPrice_txt";
            this.mcPrice_txt.ReadOnly = true;
            this.mcPrice_txt.Size = new System.Drawing.Size(97, 16);
            this.mcPrice_txt.TabIndex = 9;
            this.mcPrice_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gSize_txt
            // 
            this.gSize_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gSize_txt.Location = new System.Drawing.Point(633, 325);
            this.gSize_txt.Name = "gSize_txt";
            this.gSize_txt.ReadOnly = true;
            this.gSize_txt.Size = new System.Drawing.Size(97, 16);
            this.gSize_txt.TabIndex = 10;
            this.gSize_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Savebtn
            // 
            this.Savebtn.AutoSize = true;
            this.Savebtn.Location = new System.Drawing.Point(633, 409);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(97, 54);
            this.Savebtn.TabIndex = 11;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(181, 62);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(195, 102);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "To edit configurations: \r\n1.Press Edit\r\n2.Change prices\r\n3.Press Save\r\n";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 102;
            this.iconPictureBox1.Location = new System.Drawing.Point(73, 62);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(102, 102);
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 102;
            this.iconPictureBox2.Location = new System.Drawing.Point(646, 544);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(102, 102);
            this.iconPictureBox2.TabIndex = 14;
            this.iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(754, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 127);
            this.label1.TabIndex = 15;
            this.label1.Text = "Things to think about:\r\n- If you are decreasing parking lot capacity:            " +
    "          \r\n Make sure no vehicles are parked in those spaces that will be remov" +
    "ed\r\nto make sure no loss of data!\r\n ";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1534, 1036);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.gSize_txt);
            this.Controls.Add(this.mcPrice_txt);
            this.Controls.Add(this.cPrice_txt);
            this.Controls.Add(this.garageSize_lbl);
            this.Controls.Add(this.mcPrice_lbl);
            this.Controls.Add(this.carPrice_lbl);
            this.Controls.Add(this.edit_btn);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button edit_btn;
        private Label carPrice_lbl;
        private Label mcPrice_lbl;
        private Label garageSize_lbl;
        private TextBox cPrice_txt;
        private TextBox mcPrice_txt;
        private TextBox gSize_txt;
        private Button Savebtn;
        private Label infoLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label1;
    }
}