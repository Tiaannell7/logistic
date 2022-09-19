
namespace CtuLogistics
{
    partial class DriverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            this.Driver_Information_GroupBox = new System.Windows.Forms.GroupBox();
            this.Driver_DataGridView = new System.Windows.Forms.DataGridView();
            this.Driver_Exit_Button = new System.Windows.Forms.Button();
            this.Driver_Delete_Button = new System.Windows.Forms.Button();
            this.Driver_Update_Button = new System.Windows.Forms.Button();
            this.Driver_Read_Button = new System.Windows.Forms.Button();
            this.Driver_Create_Button = new System.Windows.Forms.Button();
            this.Driver_Owner_No_RadioButton = new System.Windows.Forms.RadioButton();
            this.Driver_Owner_Yes_RadioButton = new System.Windows.Forms.RadioButton();
            this.Driver_Owner_Label = new System.Windows.Forms.Label();
            this.Driver_LicenseType_ComboBox = new System.Windows.Forms.ComboBox();
            this.Driver_LicenseType_Label = new System.Windows.Forms.Label();
            this.Driver_FullName_TextBox = new System.Windows.Forms.TextBox();
            this.Driver_FullName_Lable = new System.Windows.Forms.Label();
            this.Driver_Information_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Driver_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Driver_Information_GroupBox
            // 
            this.Driver_Information_GroupBox.BackColor = System.Drawing.Color.White;
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_DataGridView);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_Exit_Button);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_Delete_Button);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_Update_Button);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_Read_Button);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_Create_Button);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_Owner_No_RadioButton);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_Owner_Yes_RadioButton);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_Owner_Label);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_LicenseType_ComboBox);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_LicenseType_Label);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_FullName_TextBox);
            this.Driver_Information_GroupBox.Controls.Add(this.Driver_FullName_Lable);
            this.Driver_Information_GroupBox.Location = new System.Drawing.Point(4, 12);
            this.Driver_Information_GroupBox.Name = "Driver_Information_GroupBox";
            this.Driver_Information_GroupBox.Size = new System.Drawing.Size(915, 709);
            this.Driver_Information_GroupBox.TabIndex = 0;
            this.Driver_Information_GroupBox.TabStop = false;
            this.Driver_Information_GroupBox.Text = "Driver Information";
            // 
            // Driver_DataGridView
            // 
            this.Driver_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Driver_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Driver_DataGridView.Location = new System.Drawing.Point(16, 225);
            this.Driver_DataGridView.Name = "Driver_DataGridView";
            this.Driver_DataGridView.RowHeadersWidth = 51;
            this.Driver_DataGridView.RowTemplate.Height = 29;
            this.Driver_DataGridView.Size = new System.Drawing.Size(893, 478);
            this.Driver_DataGridView.TabIndex = 64;
            // 
            // Driver_Exit_Button
            // 
            this.Driver_Exit_Button.Location = new System.Drawing.Point(585, 185);
            this.Driver_Exit_Button.Name = "Driver_Exit_Button";
            this.Driver_Exit_Button.Size = new System.Drawing.Size(134, 34);
            this.Driver_Exit_Button.TabIndex = 63;
            this.Driver_Exit_Button.Text = "Exit";
            this.Driver_Exit_Button.UseVisualStyleBackColor = true;
            this.Driver_Exit_Button.Click += new System.EventHandler(this.Driver_Exit_Button_Click);
            // 
            // Driver_Delete_Button
            // 
            this.Driver_Delete_Button.Location = new System.Drawing.Point(440, 185);
            this.Driver_Delete_Button.Name = "Driver_Delete_Button";
            this.Driver_Delete_Button.Size = new System.Drawing.Size(134, 34);
            this.Driver_Delete_Button.TabIndex = 62;
            this.Driver_Delete_Button.Text = "Delete";
            this.Driver_Delete_Button.UseVisualStyleBackColor = true;
            this.Driver_Delete_Button.Click += new System.EventHandler(this.Driver_Delete_Button_Click);
            // 
            // Driver_Update_Button
            // 
            this.Driver_Update_Button.Location = new System.Drawing.Point(297, 185);
            this.Driver_Update_Button.Name = "Driver_Update_Button";
            this.Driver_Update_Button.Size = new System.Drawing.Size(134, 34);
            this.Driver_Update_Button.TabIndex = 61;
            this.Driver_Update_Button.Text = "Update";
            this.Driver_Update_Button.UseVisualStyleBackColor = true;
            this.Driver_Update_Button.Click += new System.EventHandler(this.Driver_Update_Button_Click);
            // 
            // Driver_Read_Button
            // 
            this.Driver_Read_Button.Location = new System.Drawing.Point(156, 185);
            this.Driver_Read_Button.Name = "Driver_Read_Button";
            this.Driver_Read_Button.Size = new System.Drawing.Size(134, 34);
            this.Driver_Read_Button.TabIndex = 60;
            this.Driver_Read_Button.Text = "Read";
            this.Driver_Read_Button.UseVisualStyleBackColor = true;
            this.Driver_Read_Button.Click += new System.EventHandler(this.Driver_Read_Button_Click);
            // 
            // Driver_Create_Button
            // 
            this.Driver_Create_Button.Location = new System.Drawing.Point(16, 185);
            this.Driver_Create_Button.Name = "Driver_Create_Button";
            this.Driver_Create_Button.Size = new System.Drawing.Size(134, 34);
            this.Driver_Create_Button.TabIndex = 59;
            this.Driver_Create_Button.Text = "Create";
            this.Driver_Create_Button.UseVisualStyleBackColor = true;
            this.Driver_Create_Button.Click += new System.EventHandler(this.Driver_Create_Button_Click);
            // 
            // Driver_Owner_No_RadioButton
            // 
            this.Driver_Owner_No_RadioButton.AutoSize = true;
            this.Driver_Owner_No_RadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Driver_Owner_No_RadioButton.Location = new System.Drawing.Point(222, 137);
            this.Driver_Owner_No_RadioButton.Name = "Driver_Owner_No_RadioButton";
            this.Driver_Owner_No_RadioButton.Size = new System.Drawing.Size(54, 27);
            this.Driver_Owner_No_RadioButton.TabIndex = 58;
            this.Driver_Owner_No_RadioButton.TabStop = true;
            this.Driver_Owner_No_RadioButton.Text = "No";
            this.Driver_Owner_No_RadioButton.UseVisualStyleBackColor = true;
            this.Driver_Owner_No_RadioButton.CheckedChanged += new System.EventHandler(this.Driver_Owner_No_RadioButton_CheckedChanged);
            // 
            // Driver_Owner_Yes_RadioButton
            // 
            this.Driver_Owner_Yes_RadioButton.AutoSize = true;
            this.Driver_Owner_Yes_RadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Driver_Owner_Yes_RadioButton.Location = new System.Drawing.Point(147, 138);
            this.Driver_Owner_Yes_RadioButton.Name = "Driver_Owner_Yes_RadioButton";
            this.Driver_Owner_Yes_RadioButton.Size = new System.Drawing.Size(55, 27);
            this.Driver_Owner_Yes_RadioButton.TabIndex = 57;
            this.Driver_Owner_Yes_RadioButton.TabStop = true;
            this.Driver_Owner_Yes_RadioButton.Text = "Yes";
            this.Driver_Owner_Yes_RadioButton.UseVisualStyleBackColor = true;
            this.Driver_Owner_Yes_RadioButton.CheckedChanged += new System.EventHandler(this.Driver_Owner_Yes_RadioButton_CheckedChanged);
            // 
            // Driver_Owner_Label
            // 
            this.Driver_Owner_Label.AutoSize = true;
            this.Driver_Owner_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Driver_Owner_Label.Location = new System.Drawing.Point(19, 138);
            this.Driver_Owner_Label.Name = "Driver_Owner_Label";
            this.Driver_Owner_Label.Size = new System.Drawing.Size(60, 23);
            this.Driver_Owner_Label.TabIndex = 56;
            this.Driver_Owner_Label.Text = "Owner";
            // 
            // Driver_LicenseType_ComboBox
            // 
            this.Driver_LicenseType_ComboBox.FormattingEnabled = true;
            this.Driver_LicenseType_ComboBox.Items.AddRange(new object[] {
            "A = MOTOR CYCLES",
            "B = LIGHT MOTOR VEHICLES (UP TO 3 500 KG GVM)",
            "C = HEAVY MOTOR VEHICLES",
            "D = COMBINATIONS, INCLUDING ARTICULATED VEHICLES."});
            this.Driver_LicenseType_ComboBox.Location = new System.Drawing.Point(147, 89);
            this.Driver_LicenseType_ComboBox.Name = "Driver_LicenseType_ComboBox";
            this.Driver_LicenseType_ComboBox.Size = new System.Drawing.Size(343, 28);
            this.Driver_LicenseType_ComboBox.TabIndex = 55;
            // 
            // Driver_LicenseType_Label
            // 
            this.Driver_LicenseType_Label.AutoSize = true;
            this.Driver_LicenseType_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Driver_LicenseType_Label.Location = new System.Drawing.Point(19, 89);
            this.Driver_LicenseType_Label.Name = "Driver_LicenseType_Label";
            this.Driver_LicenseType_Label.Size = new System.Drawing.Size(105, 23);
            this.Driver_LicenseType_Label.TabIndex = 54;
            this.Driver_LicenseType_Label.Text = "License Type";
            // 
            // Driver_FullName_TextBox
            // 
            this.Driver_FullName_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Driver_FullName_TextBox.Location = new System.Drawing.Point(147, 43);
            this.Driver_FullName_TextBox.Name = "Driver_FullName_TextBox";
            this.Driver_FullName_TextBox.Size = new System.Drawing.Size(343, 30);
            this.Driver_FullName_TextBox.TabIndex = 53;
            // 
            // Driver_FullName_Lable
            // 
            this.Driver_FullName_Lable.AutoSize = true;
            this.Driver_FullName_Lable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Driver_FullName_Lable.Location = new System.Drawing.Point(19, 46);
            this.Driver_FullName_Lable.Name = "Driver_FullName_Lable";
            this.Driver_FullName_Lable.Size = new System.Drawing.Size(79, 23);
            this.Driver_FullName_Lable.TabIndex = 0;
            this.Driver_FullName_Lable.Text = "Fullname";
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 724);
            this.Controls.Add(this.Driver_Information_GroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverForm";
            this.Driver_Information_GroupBox.ResumeLayout(false);
            this.Driver_Information_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Driver_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Driver_FullName_Lable;
        private System.Windows.Forms.RadioButton Driver_Owner_No_RadioButton;
        private System.Windows.Forms.RadioButton Driver_Owner_Yes_RadioButton;
        private System.Windows.Forms.Label Driver_Owner_Label;
        private System.Windows.Forms.ComboBox Driver_LicenseType_ComboBox;
        private System.Windows.Forms.Label Driver_LicenseType_Label;
        private System.Windows.Forms.TextBox Driver_FullName_TextBox;
        private System.Windows.Forms.DataGridView Driver_DataGridView;
        private System.Windows.Forms.Button Driver_Exit_Button;
        private System.Windows.Forms.Button Driver_Delete_Button;
        private System.Windows.Forms.Button Driver_Update_Button;
        private System.Windows.Forms.Button Driver_Read_Button;
        private System.Windows.Forms.Button Driver_Create_Button;
        private System.Windows.Forms.GroupBox Driver_Information_GroupBox;
    }
}