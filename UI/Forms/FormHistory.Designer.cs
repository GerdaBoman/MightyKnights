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
            this.historyViewer.Location = new System.Drawing.Point(153, 69);
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
            this.refreshButton.Location = new System.Drawing.Point(900, 202);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(89, 67);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // DeteleButton
            // 
            this.DeteleButton.Location = new System.Drawing.Point(1056, 203);
            this.DeteleButton.Name = "DeteleButton";
            this.DeteleButton.Size = new System.Drawing.Size(89, 64);
            this.DeteleButton.TabIndex = 2;
            this.DeteleButton.Text = "Delete";
            this.DeteleButton.UseVisualStyleBackColor = true;
            this.DeteleButton.Click += new System.EventHandler(this.DeteleButton_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 781);
            this.Controls.Add(this.DeteleButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.historyViewer);
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.ResumeLayout(false);

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
    }
}