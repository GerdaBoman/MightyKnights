namespace UI
{
    partial class Form
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
            this.settingButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.vehicleManagementButton = new FontAwesome.Sharp.IconButton();
            this.parkingLotButton = new FontAwesome.Sharp.IconButton();
            this.HomeButton = new FontAwesome.Sharp.IconButton();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.currentChildFormLabel = new System.Windows.Forms.Label();
            this.currentChildButton = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.MenuPanel.Controls.Add(this.settingButton);
            this.MenuPanel.Controls.Add(this.exitButton);
            this.MenuPanel.Controls.Add(this.vehicleManagementButton);
            this.MenuPanel.Controls.Add(this.parkingLotButton);
            this.MenuPanel.Controls.Add(this.HomeButton);
            this.MenuPanel.Controls.Add(this.logoPicture);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 585);
            this.MenuPanel.TabIndex = 0;
            // 
            // settingButton
            // 
            this.settingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingButton.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.settingButton.IconColor = System.Drawing.Color.Gainsboro;
            this.settingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButton.Location = new System.Drawing.Point(0, 465);
            this.settingButton.Name = "settingButton";
            this.settingButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.settingButton.Size = new System.Drawing.Size(200, 60);
            this.settingButton.TabIndex = 6;
            this.settingButton.Text = "Settings";
            this.settingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitButton.IconColor = System.Drawing.Color.Gainsboro;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 525);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.exitButton.Size = new System.Drawing.Size(200, 60);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // vehicleManagementButton
            // 
            this.vehicleManagementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehicleManagementButton.FlatAppearance.BorderSize = 0;
            this.vehicleManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleManagementButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleManagementButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.vehicleManagementButton.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.vehicleManagementButton.IconColor = System.Drawing.Color.Gainsboro;
            this.vehicleManagementButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vehicleManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleManagementButton.Location = new System.Drawing.Point(0, 227);
            this.vehicleManagementButton.Name = "vehicleManagementButton";
            this.vehicleManagementButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.vehicleManagementButton.Size = new System.Drawing.Size(200, 60);
            this.vehicleManagementButton.TabIndex = 3;
            this.vehicleManagementButton.Text = "Vehicle Managment";
            this.vehicleManagementButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleManagementButton.UseVisualStyleBackColor = true;
            this.vehicleManagementButton.Click += new System.EventHandler(this.vehicleManagementButton_Click);
            // 
            // parkingLotButton
            // 
            this.parkingLotButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingLotButton.FlatAppearance.BorderSize = 0;
            this.parkingLotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingLotButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parkingLotButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.parkingLotButton.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.parkingLotButton.IconColor = System.Drawing.Color.Gainsboro;
            this.parkingLotButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.parkingLotButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkingLotButton.Location = new System.Drawing.Point(0, 167);
            this.parkingLotButton.Name = "parkingLotButton";
            this.parkingLotButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.parkingLotButton.Size = new System.Drawing.Size(200, 60);
            this.parkingLotButton.TabIndex = 2;
            this.parkingLotButton.Text = "Parking Lot";
            this.parkingLotButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkingLotButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.parkingLotButton.UseVisualStyleBackColor = true;
            this.parkingLotButton.Click += new System.EventHandler(this.parkingLotButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeButton.IconColor = System.Drawing.Color.Gainsboro;
            this.HomeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 107);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.HomeButton.Size = new System.Drawing.Size(200, 60);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPicture.Image = global::UI.Properties.Resources.knight_logo_clip_art_knight_c744684370c393f827995e46e5a11427;
            this.logoPicture.Location = new System.Drawing.Point(0, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(200, 107);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.panelHeader.Controls.Add(this.currentChildFormLabel);
            this.panelHeader.Controls.Add(this.currentChildButton);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1074, 71);
            this.panelHeader.TabIndex = 2;
            // 
            // currentChildFormLabel
            // 
            this.currentChildFormLabel.AutoSize = true;
            this.currentChildFormLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentChildFormLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.currentChildFormLabel.Location = new System.Drawing.Point(90, 32);
            this.currentChildFormLabel.Name = "currentChildFormLabel";
            this.currentChildFormLabel.Size = new System.Drawing.Size(66, 25);
            this.currentChildFormLabel.TabIndex = 1;
            this.currentChildFormLabel.Text = "Home";
            // 
            // currentChildButton
            // 
            this.currentChildButton.FlatAppearance.BorderSize = 0;
            this.currentChildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentChildButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentChildButton.IconColor = System.Drawing.Color.Gainsboro;
            this.currentChildButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildButton.Location = new System.Drawing.Point(20, 12);
            this.currentChildButton.Name = "currentChildButton";
            this.currentChildButton.Size = new System.Drawing.Size(64, 70);
            this.currentChildButton.TabIndex = 0;
            this.currentChildButton.UseVisualStyleBackColor = true;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(111)))), ((int)(((byte)(164)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(200, 71);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1074, 10);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 81);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1074, 504);
            this.panelDesktop.TabIndex = 4;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 585);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.MenuPanel);
            this.Name = "Form";
            this.Text = "Form1";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private FontAwesome.Sharp.IconButton settingButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton vehicleManagementButton;
        private FontAwesome.Sharp.IconButton parkingLotButton;
        private FontAwesome.Sharp.IconButton HomeButton;
        private PictureBox logoPicture;
        private Panel panelHeader;
        private Label currentChildFormLabel;
        private FontAwesome.Sharp.IconButton currentChildButton;
        private Panel panelShadow;
        private Panel panelDesktop;
    }
}