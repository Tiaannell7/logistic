
namespace CtuLogistics
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.Customer_FullName_Label = new System.Windows.Forms.Label();
            this.Customer_ContactNumber_Label = new System.Windows.Forms.Label();
            this.Customer_Email_Label = new System.Windows.Forms.Label();
            this.Customer_Create_Button = new System.Windows.Forms.Button();
            this.Customer_Read_Button = new System.Windows.Forms.Button();
            this.Customer_Update_Button = new System.Windows.Forms.Button();
            this.Customer_Delete_Button = new System.Windows.Forms.Button();
            this.Customer_FullName_TextBox = new System.Windows.Forms.TextBox();
            this.Customer_ContactNumber_TextBox = new System.Windows.Forms.TextBox();
            this.Customer_Email_TextBox = new System.Windows.Forms.TextBox();
            this.Customer_Exit_Button = new System.Windows.Forms.Button();
            this.Customer_GroupBox = new System.Windows.Forms.GroupBox();
            this.Customer_DataGridView = new System.Windows.Forms.DataGridView();
            this.Customer_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_FullName_Label
            // 
            this.Customer_FullName_Label.AutoSize = true;
            this.Customer_FullName_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_FullName_Label.Location = new System.Drawing.Point(13, 41);
            this.Customer_FullName_Label.Name = "Customer_FullName_Label";
            this.Customer_FullName_Label.Size = new System.Drawing.Size(87, 23);
            this.Customer_FullName_Label.TabIndex = 44;
            this.Customer_FullName_Label.Text = "Full Name";
            // 
            // Customer_ContactNumber_Label
            // 
            this.Customer_ContactNumber_Label.AutoSize = true;
            this.Customer_ContactNumber_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_ContactNumber_Label.Location = new System.Drawing.Point(13, 82);
            this.Customer_ContactNumber_Label.Name = "Customer_ContactNumber_Label";
            this.Customer_ContactNumber_Label.Size = new System.Drawing.Size(138, 23);
            this.Customer_ContactNumber_Label.TabIndex = 45;
            this.Customer_ContactNumber_Label.Text = "Contact Number";
            // 
            // Customer_Email_Label
            // 
            this.Customer_Email_Label.AutoSize = true;
            this.Customer_Email_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_Email_Label.Location = new System.Drawing.Point(13, 127);
            this.Customer_Email_Label.Name = "Customer_Email_Label";
            this.Customer_Email_Label.Size = new System.Drawing.Size(51, 23);
            this.Customer_Email_Label.TabIndex = 46;
            this.Customer_Email_Label.Text = "Email";
            // 
            // Customer_Create_Button
            // 
            this.Customer_Create_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Customer_Create_Button.Location = new System.Drawing.Point(518, 182);
            this.Customer_Create_Button.Name = "Customer_Create_Button";
            this.Customer_Create_Button.Size = new System.Drawing.Size(120, 38);
            this.Customer_Create_Button.TabIndex = 47;
            this.Customer_Create_Button.Text = "Create";
            this.Customer_Create_Button.UseVisualStyleBackColor = false;
            this.Customer_Create_Button.Click += new System.EventHandler(this.Customer_Create_Button_Click);
            // 
            // Customer_Read_Button
            // 
            this.Customer_Read_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Customer_Read_Button.Location = new System.Drawing.Point(658, 182);
            this.Customer_Read_Button.Name = "Customer_Read_Button";
            this.Customer_Read_Button.Size = new System.Drawing.Size(120, 38);
            this.Customer_Read_Button.TabIndex = 49;
            this.Customer_Read_Button.Text = "Read";
            this.Customer_Read_Button.UseVisualStyleBackColor = false;
            this.Customer_Read_Button.Click += new System.EventHandler(this.Customer_Read_Button_Click);
            // 
            // Customer_Update_Button
            // 
            this.Customer_Update_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Customer_Update_Button.Location = new System.Drawing.Point(799, 182);
            this.Customer_Update_Button.Name = "Customer_Update_Button";
            this.Customer_Update_Button.Size = new System.Drawing.Size(120, 38);
            this.Customer_Update_Button.TabIndex = 50;
            this.Customer_Update_Button.Text = "Update";
            this.Customer_Update_Button.UseVisualStyleBackColor = false;
            this.Customer_Update_Button.Click += new System.EventHandler(this.Customer_Update_Button_Click);
            // 
            // Customer_Delete_Button
            // 
            this.Customer_Delete_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Customer_Delete_Button.Location = new System.Drawing.Point(941, 182);
            this.Customer_Delete_Button.Name = "Customer_Delete_Button";
            this.Customer_Delete_Button.Size = new System.Drawing.Size(120, 38);
            this.Customer_Delete_Button.TabIndex = 51;
            this.Customer_Delete_Button.Text = "Delete";
            this.Customer_Delete_Button.UseVisualStyleBackColor = false;
            this.Customer_Delete_Button.Click += new System.EventHandler(this.Customer_Delete_Button_Click);
            // 
            // Customer_FullName_TextBox
            // 
            this.Customer_FullName_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_FullName_TextBox.Location = new System.Drawing.Point(175, 38);
            this.Customer_FullName_TextBox.Name = "Customer_FullName_TextBox";
            this.Customer_FullName_TextBox.Size = new System.Drawing.Size(343, 30);
            this.Customer_FullName_TextBox.TabIndex = 52;
            this.Customer_FullName_TextBox.TextChanged += new System.EventHandler(this.Customer_FullName_TextBox_TextChanged);
            // 
            // Customer_ContactNumber_TextBox
            // 
            this.Customer_ContactNumber_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_ContactNumber_TextBox.Location = new System.Drawing.Point(175, 79);
            this.Customer_ContactNumber_TextBox.Name = "Customer_ContactNumber_TextBox";
            this.Customer_ContactNumber_TextBox.Size = new System.Drawing.Size(343, 30);
            this.Customer_ContactNumber_TextBox.TabIndex = 53;
            // 
            // Customer_Email_TextBox
            // 
            this.Customer_Email_TextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customer_Email_TextBox.Location = new System.Drawing.Point(175, 124);
            this.Customer_Email_TextBox.Name = "Customer_Email_TextBox";
            this.Customer_Email_TextBox.Size = new System.Drawing.Size(343, 30);
            this.Customer_Email_TextBox.TabIndex = 54;
            // 
            // Customer_Exit_Button
            // 
            this.Customer_Exit_Button.BackColor = System.Drawing.Color.Gainsboro;
            this.Customer_Exit_Button.Location = new System.Drawing.Point(1087, 182);
            this.Customer_Exit_Button.Name = "Customer_Exit_Button";
            this.Customer_Exit_Button.Size = new System.Drawing.Size(120, 38);
            this.Customer_Exit_Button.TabIndex = 55;
            this.Customer_Exit_Button.Text = "Exit";
            this.Customer_Exit_Button.UseVisualStyleBackColor = false;
            this.Customer_Exit_Button.Click += new System.EventHandler(this.Customer_Exit_Button_Click);
            // 
            // Customer_GroupBox
            // 
            this.Customer_GroupBox.BackColor = System.Drawing.Color.White;
            this.Customer_GroupBox.Controls.Add(this.Customer_Exit_Button);
            this.Customer_GroupBox.Controls.Add(this.Customer_FullName_Label);
            this.Customer_GroupBox.Controls.Add(this.Customer_ContactNumber_Label);
            this.Customer_GroupBox.Controls.Add(this.Customer_Email_TextBox);
            this.Customer_GroupBox.Controls.Add(this.Customer_Email_Label);
            this.Customer_GroupBox.Controls.Add(this.Customer_ContactNumber_TextBox);
            this.Customer_GroupBox.Controls.Add(this.Customer_Create_Button);
            this.Customer_GroupBox.Controls.Add(this.Customer_FullName_TextBox);
            this.Customer_GroupBox.Controls.Add(this.Customer_Read_Button);
            this.Customer_GroupBox.Controls.Add(this.Customer_Delete_Button);
            this.Customer_GroupBox.Controls.Add(this.Customer_Update_Button);
            this.Customer_GroupBox.Location = new System.Drawing.Point(3, 12);
            this.Customer_GroupBox.Name = "Customer_GroupBox";
            this.Customer_GroupBox.Size = new System.Drawing.Size(1213, 248);
            this.Customer_GroupBox.TabIndex = 57;
            this.Customer_GroupBox.TabStop = false;
            this.Customer_GroupBox.Text = "Customer Information";
            // 
            // Customer_DataGridView
            // 
            this.Customer_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Customer_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_DataGridView.Location = new System.Drawing.Point(3, 266);
            this.Customer_DataGridView.Name = "Customer_DataGridView";
            this.Customer_DataGridView.RowHeadersWidth = 51;
            this.Customer_DataGridView.Size = new System.Drawing.Size(1218, 512);
            this.Customer_DataGridView.TabIndex = 58;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 790);
            this.Controls.Add(this.Customer_DataGridView);
            this.Controls.Add(this.Customer_GroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagement";
            this.Customer_GroupBox.ResumeLayout(false);
            this.Customer_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Customer_FullName_Label;
        private System.Windows.Forms.Label Customer_ContactNumber_Label;
        private System.Windows.Forms.Label Customer_Email_Label;
        private System.Windows.Forms.Button Customer_Create_Button;
        private System.Windows.Forms.Button Customer_Read_Button;
        private System.Windows.Forms.Button Customer_Update_Button;
        private System.Windows.Forms.Button Customer_Delete_Button;
        private System.Windows.Forms.TextBox Customer_FullName_TextBox;
        private System.Windows.Forms.TextBox Customer_ContactNumber_TextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Customer_Exit_Button;
        private System.Windows.Forms.GroupBox Customer_GroupBox;
        private System.Windows.Forms.DataGridView Customer_DataGridView;
        private System.Windows.Forms.TextBox Customer_Email_TextBox;
    }
}