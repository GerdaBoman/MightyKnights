namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.VehicleManagementButton = new FontAwesome.Sharp.IconButton();
            this.ParkingLotButton = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.currentChildButton = new FontAwesome.Sharp.IconButton();
            this.currentChildFormLabel = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.MenuPanel.Controls.Add(this.SettingsButton);
            this.MenuPanel.Controls.Add(this.ExitButton);
            this.MenuPanel.Controls.Add(this.VehicleManagementButton);
            this.MenuPanel.Controls.Add(this.ParkingLotButton);
            this.MenuPanel.Controls.Add(this.HomeButton);
            this.MenuPanel.Controls.Add(this.LogoPicture);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 777);
            this.MenuPanel.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.CausesValidation = false;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsButton.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.SettingsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.SettingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 637);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingsButton.Size = new System.Drawing.Size(200, 70);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ExitButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(0, 707);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ExitButton.Size = new System.Drawing.Size(200, 70);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // VehicleManagementButton
            // 
            this.VehicleManagementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.VehicleManagementButton.FlatAppearance.BorderSize = 0;
            this.VehicleManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VehicleManagementButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehicleManagementButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.VehicleManagementButton.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.VehicleManagementButton.IconColor = System.Drawing.Color.Gainsboro;
            this.VehicleManagementButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VehicleManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VehicleManagementButton.Location = new System.Drawing.Point(0, 250);
            this.VehicleManagementButton.Name = "VehicleManagementButton";
            this.VehicleManagementButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.VehicleManagementButton.Size = new System.Drawing.Size(200, 70);
            this.VehicleManagementButton.TabIndex = 3;
            this.VehicleManagementButton.Text = "Vehicle Management";
            this.VehicleManagementButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VehicleManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VehicleManagementButton.UseVisualStyleBackColor = true;
            this.VehicleManagementButton.Click += new System.EventHandler(this.VehicleManagementButton_Click);
            // 
            // ParkingLotButton
            // 
            this.ParkingLotButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ParkingLotButton.FlatAppearance.BorderSize = 0;
            this.ParkingLotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParkingLotButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParkingLotButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ParkingLotButton.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.ParkingLotButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ParkingLotButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ParkingLotButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParkingLotButton.Location = new System.Drawing.Point(0, 180);
            this.ParkingLotButton.Name = "ParkingLotButton";
            this.ParkingLotButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ParkingLotButton.Size = new System.Drawing.Size(200, 70);
            this.ParkingLotButton.TabIndex = 2;
            this.ParkingLotButton.Text = "Parking Lot";
            this.ParkingLotButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParkingLotButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ParkingLotButton.UseVisualStyleBackColor = true;
            this.ParkingLotButton.Click += new System.EventHandler(this.ParkingLotButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeButton.IconColor = System.Drawing.Color.Gainsboro;
            this.HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 110);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.HomeButton.Size = new System.Drawing.Size(200, 70);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPicture.Image = global::UI.Properties.Resources.knight_logo_clip_art_knight_c744684370c393f827995e46e5a11427;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.LogoPicture.Size = new System.Drawing.Size(200, 110);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.panelDashboard.Controls.Add(this.currentChildButton);
            this.panelDashboard.Controls.Add(this.currentChildFormLabel);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboard.Location = new System.Drawing.Point(200, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1142, 70);
            this.panelDashboard.TabIndex = 1;
            // 
            // currentChildButton
            // 
            this.currentChildButton.FlatAppearance.BorderSize = 0;
            this.currentChildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentChildButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentChildButton.IconColor = System.Drawing.Color.Gainsboro;
            this.currentChildButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildButton.Location = new System.Drawing.Point(17, 17);
            this.currentChildButton.Name = "currentChildButton";
            this.currentChildButton.Size = new System.Drawing.Size(58, 47);
            this.currentChildButton.TabIndex = 1;
            this.currentChildButton.UseVisualStyleBackColor = true;
            // 
            // currentChildFormLabel
            // 
            this.currentChildFormLabel.AutoSize = true;
            this.currentChildFormLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentChildFormLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.currentChildFormLabel.Location = new System.Drawing.Point(81, 25);
            this.currentChildFormLabel.Name = "currentChildFormLabel";
            this.currentChildFormLabel.Size = new System.Drawing.Size(66, 25);
            this.currentChildFormLabel.TabIndex = 0;
            this.currentChildFormLabel.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.panelDesktop.Controls.Add(this.panelShadow);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1142, 707);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(111)))), ((int)(((byte)(164)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 0);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1142, 10);
            this.panelShadow.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 777);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form1";
            this.Text = "Mighty Knights";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private PictureBox LogoPicture;
        private FontAwesome.Sharp.IconButton SettingsButton;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconButton VehicleManagementButton;
        private FontAwesome.Sharp.IconButton ParkingLotButton;
        private FontAwesome.Sharp.IconButton HomeButton;
        private Panel panelDashboard;
        private Panel panelDesktop;
        private Panel panelShadow;
        private Label currentChildFormLabel;
        private FontAwesome.Sharp.IconButton currentChildButton;
    }
}