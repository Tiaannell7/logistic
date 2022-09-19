
namespace CtuLogistics
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.LinkToAddresses = new System.Windows.Forms.Button();
            this.LinkToCustomers = new System.Windows.Forms.Button();
            this.LinkToFreight = new System.Windows.Forms.Button();
            this.LinkToDrivers = new System.Windows.Forms.Button();
            this.AppExit = new System.Windows.Forms.Button();
            this.LinkToStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkToAddresses
            // 
            this.LinkToAddresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinkToAddresses.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.LinkToAddresses.ForeColor = System.Drawing.Color.Black;
            this.LinkToAddresses.Image = ((System.Drawing.Image)(resources.GetObject("LinkToAddresses.Image")));
            this.LinkToAddresses.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinkToAddresses.Location = new System.Drawing.Point(97, 137);
            this.LinkToAddresses.Name = "LinkToAddresses";
            this.LinkToAddresses.Size = new System.Drawing.Size(179, 80);
            this.LinkToAddresses.TabIndex = 0;
            this.LinkToAddresses.Text = "Manage Address";
            this.LinkToAddresses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToAddresses.UseMnemonic = false;
            this.LinkToAddresses.UseVisualStyleBackColor = false;
            this.LinkToAddresses.Click += new System.EventHandler(this.LinkToAddresses_Click);
            // 
            // LinkToCustomers
            // 
            this.LinkToCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinkToCustomers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.LinkToCustomers.ForeColor = System.Drawing.Color.Black;
            this.LinkToCustomers.Image = global::CtuLogistics.Properties.Resources.icons8_customer_32;
            this.LinkToCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinkToCustomers.Location = new System.Drawing.Point(321, 137);
            this.LinkToCustomers.Name = "LinkToCustomers";
            this.LinkToCustomers.Size = new System.Drawing.Size(179, 80);
            this.LinkToCustomers.TabIndex = 1;
            this.LinkToCustomers.Text = "Manage Customer";
            this.LinkToCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToCustomers.UseMnemonic = false;
            this.LinkToCustomers.UseVisualStyleBackColor = false;
            this.LinkToCustomers.Click += new System.EventHandler(this.LinkToCustomers_Click);
            // 
            // LinkToFreight
            // 
            this.LinkToFreight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinkToFreight.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.LinkToFreight.ForeColor = System.Drawing.Color.Black;
            this.LinkToFreight.Image = global::CtuLogistics.Properties.Resources.icons8_trolley_32;
            this.LinkToFreight.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinkToFreight.Location = new System.Drawing.Point(546, 137);
            this.LinkToFreight.Name = "LinkToFreight";
            this.LinkToFreight.Size = new System.Drawing.Size(179, 80);
            this.LinkToFreight.TabIndex = 2;
            this.LinkToFreight.Text = "Manage Freight";
            this.LinkToFreight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToFreight.UseMnemonic = false;
            this.LinkToFreight.UseVisualStyleBackColor = false;
            this.LinkToFreight.Click += new System.EventHandler(this.LinkToFreight_Click);
            // 
            // LinkToDrivers
            // 
            this.LinkToDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinkToDrivers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.LinkToDrivers.ForeColor = System.Drawing.Color.Black;
            this.LinkToDrivers.Image = global::CtuLogistics.Properties.Resources.icons8_driver_32;
            this.LinkToDrivers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinkToDrivers.Location = new System.Drawing.Point(97, 238);
            this.LinkToDrivers.Name = "LinkToDrivers";
            this.LinkToDrivers.Size = new System.Drawing.Size(179, 80);
            this.LinkToDrivers.TabIndex = 3;
            this.LinkToDrivers.Text = "Manage Drivers";
            this.LinkToDrivers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToDrivers.UseMnemonic = false;
            this.LinkToDrivers.UseVisualStyleBackColor = false;
            this.LinkToDrivers.Click += new System.EventHandler(this.LinkToDrivers_Click);
            // 
            // AppExit
            // 
            this.AppExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AppExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AppExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AppExit.ForeColor = System.Drawing.Color.Black;
            this.AppExit.Image = global::CtuLogistics.Properties.Resources.icons8_exit_32;
            this.AppExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AppExit.Location = new System.Drawing.Point(546, 238);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(179, 80);
            this.AppExit.TabIndex = 4;
            this.AppExit.Text = "Exit";
            this.AppExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AppExit.UseMnemonic = false;
            this.AppExit.UseVisualStyleBackColor = false;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // LinkToStatus
            // 
            this.LinkToStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LinkToStatus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.LinkToStatus.ForeColor = System.Drawing.Color.Black;
            this.LinkToStatus.Image = global::CtuLogistics.Properties.Resources.icons8_double_down_32;
            this.LinkToStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinkToStatus.Location = new System.Drawing.Point(321, 238);
            this.LinkToStatus.Name = "LinkToStatus";
            this.LinkToStatus.Size = new System.Drawing.Size(179, 80);
            this.LinkToStatus.TabIndex = 5;
            this.LinkToStatus.Text = "Manage Status";
            this.LinkToStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LinkToStatus.UseMnemonic = false;
            this.LinkToStatus.UseVisualStyleBackColor = false;
            this.LinkToStatus.Click += new System.EventHandler(this.LinkToStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome To CTU Logistics";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LinkToStatus);
            this.Controls.Add(this.AppExit);
            this.Controls.Add(this.LinkToDrivers);
            this.Controls.Add(this.LinkToFreight);
            this.Controls.Add(this.LinkToCustomers);
            this.Controls.Add(this.LinkToAddresses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTU Logistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LinkToAddresses;
        private System.Windows.Forms.Button LinkToCustomers;
        private System.Windows.Forms.Button LinkToFreight;
        private System.Windows.Forms.Button LinkToDrivers;
        private System.Windows.Forms.Button AppExit;
        private System.Windows.Forms.Button LinkToStatus;
        private System.Windows.Forms.Label label1;
    }
}

