namespace UI.Forms
{
    partial class FormHistory
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
            this.historyViewer = new System.Windows.Forms.ListView();
            this.LicencePlate = new System.Windows.Forms.ColumnHeader();
            this.UsedSpot = new System.Windows.Forms.ColumnHeader();
            this.arrivalDate = new System.Windows.Forms.ColumnHeader();
            this.departureDate = new System.Windows.Forms.ColumnHeader();
            this.totalCost = new System.Windows.Forms.ColumnHeader();
            this.refreshButton = new System.Windows.Forms.Button();
            this.DeteleButton = new System.Windows.Forms.Button();
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.VehiclesCheckOutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfVehicles = new System.Windows.Forms.Label();
            this.AmountEarned = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.selectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // historyViewer
            // 
            this.historyViewer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LicencePlate,
            this.UsedSpot,
            this.arrivalDate,
            this.departureDate,
            this.totalCost});
            this.historyViewer.Location = new System.Drawing.Point(63, 44);
            this.historyViewer.Name = "historyViewer";
            this.historyViewer.Size = new System.Drawing.Size(638, 605);
            this.historyViewer.TabIndex = 0;
            this.historyViewer.UseCompatibleStateImageBehavior = false;
            this.historyViewer.View = System.Windows.Forms.View.Details;
            // 
            // LicencePlate
            // 
            this.LicencePlate.Text = "Licence Plate";
            this.LicencePlate.Width = 150;
            // 
            // UsedSpot
            // 
            this.UsedSpot.Text = "Parking Spot";
            this.UsedSpot.Width = 100;
            // 
            // arrivalDate
            // 
            this.arrivalDate.Text = "Arrival Date";
            this.arrivalDate.Width = 150;
            // 
            // departureDate
            // 
            this.departureDate.Text = "Departure Date ";
            this.departureDate.Width = 150;
            // 
            // totalCost
            // 
            this.totalCost.Text = "Total Cost";
            this.totalCost.Width = 80;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(721, 585);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(89, 67);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // DeteleButton
            // 
            this.DeteleButton.BackColor = System.Drawing.Color.Tomato;
            this.DeteleButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeteleButton.ForeColor = System.Drawing.Color.Black;
            this.DeteleButton.Location = new System.Drawing.Point(838, 585);
            this.DeteleButton.Name = "DeteleButton";
            this.DeteleButton.Size = new System.Drawing.Size(89, 64);
            this.DeteleButton.TabIndex = 2;
            this.DeteleButton.Text = "Delete";
            this.DeteleButton.UseVisualStyleBackColor = false;
            this.DeteleButton.Click += new System.EventHandler(this.DeteleButton_Click);
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.CustomFormat = "yyyy-MM-dd";
            this.FromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDatePicker.Location = new System.Drawing.Point(746, 197);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(94, 23);
            this.FromDatePicker.TabIndex = 3;
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.CustomFormat = "yyyy-MM-dd";
            this.ToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDatePicker.Location = new System.Drawing.Point(1030, 197);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(106, 23);
            this.ToDatePicker.TabIndex = 4;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fromLabel.Location = new System.Drawing.Point(720, 150);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(132, 21);
            this.fromLabel.TabIndex = 5;
            this.fromLabel.Text = "Start Date Time:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToLabel.Location = new System.Drawing.Point(1030, 150);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(125, 21);
            this.ToLabel.TabIndex = 6;
            this.ToLabel.Text = "End Date Time:";
            // 
            // VehiclesCheckOutLabel
            // 
            this.VehiclesCheckOutLabel.AutoSize = true;
            this.VehiclesCheckOutLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VehiclesCheckOutLabel.Location = new System.Drawing.Point(738, 331);
            this.VehiclesCheckOutLabel.Name = "VehiclesCheckOutLabel";
            this.VehiclesCheckOutLabel.Size = new System.Drawing.Size(208, 25);
            this.VehiclesCheckOutLabel.TabIndex = 7;
            this.VehiclesCheckOutLabel.Text = "Total amount of vehicles:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(812, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Income earned:";
            // 
            // NumberOfVehicles
            // 
            this.NumberOfVehicles.AutoSize = true;
            this.NumberOfVehicles.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.NumberOfVehicles.Location = new System.Drawing.Point(1030, 332);
            this.NumberOfVehicles.Name = "NumberOfVehicles";
            this.NumberOfVehicles.Size = new System.Drawing.Size(94, 21);
            this.NumberOfVehicles.TabIndex = 9;
            this.NumberOfVehicles.Text = "____________";
            // 
            // AmountEarned
            // 
            this.AmountEarned.AutoSize = true;
            this.AmountEarned.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AmountEarned.Location = new System.Drawing.Point(1030, 420);
            this.AmountEarned.Name = "AmountEarned";
            this.AmountEarned.Size = new System.Drawing.Size(94, 21);
            this.AmountEarned.TabIndex = 10;
            this.AmountEarned.Text = "____________";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(943, 238);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 52);
            this.selectButton.TabIndex = 11;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(746, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select two dates to see statistic between those days:";
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(846, 197);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(66, 23);
            this.startTime.TabIndex = 13;
            // 
            // endTime
            // 
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(1142, 197);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(69, 23);
            this.endTime.TabIndex = 14;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 781);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.AmountEarned);
            this.Controls.Add(this.NumberOfVehicles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VehiclesCheckOutLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.DeteleButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.historyViewer);
            this.Name = "FormHistory";
            this.Text = "History Log";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView historyViewer;
        private ColumnHeader LicencePlate;
        private ColumnHeader UsedSpot;
        private ColumnHeader arrivalDate;
        private ColumnHeader departureDate;
        private ColumnHeader totalCost;
        private Button refreshButton;
        private Button DeteleButton;
        private DateTimePicker FromDatePicker;
        private DateTimePicker ToDatePicker;
        private Label fromLabel;
        private Label ToLabel;
        private Label VehiclesCheckOutLabel;
        private Label label1;
        private Label NumberOfVehicles;
        private Label AmountEarned;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button selectButton;
        private Label label2;
        private DateTimePicker startTime;
        private DateTimePicker endTime;
    }
}