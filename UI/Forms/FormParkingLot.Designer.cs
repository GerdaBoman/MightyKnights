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
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.ParkedVehiclesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parkingLotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParkingSpots,
            this.licancePlate,
            this.checkInDate});
            this.listView1.Location = new System.Drawing.Point(850, 325);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 167);
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
            this.CheckInButton.Location = new System.Drawing.Point(1186, 188);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(75, 23);
            this.CheckInButton.TabIndex = 13;
            this.CheckInButton.Text = "Check In";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // ParkLabel
            // 
            this.ParkLabel.AutoSize = true;
            this.ParkLabel.Location = new System.Drawing.Point(850, 182);
            this.ParkLabel.Name = "ParkLabel";
            this.ParkLabel.Size = new System.Drawing.Size(176, 30);
            this.ParkLabel.TabIndex = 12;
            this.ParkLabel.Text = "Enter a number of the \r\nparking spot to park the vehicle:\r\n";
            // 
            // parkingSpotBox
            // 
            this.parkingSpotBox.Location = new System.Drawing.Point(1032, 189);
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
            this.parkingSpotHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parkingSpotHolder.Location = new System.Drawing.Point(0, 0);
            this.parkingSpotHolder.MaximumSize = new System.Drawing.Size(800, 820);
            this.parkingSpotHolder.Name = "parkingSpotHolder";
            this.parkingSpotHolder.Size = new System.Drawing.Size(800, 781);
            this.parkingSpotHolder.TabIndex = 10;
            // 
            // regPlateTextBox
            // 
            this.regPlateTextBox.Location = new System.Drawing.Point(1032, 84);
            this.regPlateTextBox.Name = "regPlateTextBox";
            this.regPlateTextBox.Size = new System.Drawing.Size(134, 23);
            this.regPlateTextBox.TabIndex = 17;
            // 
            // registrationPlate
            // 
            this.registrationPlate.AutoSize = true;
            this.registrationPlate.Location = new System.Drawing.Point(850, 84);
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
            this.vehicleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleCombo.FormattingEnabled = true;
            this.vehicleCombo.Items.AddRange(new object[] {
            "Car",
            "Motercycle"});
            this.vehicleCombo.Location = new System.Drawing.Point(1032, 134);
            this.vehicleCombo.Name = "vehicleCombo";
            this.vehicleCombo.Size = new System.Drawing.Size(134, 23);
            this.vehicleCombo.TabIndex = 15;
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.AutoSize = true;
            this.vehicleTypeLabel.Location = new System.Drawing.Point(850, 134);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(74, 15);
            this.vehicleTypeLabel.TabIndex = 14;
            this.vehicleTypeLabel.Text = "Vehicle Type:";
            // 
            // checkInLabel
            // 
            this.checkInLabel.AutoSize = true;
            this.checkInLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkInLabel.Location = new System.Drawing.Point(850, 51);
            this.checkInLabel.Name = "checkInLabel";
            this.checkInLabel.Size = new System.Drawing.Size(93, 25);
            this.checkInLabel.TabIndex = 19;
            this.checkInLabel.Text = "Check In:";
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.AutoSize = true;
            this.checkOutLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkOutLabel.Location = new System.Drawing.Point(850, 519);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(108, 25);
            this.checkOutLabel.TabIndex = 20;
            this.checkOutLabel.Text = "Check Out:";
            // 
            // checkoutInstructions
            // 
            this.checkoutInstructions.AutoSize = true;
            this.checkoutInstructions.Location = new System.Drawing.Point(850, 632);
            this.checkoutInstructions.Name = "checkoutInstructions";
            this.checkoutInstructions.Size = new System.Drawing.Size(74, 15);
            this.checkoutInstructions.TabIndex = 21;
            this.checkoutInstructions.Text = "Parking Spot";
            // 
            // checkoutSpotBox
            // 
            this.checkoutSpotBox.Enabled = false;
            this.checkoutSpotBox.Location = new System.Drawing.Point(1032, 624);
            this.checkoutSpotBox.Name = "checkoutSpotBox";
            this.checkoutSpotBox.ReadOnly = true;
            this.checkoutSpotBox.Size = new System.Drawing.Size(134, 23);
            this.checkoutSpotBox.TabIndex = 22;
            // 
            // regNumberLabel2
            // 
            this.regNumberLabel2.AutoSize = true;
            this.regNumberLabel2.Location = new System.Drawing.Point(850, 593);
            this.regNumberLabel2.Name = "regNumberLabel2";
            this.regNumberLabel2.Size = new System.Drawing.Size(79, 15);
            this.regNumberLabel2.TabIndex = 23;
            this.regNumberLabel2.Text = "Licence Plate:";
            // 
            // checkOutTextBox
            // 
            this.checkOutTextBox.Location = new System.Drawing.Point(1032, 585);
            this.checkOutTextBox.Name = "checkOutTextBox";
            this.checkOutTextBox.Size = new System.Drawing.Size(134, 23);
            this.checkOutTextBox.TabIndex = 24;
            this.checkOutTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkOutTextBox_KeyDown);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(1199, 628);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckOutButton.TabIndex = 26;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // ParkedVehiclesLabel
            // 
            this.ParkedVehiclesLabel.AutoSize = true;
            this.ParkedVehiclesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ParkedVehiclesLabel.Location = new System.Drawing.Point(850, 284);
            this.ParkedVehiclesLabel.Name = "ParkedVehiclesLabel";
            this.ParkedVehiclesLabel.Size = new System.Drawing.Size(97, 15);
            this.ParkedVehiclesLabel.TabIndex = 27;
            this.ParkedVehiclesLabel.Text = "Parked Vehicles:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(850, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Licence Plate number:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1199, 585);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FormParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 781);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParkedVehiclesLabel);
            this.Controls.Add(this.CheckOutButton);
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
        private Button CheckOutButton;
        private Label ParkedVehiclesLabel;
        private Label label1;
        private Button searchButton;
    }
}