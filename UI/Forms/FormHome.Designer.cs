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
            this.HomeLabel = new System.Windows.Forms.Label();
            this.price_Lbl = new System.Windows.Forms.Label();
            this.price_ListVw = new System.Windows.Forms.ListView();
            this.pricePerHour = new System.Windows.Forms.ColumnHeader();
            this.discount_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeLabel.Location = new System.Drawing.Point(472, 280);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(231, 54);
            this.HomeLabel.TabIndex = 0;
            this.HomeLabel.Text = "Home Form";
            // 
            // price_Lbl
            // 
            this.price_Lbl.AutoSize = true;
            this.price_Lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.price_Lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.price_Lbl.Location = new System.Drawing.Point(58, 470);
            this.price_Lbl.Name = "price_Lbl";
            this.price_Lbl.Size = new System.Drawing.Size(59, 21);
            this.price_Lbl.TabIndex = 1;
            this.price_Lbl.Text = "Price*:";
            this.price_Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // price_ListVw
            // 
            this.price_ListVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pricePerHour});
            this.price_ListVw.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price_ListVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.price_ListVw.Location = new System.Drawing.Point(58, 493);
            this.price_ListVw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price_ListVw.Name = "price_ListVw";
            this.price_ListVw.Size = new System.Drawing.Size(147, 82);
            this.price_ListVw.TabIndex = 2;
            this.price_ListVw.UseCompatibleStateImageBehavior = false;
            this.price_ListVw.View = System.Windows.Forms.View.Details;
            // 
            // pricePerHour
            // 
            this.pricePerHour.Text = "Price Per Hour";
            this.pricePerHour.Width = 100;
            // 
            // discount_Lbl
            // 
            this.discount_Lbl.AutoSize = true;
            this.discount_Lbl.Location = new System.Drawing.Point(58, 577);
            this.discount_Lbl.Name = "discount_Lbl";
            this.discount_Lbl.Size = new System.Drawing.Size(104, 15);
            this.discount_Lbl.TabIndex = 3;
            this.discount_Lbl.Text = "*First 10min is free";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1355, 715);
            this.Controls.Add(this.discount_Lbl);
            this.Controls.Add(this.price_ListVw);
            this.Controls.Add(this.price_Lbl);
            this.Controls.Add(this.HomeLabel);
            this.Name = "FormHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HomeLabel;
        private Label price_Lbl;
        private ListView price_ListVw;
        private Label discount_Lbl;
        private ColumnHeader pricePerHour;
    }
}