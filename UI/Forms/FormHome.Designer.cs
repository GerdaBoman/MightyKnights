namespace UI
{
    partial class FormHome
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
            this.price_Lbl = new System.Windows.Forms.Label();
            this.price_ListVw = new System.Windows.Forms.ListView();
            this.pricePerHour = new System.Windows.Forms.ColumnHeader();
            this.discount_Lbl = new System.Windows.Forms.Label();
            this.totalSpotsLabel = new System.Windows.Forms.Label();
            this.TotalCarparkSize = new System.Windows.Forms.Label();
            this.FreeParkingSpotLabel = new System.Windows.Forms.Label();
            this.NumberOfFreeSpots = new System.Windows.Forms.Label();
            this.TotalCarsParkedLabel = new System.Windows.Forms.Label();
            this.NumberOfCars = new System.Windows.Forms.Label();
            this.TotalMcPArked = new System.Windows.Forms.Label();
            this.NumberOfMC = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TestDataButton = new FontAwesome.Sharp.IconButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.PartialEmptySpots = new System.Windows.Forms.Label();
            this.partialTakenSpots = new System.Windows.Forms.Label();
            this.TotalFullSpaces = new System.Windows.Forms.Label();
            this.fullSpaces = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // price_Lbl
            // 
            this.price_Lbl.AutoSize = true;
            this.price_Lbl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.price_Lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_Lbl.Location = new System.Drawing.Point(717, 350);
            this.price_Lbl.Name = "price_Lbl";
            this.price_Lbl.Size = new System.Drawing.Size(177, 28);
            this.price_Lbl.TabIndex = 1;
            this.price_Lbl.Text = "Current Prices *  :";
            this.price_Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // price_ListVw
            // 
            this.price_ListVw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price_ListVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pricePerHour});
            this.price_ListVw.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_ListVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.price_ListVw.Location = new System.Drawing.Point(717, 380);
            this.price_ListVw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price_ListVw.Name = "price_ListVw";
            this.price_ListVw.Size = new System.Drawing.Size(356, 64);
            this.price_ListVw.TabIndex = 2;
            this.price_ListVw.UseCompatibleStateImageBehavior = false;
            this.price_ListVw.View = System.Windows.Forms.View.Details;
            // 
            // pricePerHour
            // 
            this.pricePerHour.Text = "Price Per Hour ";
            this.pricePerHour.Width = 300;
            // 
            // discount_Lbl
            // 
            this.discount_Lbl.AutoSize = true;
            this.discount_Lbl.Location = new System.Drawing.Point(717, 446);
            this.discount_Lbl.Name = "discount_Lbl";
            this.discount_Lbl.Size = new System.Drawing.Size(104, 15);
            this.discount_Lbl.TabIndex = 3;
            this.discount_Lbl.Text = "*First 10min is free";
            // 
            // totalSpotsLabel
            // 
            this.totalSpotsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalSpotsLabel.AutoSize = true;
            this.totalSpotsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.totalSpotsLabel.Location = new System.Drawing.Point(76, 189);
            this.totalSpotsLabel.Name = "totalSpotsLabel";
            this.totalSpotsLabel.Size = new System.Drawing.Size(288, 37);
            this.totalSpotsLabel.TabIndex = 4;
            this.totalSpotsLabel.Text = "Total Parking Spaces:";
            // 
            // TotalCarparkSize
            // 
            this.TotalCarparkSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalCarparkSize.AutoSize = true;
            this.TotalCarparkSize.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalCarparkSize.ForeColor = System.Drawing.Color.Black;
            this.TotalCarparkSize.Location = new System.Drawing.Point(388, 189);
            this.TotalCarparkSize.Name = "TotalCarparkSize";
            this.TotalCarparkSize.Size = new System.Drawing.Size(208, 37);
            this.TotalCarparkSize.TabIndex = 5;
            this.TotalCarparkSize.Text = "NumberOfSpots";
            // 
            // FreeParkingSpotLabel
            // 
            this.FreeParkingSpotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FreeParkingSpotLabel.AutoSize = true;
            this.FreeParkingSpotLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FreeParkingSpotLabel.Location = new System.Drawing.Point(76, 259);
            this.FreeParkingSpotLabel.Name = "FreeParkingSpotLabel";
            this.FreeParkingSpotLabel.Size = new System.Drawing.Size(305, 37);
            this.FreeParkingSpotLabel.TabIndex = 6;
            this.FreeParkingSpotLabel.Text = "Empty Parking Spaces:";
            // 
            // NumberOfFreeSpots
            // 
            this.NumberOfFreeSpots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfFreeSpots.AutoSize = true;
            this.NumberOfFreeSpots.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOfFreeSpots.ForeColor = System.Drawing.Color.Green;
            this.NumberOfFreeSpots.Location = new System.Drawing.Point(388, 259);
            this.NumberOfFreeSpots.Name = "NumberOfFreeSpots";
            this.NumberOfFreeSpots.Size = new System.Drawing.Size(208, 37);
            this.NumberOfFreeSpots.TabIndex = 7;
            this.NumberOfFreeSpots.Text = "NumberOfSpots";
            // 
            // TotalCarsParkedLabel
            // 
            this.TotalCarsParkedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalCarsParkedLabel.AutoSize = true;
            this.TotalCarsParkedLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalCarsParkedLabel.Location = new System.Drawing.Point(717, 189);
            this.TotalCarsParkedLabel.Name = "TotalCarsParkedLabel";
            this.TotalCarsParkedLabel.Size = new System.Drawing.Size(247, 37);
            this.TotalCarsParkedLabel.TabIndex = 8;
            this.TotalCarsParkedLabel.Text = "Total Cars Parked:";
            // 
            // NumberOfCars
            // 
            this.NumberOfCars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfCars.AutoSize = true;
            this.NumberOfCars.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOfCars.ForeColor = System.Drawing.Color.Black;
            this.NumberOfCars.Location = new System.Drawing.Point(989, 189);
            this.NumberOfCars.Name = "NumberOfCars";
            this.NumberOfCars.Size = new System.Drawing.Size(193, 37);
            this.NumberOfCars.TabIndex = 9;
            this.NumberOfCars.Text = "NumberOfCars";
            // 
            // TotalMcPArked
            // 
            this.TotalMcPArked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalMcPArked.AutoSize = true;
            this.TotalMcPArked.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalMcPArked.Location = new System.Drawing.Point(717, 259);
            this.TotalMcPArked.Name = "TotalMcPArked";
            this.TotalMcPArked.Size = new System.Drawing.Size(235, 37);
            this.TotalMcPArked.TabIndex = 10;
            this.TotalMcPArked.Text = "Total MC Parked:";
            // 
            // NumberOfMC
            // 
            this.NumberOfMC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberOfMC.AutoSize = true;
            this.NumberOfMC.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOfMC.ForeColor = System.Drawing.Color.Black;
            this.NumberOfMC.Location = new System.Drawing.Point(989, 259);
            this.NumberOfMC.Name = "NumberOfMC";
            this.NumberOfMC.Size = new System.Drawing.Size(183, 37);
            this.NumberOfMC.TabIndex = 11;
            this.NumberOfMC.Text = "NumberOfMC";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(428, 68);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(448, 63);
            this.TitleLabel.TabIndex = 12;
            this.TitleLabel.Text = "Prague Parking 2.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.ferrari_PNG10669;
            this.pictureBox1.Location = new System.Drawing.Point(1101, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.scooter_PNG11340;
            this.pictureBox2.Location = new System.Drawing.Point(76, 516);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // TestDataButton
            // 
            this.TestDataButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TestDataButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TestDataButton.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.TestDataButton.IconColor = System.Drawing.Color.Black;
            this.TestDataButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TestDataButton.Location = new System.Drawing.Point(956, 545);
            this.TestDataButton.Name = "TestDataButton";
            this.TestDataButton.Size = new System.Drawing.Size(133, 77);
            this.TestDataButton.TabIndex = 15;
            this.TestDataButton.Text = "Test Data ";
            this.TestDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestDataButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TestDataButton.UseVisualStyleBackColor = false;
            this.TestDataButton.Click += new System.EventHandler(this.TestDataButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(911, 511);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(213, 21);
            this.infoLabel.TabIndex = 16;
            this.infoLabel.Text = "To use test data press here:";
            // 
            // PartialEmptySpots
            // 
            this.PartialEmptySpots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PartialEmptySpots.AutoSize = true;
            this.PartialEmptySpots.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PartialEmptySpots.Location = new System.Drawing.Point(76, 326);
            this.PartialEmptySpots.Name = "PartialEmptySpots";
            this.PartialEmptySpots.Size = new System.Drawing.Size(292, 37);
            this.PartialEmptySpots.TabIndex = 17;
            this.PartialEmptySpots.Text = "Partial Empty Spaces:";
            // 
            // partialTakenSpots
            // 
            this.partialTakenSpots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partialTakenSpots.AutoSize = true;
            this.partialTakenSpots.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partialTakenSpots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.partialTakenSpots.Location = new System.Drawing.Point(388, 326);
            this.partialTakenSpots.Name = "partialTakenSpots";
            this.partialTakenSpots.Size = new System.Drawing.Size(208, 37);
            this.partialTakenSpots.TabIndex = 18;
            this.partialTakenSpots.Text = "NumberOfSpots";
            // 
            // TotalFullSpaces
            // 
            this.TotalFullSpaces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalFullSpaces.AutoSize = true;
            this.TotalFullSpaces.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalFullSpaces.Location = new System.Drawing.Point(76, 398);
            this.TotalFullSpaces.Name = "TotalFullSpaces";
            this.TotalFullSpaces.Size = new System.Drawing.Size(236, 37);
            this.TotalFullSpaces.TabIndex = 19;
            this.TotalFullSpaces.Text = "Total Full Spaces:";
            // 
            // fullSpaces
            // 
            this.fullSpaces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullSpaces.AutoSize = true;
            this.fullSpaces.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullSpaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fullSpaces.Location = new System.Drawing.Point(388, 398);
            this.fullSpaces.Name = "fullSpaces";
            this.fullSpaces.Size = new System.Drawing.Size(208, 37);
            this.fullSpaces.TabIndex = 20;
            this.fullSpaces.Text = "NumberOfSpots";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1355, 715);
            this.Controls.Add(this.fullSpaces);
            this.Controls.Add(this.TotalFullSpaces);
            this.Controls.Add(this.partialTakenSpots);
            this.Controls.Add(this.PartialEmptySpots);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.TestDataButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NumberOfMC);
            this.Controls.Add(this.TotalMcPArked);
            this.Controls.Add(this.NumberOfCars);
            this.Controls.Add(this.TotalCarsParkedLabel);
            this.Controls.Add(this.NumberOfFreeSpots);
            this.Controls.Add(this.FreeParkingSpotLabel);
            this.Controls.Add(this.TotalCarparkSize);
            this.Controls.Add(this.totalSpotsLabel);
            this.Controls.Add(this.discount_Lbl);
            this.Controls.Add(this.price_ListVw);
            this.Controls.Add(this.price_Lbl);
            this.Name = "FormHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label price_Lbl;
        private ListView price_ListVw;
        private Label discount_Lbl;
        private ColumnHeader pricePerHourCar;
        private Label totalSpotsLabel;
        private Label TotalCarparkSize;
        private Label FreeParkingSpotLabel;
        private Label NumberOfFreeSpots;
        private Label TotalCarsParkedLabel;
        private Label NumberOfCars;
        private Label TotalMcPArked;
        private Label NumberOfMC;
        private Label TitleLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton TestDataButton;
        private Label infoLabel;
        private Label PartialEmptySpots;
        private Label partialTakenSpots;
        private Label TotalFullSpaces;
        private Label fullSpaces;
        private ColumnHeader PricePerHourMC;
        private ColumnHeader pricePerHour;
    }
}