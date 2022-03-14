namespace UI
{
    partial class FormParkingLot
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ParkingSpots = new System.Windows.Forms.ColumnHeader();
            this.licancePlate = new System.Windows.Forms.ColumnHeader();
            this.checkInDate = new System.Windows.Forms.ColumnHeader();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.ParkLabel = new System.Windows.Forms.Label();
            this.parkingSpotBox = new System.Windows.Forms.TextBox();
            this.parkingSpotHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.regPlateTextBox = new System.Windows.Forms.TextBox();
            this.registrationPlate = new System.Windows.Forms.Label();
            this.parkingLotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleCombo = new System.Windows.Forms.ComboBox();
            this.vehicleTypeLabel = new System.Windows.Forms.Label();
            this.checkInLabel = new System.Windows.Forms.Label();
            this.checkOutLabel = new System.Windows.Forms.Label();
            this.checkoutInstructions = new System.Windows.Forms.Label();
            this.checkoutSpotBox = new System.Windows.Forms.TextBox();
            this.regNumberLabel2 = new System.Windows.Forms.Label();
            this.checkOutTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.ParkedVehiclesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parkingLotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParkingSpots,
            this.licancePlate,
            this.checkInDate});
            this.listView1.Location = new System.Drawing.Point(916, 333);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(359, 167);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ParkingSpots
            // 
            this.ParkingSpots.Text = "Parking Spot";
            this.ParkingSpots.Width = 100;
            // 
            // licancePlate
            // 
            this.licancePlate.Text = "Licence Plate";
            this.licancePlate.Width = 100;
            // 
            // checkInDate
            // 
            this.checkInDate.Text = "Check In Date";
            this.checkInDate.Width = 150;
            // 
            // CheckInButton
            // 
            this.CheckInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckInButton.Location = new System.Drawing.Point(1057, 253);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(75, 23);
            this.CheckInButton.TabIndex = 13;
            this.CheckInButton.Text = "Check In";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // ParkLabel
            // 
            this.ParkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParkLabel.AutoSize = true;
            this.ParkLabel.Location = new System.Drawing.Point(916, 187);
            this.ParkLabel.Name = "ParkLabel";
            this.ParkLabel.Size = new System.Drawing.Size(176, 30);
            this.ParkLabel.TabIndex = 12;
            this.ParkLabel.Text = "Enter a number of the \r\nparking spot to park the vehicle:\r\n";
            // 
            // parkingSpotBox
            // 
            this.parkingSpotBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.parkingSpotBox.Location = new System.Drawing.Point(1119, 187);
            this.parkingSpotBox.Name = "parkingSpotBox";
            this.parkingSpotBox.Size = new System.Drawing.Size(134, 23);
            this.parkingSpotBox.TabIndex = 11;
            // 
            // parkingSpotHolder
            // 
            this.parkingSpotHolder.AutoSize = true;
            this.parkingSpotHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.parkingSpotHolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.parkingSpotHolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parkingSpotHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingSpotHolder.Location = new System.Drawing.Point(0, 0);
            this.parkingSpotHolder.MaximumSize = new System.Drawing.Size(800, 820);
            this.parkingSpotHolder.Name = "parkingSpotHolder";
            this.parkingSpotHolder.Size = new System.Drawing.Size(800, 4);
            this.parkingSpotHolder.TabIndex = 10;
            // 
            // regPlateTextBox
            // 
            this.regPlateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regPlateTextBox.Location = new System.Drawing.Point(1119, 81);
            this.regPlateTextBox.Name = "regPlateTextBox";
            this.regPlateTextBox.Size = new System.Drawing.Size(134, 23);
            this.regPlateTextBox.TabIndex = 17;
            // 
            // registrationPlate
            // 
            this.registrationPlate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationPlate.AutoSize = true;
            this.registrationPlate.Location = new System.Drawing.Point(916, 84);
            this.registrationPlate.Name = "registrationPlate";
            this.registrationPlate.Size = new System.Drawing.Size(120, 15);
            this.registrationPlate.TabIndex = 16;
            this.registrationPlate.Text = "Registration Number:";
            // 
            // parkingLotBindingSource
            // 
            this.parkingLotBindingSource.DataSource = typeof(DataAccess.Models.ParkingLot);
            // 
            // vehicleCombo
            // 
            this.vehicleCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleCombo.FormattingEnabled = true;
            this.vehicleCombo.Items.AddRange(new object[] {
            "Car",
            "Motercycle"});
            this.vehicleCombo.Location = new System.Drawing.Point(1119, 136);
            this.vehicleCombo.Name = "vehicleCombo";
            this.vehicleCombo.Size = new System.Drawing.Size(134, 23);
            this.vehicleCombo.TabIndex = 15;
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleTypeLabel.AutoSize = true;
            this.vehicleTypeLabel.Location = new System.Drawing.Point(916, 139);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(74, 15);
            this.vehicleTypeLabel.TabIndex = 14;
            this.vehicleTypeLabel.Text = "Vehicle Type:";
            // 
            // checkInLabel
            // 
            this.checkInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkInLabel.AutoSize = true;
            this.checkInLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkInLabel.Location = new System.Drawing.Point(916, 36);
            this.checkInLabel.Name = "checkInLabel";
            this.checkInLabel.Size = new System.Drawing.Size(88, 25);
            this.checkInLabel.TabIndex = 19;
            this.checkInLabel.Text = "Check In:";
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkOutLabel.AutoSize = true;
            this.checkOutLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkOutLabel.Location = new System.Drawing.Point(919, 550);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(103, 25);
            this.checkOutLabel.TabIndex = 20;
            this.checkOutLabel.Text = "Check Out:";
            // 
            // checkoutInstructions
            // 
            this.checkoutInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkoutInstructions.AutoSize = true;
            this.checkoutInstructions.Location = new System.Drawing.Point(919, 602);
            this.checkoutInstructions.Name = "checkoutInstructions";
            this.checkoutInstructions.Size = new System.Drawing.Size(119, 15);
            this.checkoutInstructions.TabIndex = 21;
            this.checkoutInstructions.Text = "Choose parking spot:";
            // 
            // checkoutSpotBox
            // 
            this.checkoutSpotBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkoutSpotBox.Location = new System.Drawing.Point(1122, 594);
            this.checkoutSpotBox.Name = "checkoutSpotBox";
            this.checkoutSpotBox.Size = new System.Drawing.Size(134, 23);
            this.checkoutSpotBox.TabIndex = 22;
            // 
            // regNumberLabel2
            // 
            this.regNumberLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regNumberLabel2.AutoSize = true;
            this.regNumberLabel2.Location = new System.Drawing.Point(916, 658);
            this.regNumberLabel2.Name = "regNumberLabel2";
            this.regNumberLabel2.Size = new System.Drawing.Size(120, 15);
            this.regNumberLabel2.TabIndex = 23;
            this.regNumberLabel2.Text = "Registration Number:";
            // 
            // checkOutTextBox
            // 
            this.checkOutTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkOutTextBox.Location = new System.Drawing.Point(1122, 655);
            this.checkOutTextBox.Name = "checkOutTextBox";
            this.checkOutTextBox.Size = new System.Drawing.Size(134, 23);
            this.checkOutTextBox.TabIndex = 24;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(1068, 624);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(27, 15);
            this.infoLabel.TabIndex = 25;
            this.infoLabel.Text = "and";
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckOutButton.Location = new System.Drawing.Point(1057, 691);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckOutButton.TabIndex = 26;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // ParkedVehiclesLabel
            // 
            this.ParkedVehiclesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParkedVehiclesLabel.AutoSize = true;
            this.ParkedVehiclesLabel.Location = new System.Drawing.Point(919, 315);
            this.ParkedVehiclesLabel.Name = "ParkedVehiclesLabel";
            this.ParkedVehiclesLabel.Size = new System.Drawing.Size(91, 15);
            this.ParkedVehiclesLabel.TabIndex = 27;
            this.ParkedVehiclesLabel.Text = "Parked Vehicles:";
            // 
            // FormParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1300, 781);
            this.Controls.Add(this.ParkedVehiclesLabel);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.checkOutTextBox);
            this.Controls.Add(this.regNumberLabel2);
            this.Controls.Add(this.checkoutSpotBox);
            this.Controls.Add(this.checkoutInstructions);
            this.Controls.Add(this.checkOutLabel);
            this.Controls.Add(this.checkInLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.ParkLabel);
            this.Controls.Add(this.parkingSpotBox);
            this.Controls.Add(this.parkingSpotHolder);
            this.Controls.Add(this.regPlateTextBox);
            this.Controls.Add(this.registrationPlate);
            this.Controls.Add(this.vehicleCombo);
            this.Controls.Add(this.vehicleTypeLabel);
            this.Name = "FormParkingLot";
            this.Text = "Parking Lot";
            this.Load += new System.EventHandler(this.FormParkingLot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingLotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView listView1;
        private ColumnHeader ParkingSpots;
        private ColumnHeader licancePlate;
        private ColumnHeader checkInDate;
        private Button CheckInButton;
        private Label ParkLabel;
        private TextBox parkingSpotBox;
        private FlowLayoutPanel parkingSpotHolder;
        private TextBox regPlateTextBox;
        private Label registrationPlate;
        private BindingSource parkingLotBindingSource;
        private ComboBox vehicleCombo;
        private Label vehicleTypeLabel;
        private Label checkInLabel;
        private Label checkOutLabel;
        private Label checkoutInstructions;
        private TextBox checkoutSpotBox;
        private Label regNumberLabel2;
        private TextBox checkOutTextBox;
        private Label infoLabel;
        private Button CheckOutButton;
        private Label ParkedVehiclesLabel;
    }
}