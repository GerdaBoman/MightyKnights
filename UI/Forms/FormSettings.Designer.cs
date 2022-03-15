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
            this.label1 = new System.Windows.Forms.Label();
            this.cPrice_edit_btn = new System.Windows.Forms.Button();
            this.mcPrice_Edit_btn = new System.Windows.Forms.Button();
            this.gSize_Edit_btn = new System.Windows.Forms.Button();
            this.carPrice_lbl = new System.Windows.Forms.Label();
            this.mcPrice_lbl = new System.Windows.Forms.Label();
            this.garageSize_lbl = new System.Windows.Forms.Label();
            this.cPrice_txt = new System.Windows.Forms.TextBox();
            this.mcPrice_txt = new System.Windows.Forms.TextBox();
            this.gSize_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(464, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings Form";
            // 
            // cPrice_edit_btn
            // 
            this.cPrice_edit_btn.Location = new System.Drawing.Point(300, 279);
            this.cPrice_edit_btn.Name = "cPrice_edit_btn";
            this.cPrice_edit_btn.Size = new System.Drawing.Size(94, 29);
            this.cPrice_edit_btn.TabIndex = 2;
            this.cPrice_edit_btn.Text = "Edit";
            this.cPrice_edit_btn.UseVisualStyleBackColor = true;
            this.cPrice_edit_btn.Click += new System.EventHandler(this.cPrice_edit_btn_Click);
            // 
            // mcPrice_Edit_btn
            // 
            this.mcPrice_Edit_btn.Location = new System.Drawing.Point(300, 365);
            this.mcPrice_Edit_btn.Name = "mcPrice_Edit_btn";
            this.mcPrice_Edit_btn.Size = new System.Drawing.Size(94, 29);
            this.mcPrice_Edit_btn.TabIndex = 3;
            this.mcPrice_Edit_btn.Text = "Edit";
            this.mcPrice_Edit_btn.UseVisualStyleBackColor = true;
            // 
            // gSize_Edit_btn
            // 
            this.gSize_Edit_btn.Location = new System.Drawing.Point(300, 454);
            this.gSize_Edit_btn.Name = "gSize_Edit_btn";
            this.gSize_Edit_btn.Size = new System.Drawing.Size(94, 29);
            this.gSize_Edit_btn.TabIndex = 4;
            this.gSize_Edit_btn.Text = "Edit";
            this.gSize_Edit_btn.UseVisualStyleBackColor = true;
            // 
            // carPrice_lbl
            // 
            this.carPrice_lbl.AutoSize = true;
            this.carPrice_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carPrice_lbl.Location = new System.Drawing.Point(11, 276);
            this.carPrice_lbl.Name = "carPrice_lbl";
            this.carPrice_lbl.Size = new System.Drawing.Size(96, 28);
            this.carPrice_lbl.TabIndex = 5;
            this.carPrice_lbl.Text = "Car Price";
            // 
            // mcPrice_lbl
            // 
            this.mcPrice_lbl.AutoSize = true;
            this.mcPrice_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mcPrice_lbl.Location = new System.Drawing.Point(13, 362);
            this.mcPrice_lbl.Name = "mcPrice_lbl";
            this.mcPrice_lbl.Size = new System.Drawing.Size(94, 28);
            this.mcPrice_lbl.TabIndex = 6;
            this.mcPrice_lbl.Text = "Mc Price";
            // 
            // garageSize_lbl
            // 
            this.garageSize_lbl.AutoSize = true;
            this.garageSize_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.garageSize_lbl.Location = new System.Drawing.Point(13, 450);
            this.garageSize_lbl.Name = "garageSize_lbl";
            this.garageSize_lbl.Size = new System.Drawing.Size(123, 28);
            this.garageSize_lbl.TabIndex = 7;
            this.garageSize_lbl.Text = "Garage Size";
            // 
            // cPrice_txt
            // 
            this.cPrice_txt.Location = new System.Drawing.Point(155, 281);
            this.cPrice_txt.Name = "cPrice_txt";
            this.cPrice_txt.ReadOnly = true;
            this.cPrice_txt.Size = new System.Drawing.Size(125, 27);
            this.cPrice_txt.TabIndex = 8;
            this.cPrice_txt.ReadOnlyChanged += new System.EventHandler(this.cPrice_edit_btn_Click);
            // 
            // mcPrice_txt
            // 
            this.mcPrice_txt.Location = new System.Drawing.Point(155, 365);
            this.mcPrice_txt.Name = "mcPrice_txt";
            this.mcPrice_txt.ReadOnly = true;
            this.mcPrice_txt.Size = new System.Drawing.Size(125, 27);
            this.mcPrice_txt.TabIndex = 9;
            // 
            // gSize_txt
            // 
            this.gSize_txt.Location = new System.Drawing.Point(155, 455);
            this.gSize_txt.Name = "gSize_txt";
            this.gSize_txt.ReadOnly = true;
            this.gSize_txt.Size = new System.Drawing.Size(125, 27);
            this.gSize_txt.TabIndex = 10;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1534, 1036);
            this.Controls.Add(this.gSize_txt);
            this.Controls.Add(this.mcPrice_txt);
            this.Controls.Add(this.cPrice_txt);
            this.Controls.Add(this.garageSize_lbl);
            this.Controls.Add(this.mcPrice_lbl);
            this.Controls.Add(this.carPrice_lbl);
            this.Controls.Add(this.gSize_Edit_btn);
            this.Controls.Add(this.mcPrice_Edit_btn);
            this.Controls.Add(this.cPrice_edit_btn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button cPrice_edit_btn;
        private Button mcPrice_Edit_btn;
        private Button gSize_Edit_btn;
        private Label carPrice_lbl;
        private Label mcPrice_lbl;
        private Label garageSize_lbl;
        private TextBox cPrice_txt;
        private TextBox mcPrice_txt;
        private TextBox gSize_txt;
    }
}