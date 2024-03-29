﻿namespace UI
{
    partial class FormVehicleManagement
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.RegNummerTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsView = new System.Windows.Forms.ListView();
            this.RegNumber = new System.Windows.Forms.ColumnHeader();
            this.vehicleType = new System.Windows.Forms.ColumnHeader();
            this.ParkingSpot = new System.Windows.Forms.ColumnHeader();
            this.CheckInDate = new System.Windows.Forms.ColumnHeader();
            this.licensePlateLabel = new System.Windows.Forms.Label();
            this.parkingLotViewer = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.licencePlateLabel = new System.Windows.Forms.Label();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.ParkingSpotLabel = new System.Windows.Forms.Label();
            this.CheckInDateLabel = new System.Windows.Forms.Label();
            this.editRegNumber = new System.Windows.Forms.TextBox();
            this.editVehicleType = new System.Windows.Forms.TextBox();
            this.EditLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateLicencePlate = new System.Windows.Forms.Button();
            this.UpdateVehicleType = new System.Windows.Forms.Button();
            this.UpdateCheckInDate = new System.Windows.Forms.Button();
            this.editParkingSpot = new System.Windows.Forms.TextBox();
            this.moveVehicleLabel = new System.Windows.Forms.Label();
            this.MoveVehicleButton = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.newParkingSpot = new System.Windows.Forms.TextBox();
            this.NewVehicleType = new System.Windows.Forms.ComboBox();
            this.newLicencePlate = new System.Windows.Forms.TextBox();
            this.newLicancePlateLabel = new System.Windows.Forms.Label();
            this.NewVehicleTypeLabel = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.DateTimeInstrutions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(101, 68);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(86, 28);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search: ";
            // 
            // RegNummerTextBox
            // 
            this.RegNummerTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.RegNummerTextBox.Location = new System.Drawing.Point(271, 120);
            this.RegNummerTextBox.Name = "RegNummerTextBox";
            this.RegNummerTextBox.Size = new System.Drawing.Size(170, 23);
            this.RegNummerTextBox.TabIndex = 1;
            this.RegNummerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegNummerTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(461, 119);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultsView
            // 
            this.searchResultsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RegNumber,
            this.vehicleType,
            this.ParkingSpot,
            this.CheckInDate});
            this.searchResultsView.Location = new System.Drawing.Point(129, 181);
            this.searchResultsView.Name = "searchResultsView";
            this.searchResultsView.Size = new System.Drawing.Size(604, 107);
            this.searchResultsView.TabIndex = 3;
            this.searchResultsView.UseCompatibleStateImageBehavior = false;
            this.searchResultsView.View = System.Windows.Forms.View.Details;
            // 
            // RegNumber
            // 
            this.RegNumber.Text = "Licence Plate";
            this.RegNumber.Width = 100;
            // 
            // vehicleType
            // 
            this.vehicleType.Text = "Vehicle Type";
            this.vehicleType.Width = 100;
            // 
            // ParkingSpot
            // 
            this.ParkingSpot.Text = "Parking Spot";
            this.ParkingSpot.Width = 100;
            // 
            // CheckInDate
            // 
            this.CheckInDate.Text = "Check in Date";
            this.CheckInDate.Width = 300;
            // 
            // licensePlateLabel
            // 
            this.licensePlateLabel.AutoSize = true;
            this.licensePlateLabel.Location = new System.Drawing.Point(133, 125);
            this.licensePlateLabel.Name = "licensePlateLabel";
            this.licensePlateLabel.Size = new System.Drawing.Size(123, 15);
            this.licensePlateLabel.TabIndex = 4;
            this.licensePlateLabel.Text = "License Plate number:";
            // 
            // parkingLotViewer
            // 
            this.parkingLotViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.parkingLotViewer.Dock = System.Windows.Forms.DockStyle.Right;
            this.parkingLotViewer.Location = new System.Drawing.Point(836, 0);
            this.parkingLotViewer.Name = "parkingLotViewer";
            this.parkingLotViewer.Size = new System.Drawing.Size(506, 777);
            this.parkingLotViewer.TabIndex = 5;
            this.parkingLotViewer.UseCompatibleStateImageBehavior = false;
            this.parkingLotViewer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "License Plate";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vehicle Type";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Parking Spot";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Check in Date";
            this.columnHeader4.Width = 200;
            // 
            // licencePlateLabel
            // 
            this.licencePlateLabel.AutoSize = true;
            this.licencePlateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.licencePlateLabel.ForeColor = System.Drawing.Color.Black;
            this.licencePlateLabel.Location = new System.Drawing.Point(101, 362);
            this.licencePlateLabel.Name = "licencePlateLabel";
            this.licencePlateLabel.Size = new System.Drawing.Size(121, 15);
            this.licencePlateLabel.TabIndex = 7;
            this.licencePlateLabel.Text = "Current License Plate:";
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.Location = new System.Drawing.Point(101, 402);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(117, 15);
            this.VehicleTypeLabel.TabIndex = 8;
            this.VehicleTypeLabel.Text = "Current Vehicle Type:";
            // 
            // ParkingSpotLabel
            // 
            this.ParkingSpotLabel.AutoSize = true;
            this.ParkingSpotLabel.Location = new System.Drawing.Point(304, 582);
            this.ParkingSpotLabel.Name = "ParkingSpotLabel";
            this.ParkingSpotLabel.Size = new System.Drawing.Size(77, 30);
            this.ParkingSpotLabel.TabIndex = 9;
            this.ParkingSpotLabel.Text = "Current \r\nParking Spot:";
            // 
            // CheckInDateLabel
            // 
            this.CheckInDateLabel.AutoSize = true;
            this.CheckInDateLabel.Location = new System.Drawing.Point(101, 444);
            this.CheckInDateLabel.Name = "CheckInDateLabel";
            this.CheckInDateLabel.Size = new System.Drawing.Size(84, 15);
            this.CheckInDateLabel.TabIndex = 10;
            this.CheckInDateLabel.Text = "Arrival Time * :";
            // 
            // editRegNumber
            // 
            this.editRegNumber.Enabled = false;
            this.editRegNumber.Location = new System.Drawing.Point(241, 360);
            this.editRegNumber.Name = "editRegNumber";
            this.editRegNumber.ReadOnly = true;
            this.editRegNumber.Size = new System.Drawing.Size(107, 23);
            this.editRegNumber.TabIndex = 11;
            // 
            // editVehicleType
            // 
            this.editVehicleType.Enabled = false;
            this.editVehicleType.Location = new System.Drawing.Point(241, 399);
            this.editVehicleType.Name = "editVehicleType";
            this.editVehicleType.ReadOnly = true;
            this.editVehicleType.Size = new System.Drawing.Size(107, 23);
            this.editVehicleType.TabIndex = 12;
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.EditLabel.Location = new System.Drawing.Point(101, 314);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(85, 28);
            this.EditLabel.TabIndex = 15;
            this.EditLabel.Text = "Update:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(241, 440);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 18;
            // 
            // UpdateLicencePlate
            // 
            this.UpdateLicencePlate.AutoSize = true;
            this.UpdateLicencePlate.Location = new System.Drawing.Point(598, 359);
            this.UpdateLicencePlate.Name = "UpdateLicencePlate";
            this.UpdateLicencePlate.Size = new System.Drawing.Size(135, 25);
            this.UpdateLicencePlate.TabIndex = 19;
            this.UpdateLicencePlate.Text = "Update Licence Plate";
            this.UpdateLicencePlate.UseVisualStyleBackColor = true;
            this.UpdateLicencePlate.Click += new System.EventHandler(this.UpdateLicensePlate_Click);
            // 
            // UpdateVehicleType
            // 
            this.UpdateVehicleType.AutoSize = true;
            this.UpdateVehicleType.Location = new System.Drawing.Point(598, 399);
            this.UpdateVehicleType.Name = "UpdateVehicleType";
            this.UpdateVehicleType.Size = new System.Drawing.Size(135, 25);
            this.UpdateVehicleType.TabIndex = 20;
            this.UpdateVehicleType.Text = "Update Vehicle Type";
            this.UpdateVehicleType.UseVisualStyleBackColor = true;
            this.UpdateVehicleType.Click += new System.EventHandler(this.UpdateVehicleType_Click);
            // 
            // UpdateCheckInDate
            // 
            this.UpdateCheckInDate.AutoSize = true;
            this.UpdateCheckInDate.Location = new System.Drawing.Point(598, 440);
            this.UpdateCheckInDate.Name = "UpdateCheckInDate";
            this.UpdateCheckInDate.Size = new System.Drawing.Size(135, 25);
            this.UpdateCheckInDate.TabIndex = 21;
            this.UpdateCheckInDate.Text = "Update Check In Date";
            this.UpdateCheckInDate.UseVisualStyleBackColor = true;
            this.UpdateCheckInDate.Click += new System.EventHandler(this.UpdateCheckInDate_Click);
            // 
            // editParkingSpot
            // 
            this.editParkingSpot.Enabled = false;
            this.editParkingSpot.Location = new System.Drawing.Point(411, 589);
            this.editParkingSpot.Name = "editParkingSpot";
            this.editParkingSpot.ReadOnly = true;
            this.editParkingSpot.Size = new System.Drawing.Size(73, 23);
            this.editParkingSpot.TabIndex = 13;
            // 
            // moveVehicleLabel
            // 
            this.moveVehicleLabel.AutoSize = true;
            this.moveVehicleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.moveVehicleLabel.Location = new System.Drawing.Point(101, 532);
            this.moveVehicleLabel.Name = "moveVehicleLabel";
            this.moveVehicleLabel.Size = new System.Drawing.Size(144, 28);
            this.moveVehicleLabel.TabIndex = 22;
            this.moveVehicleLabel.Text = "Move Vehicle:";
            // 
            // MoveVehicleButton
            // 
            this.MoveVehicleButton.AutoSize = true;
            this.MoveVehicleButton.Location = new System.Drawing.Point(520, 615);
            this.MoveVehicleButton.Name = "MoveVehicleButton";
            this.MoveVehicleButton.Size = new System.Drawing.Size(135, 25);
            this.MoveVehicleButton.TabIndex = 23;
            this.MoveVehicleButton.Text = "Move Vehicle";
            this.MoveVehicleButton.UseVisualStyleBackColor = true;
            this.MoveVehicleButton.Click += new System.EventHandler(this.MoveVehicleButton_Click);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(475, 440);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(107, 23);
            this.timePicker.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "New Parking Spot:";
            // 
            // newParkingSpot
            // 
            this.newParkingSpot.Location = new System.Drawing.Point(411, 640);
            this.newParkingSpot.Name = "newParkingSpot";
            this.newParkingSpot.Size = new System.Drawing.Size(73, 23);
            this.newParkingSpot.TabIndex = 26;
            // 
            // NewVehicleType
            // 
            this.NewVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewVehicleType.FormattingEnabled = true;
            this.NewVehicleType.Items.AddRange(new object[] {
            "Car",
            "MC"});
            this.NewVehicleType.Location = new System.Drawing.Point(475, 400);
            this.NewVehicleType.Name = "NewVehicleType";
            this.NewVehicleType.Size = new System.Drawing.Size(107, 23);
            this.NewVehicleType.TabIndex = 27;
            // 
            // newLicencePlate
            // 
            this.newLicencePlate.Location = new System.Drawing.Point(475, 359);
            this.newLicencePlate.Name = "newLicencePlate";
            this.newLicencePlate.Size = new System.Drawing.Size(107, 23);
            this.newLicencePlate.TabIndex = 28;
            // 
            // newLicancePlateLabel
            // 
            this.newLicancePlateLabel.AutoSize = true;
            this.newLicancePlateLabel.Location = new System.Drawing.Point(360, 363);
            this.newLicancePlateLabel.Name = "newLicancePlateLabel";
            this.newLicancePlateLabel.Size = new System.Drawing.Size(108, 15);
            this.newLicancePlateLabel.TabIndex = 29;
            this.newLicancePlateLabel.Text = "New  License Plate:";
            // 
            // NewVehicleTypeLabel
            // 
            this.NewVehicleTypeLabel.AutoSize = true;
            this.NewVehicleTypeLabel.Location = new System.Drawing.Point(360, 403);
            this.NewVehicleTypeLabel.Name = "NewVehicleTypeLabel";
            this.NewVehicleTypeLabel.Size = new System.Drawing.Size(101, 15);
            this.NewVehicleTypeLabel.TabIndex = 30;
            this.NewVehicleTypeLabel.Text = "New Vehicle Type:";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(555, 120);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAllButton.TabIndex = 31;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // DateTimeInstrutions
            // 
            this.DateTimeInstrutions.AutoSize = true;
            this.DateTimeInstrutions.Location = new System.Drawing.Point(241, 466);
            this.DateTimeInstrutions.Name = "DateTimeInstrutions";
            this.DateTimeInstrutions.Size = new System.Drawing.Size(347, 15);
            this.DateTimeInstrutions.TabIndex = 32;
            this.DateTimeInstrutions.Text = "* Select date from calender and enter time to change arrival time\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(203, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 75);
            this.label3.TabIndex = 33;
            this.label3.Text = "Search the license plate number to be able to edit vehicle entry!\r\nVehicles infor" +
    "mation will be filled in automaticly.\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveButton
            // 
            this.RemoveButton.AutoSize = true;
            this.RemoveButton.Location = new System.Drawing.Point(598, 502);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(135, 25);
            this.RemoveButton.TabIndex = 34;
            this.RemoveButton.Text = "Remove Vehicle";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "To remove the vehicle completely :";
            // 
            // FormVehicleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1342, 777);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimeInstrutions);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.NewVehicleTypeLabel);
            this.Controls.Add(this.newLicancePlateLabel);
            this.Controls.Add(this.newLicencePlate);
            this.Controls.Add(this.NewVehicleType);
            this.Controls.Add(this.newParkingSpot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.MoveVehicleButton);
            this.Controls.Add(this.moveVehicleLabel);
            this.Controls.Add(this.UpdateCheckInDate);
            this.Controls.Add(this.UpdateVehicleType);
            this.Controls.Add(this.UpdateLicencePlate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.EditLabel);
            this.Controls.Add(this.editParkingSpot);
            this.Controls.Add(this.editVehicleType);
            this.Controls.Add(this.editRegNumber);
            this.Controls.Add(this.CheckInDateLabel);
            this.Controls.Add(this.ParkingSpotLabel);
            this.Controls.Add(this.VehicleTypeLabel);
            this.Controls.Add(this.licencePlateLabel);
            this.Controls.Add(this.parkingLotViewer);
            this.Controls.Add(this.licensePlateLabel);
            this.Controls.Add(this.searchResultsView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.RegNummerTextBox);
            this.Controls.Add(this.searchLabel);
            this.Name = "FormVehicleManagement";
            this.Text = "Vehicle Management";
            this.Load += new System.EventHandler(this.FormVehicleManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label searchLabel;
        private TextBox RegNummerTextBox;
        private Button searchButton;
        private ListView searchResultsView;
        private ColumnHeader RegNumber;
        private ColumnHeader vehicleType;
        private ColumnHeader ParkingSpot;
        private ColumnHeader CheckInDate;
        private Label licensePlateLabel;
        private ListView parkingLotViewer;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label licencePlateLabel;
        private Label VehicleTypeLabel;
        private Label ParkingSpotLabel;
        private Label CheckInDateLabel;
        private TextBox editRegNumber;
        private TextBox editVehicleType;
        private Label EditLabel;
        private DateTimePicker dateTimePicker;
        private Button UpdateLicencePlate;
        private Button UpdateVehicleType;
        private Button UpdateCheckInDate;
        private TextBox editParkingSpot;
        private Label moveVehicleLabel;
        private Button MoveVehicleButton;
        private DateTimePicker timePicker;
        private Label label2;
        private TextBox newParkingSpot;
        private ComboBox NewVehicleType;
        private TextBox newLicencePlate;
        private Label newLicancePlateLabel;
        private Label NewVehicleTypeLabel;
        private Button ClearAllButton;
        private Label DateTimeInstrutions;
        private Label label3;
        private Button RemoveButton;
        private Label label4;
    }
}