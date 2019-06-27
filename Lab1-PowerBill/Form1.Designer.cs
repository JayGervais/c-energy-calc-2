namespace Lab1_PowerBill
{
    partial class powerBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(powerBillForm));
            this.lblPowerBill = new System.Windows.Forms.Label();
            this.cboxCustType = new System.Windows.Forms.ComboBox();
            this.lblCustType = new System.Windows.Forms.Label();
            this.lblKwhUsed = new System.Windows.Forms.Label();
            this.txtKwhUsed = new System.Windows.Forms.TextBox();
            this.lblKwhIndustrial = new System.Windows.Forms.Label();
            this.txtOffPeakHours = new System.Windows.Forms.TextBox();
            this.lblOffPeakHours = new System.Windows.Forms.Label();
            this.txtPeakHours = new System.Windows.Forms.TextBox();
            this.lblPeakHours = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gBoxIndust = new System.Windows.Forms.GroupBox();
            this.gBKwhUsed = new System.Windows.Forms.GroupBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.txtCustomerTotal = new System.Windows.Forms.TextBox();
            this.lblCustomerTotal = new System.Windows.Forms.Label();
            this.gboxCustCharges = new System.Windows.Forms.GroupBox();
            this.txtTotalCharges = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtIndustTotal = new System.Windows.Forms.TextBox();
            this.lblIndusTotal = new System.Windows.Forms.Label();
            this.txtCommTotal = new System.Windows.Forms.TextBox();
            this.lblCommTotal = new System.Windows.Forms.Label();
            this.txtResTotal = new System.Windows.Forms.TextBox();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.btnRemoveCust = new System.Windows.Forms.Button();
            this.gBoxIndust.SuspendLayout();
            this.gBKwhUsed.SuspendLayout();
            this.gboxCustCharges.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPowerBill
            // 
            this.lblPowerBill.AutoSize = true;
            this.lblPowerBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerBill.Location = new System.Drawing.Point(36, 32);
            this.lblPowerBill.Name = "lblPowerBill";
            this.lblPowerBill.Size = new System.Drawing.Size(406, 39);
            this.lblPowerBill.TabIndex = 0;
            this.lblPowerBill.Text = "Energy Bill Calculations";
            // 
            // cboxCustType
            // 
            this.cboxCustType.FormattingEnabled = true;
            this.cboxCustType.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.cboxCustType.Location = new System.Drawing.Point(238, 128);
            this.cboxCustType.Name = "cboxCustType";
            this.cboxCustType.Size = new System.Drawing.Size(306, 37);
            this.cboxCustType.TabIndex = 1;
            this.cboxCustType.SelectedIndexChanged += new System.EventHandler(this.CboxCustType_SelectedIndexChanged);
            // 
            // lblCustType
            // 
            this.lblCustType.AutoSize = true;
            this.lblCustType.Location = new System.Drawing.Point(38, 131);
            this.lblCustType.Name = "lblCustType";
            this.lblCustType.Size = new System.Drawing.Size(178, 29);
            this.lblCustType.TabIndex = 2;
            this.lblCustType.Text = "Customer Type";
            // 
            // lblKwhUsed
            // 
            this.lblKwhUsed.AutoSize = true;
            this.lblKwhUsed.Location = new System.Drawing.Point(14, 74);
            this.lblKwhUsed.Name = "lblKwhUsed";
            this.lblKwhUsed.Size = new System.Drawing.Size(68, 29);
            this.lblKwhUsed.TabIndex = 3;
            this.lblKwhUsed.Text = "Total";
            // 
            // txtKwhUsed
            // 
            this.txtKwhUsed.Location = new System.Drawing.Point(214, 71);
            this.txtKwhUsed.Name = "txtKwhUsed";
            this.txtKwhUsed.Size = new System.Drawing.Size(306, 35);
            this.txtKwhUsed.TabIndex = 4;
            // 
            // lblKwhIndustrial
            // 
            this.lblKwhIndustrial.AutoSize = true;
            this.lblKwhIndustrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKwhIndustrial.Location = new System.Drawing.Point(11, 2);
            this.lblKwhIndustrial.Name = "lblKwhIndustrial";
            this.lblKwhIndustrial.Size = new System.Drawing.Size(131, 29);
            this.lblKwhIndustrial.TabIndex = 5;
            this.lblKwhIndustrial.Text = "kWh Used";
            // 
            // txtOffPeakHours
            // 
            this.txtOffPeakHours.Location = new System.Drawing.Point(213, 98);
            this.txtOffPeakHours.Name = "txtOffPeakHours";
            this.txtOffPeakHours.Size = new System.Drawing.Size(306, 35);
            this.txtOffPeakHours.TabIndex = 11;
            // 
            // lblOffPeakHours
            // 
            this.lblOffPeakHours.AutoSize = true;
            this.lblOffPeakHours.Location = new System.Drawing.Point(14, 101);
            this.lblOffPeakHours.Name = "lblOffPeakHours";
            this.lblOffPeakHours.Size = new System.Drawing.Size(177, 29);
            this.lblOffPeakHours.TabIndex = 10;
            this.lblOffPeakHours.Text = "Off-Peak Hours";
            // 
            // txtPeakHours
            // 
            this.txtPeakHours.Location = new System.Drawing.Point(213, 51);
            this.txtPeakHours.Name = "txtPeakHours";
            this.txtPeakHours.Size = new System.Drawing.Size(306, 35);
            this.txtPeakHours.TabIndex = 9;
            // 
            // lblPeakHours
            // 
            this.lblPeakHours.AutoSize = true;
            this.lblPeakHours.Location = new System.Drawing.Point(14, 54);
            this.lblPeakHours.Name = "lblPeakHours";
            this.lblPeakHours.Size = new System.Drawing.Size(138, 29);
            this.lblPeakHours.TabIndex = 8;
            this.lblPeakHours.Text = "Peak Hours";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(42, 549);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(196, 37);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "&Add Customer";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 549);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 37);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(425, 549);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 37);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // gBoxIndust
            // 
            this.gBoxIndust.Controls.Add(this.lblPeakHours);
            this.gBoxIndust.Controls.Add(this.txtOffPeakHours);
            this.gBoxIndust.Controls.Add(this.txtPeakHours);
            this.gBoxIndust.Controls.Add(this.lblOffPeakHours);
            this.gBoxIndust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gBoxIndust.Location = new System.Drawing.Point(24, 328);
            this.gBoxIndust.Name = "gBoxIndust";
            this.gBoxIndust.Size = new System.Drawing.Size(543, 159);
            this.gBoxIndust.TabIndex = 16;
            this.gBoxIndust.TabStop = false;
            this.gBoxIndust.Text = "kWh Used";
            // 
            // gBKwhUsed
            // 
            this.gBKwhUsed.Controls.Add(this.txtKwhUsed);
            this.gBKwhUsed.Controls.Add(this.lblKwhUsed);
            this.gBKwhUsed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gBKwhUsed.Location = new System.Drawing.Point(24, 328);
            this.gBKwhUsed.Name = "gBKwhUsed";
            this.gBKwhUsed.Size = new System.Drawing.Size(543, 159);
            this.gBKwhUsed.TabIndex = 17;
            this.gBKwhUsed.TabStop = false;
            this.gBKwhUsed.Text = "kWh Used";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(238, 184);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(306, 35);
            this.txtCustName.TabIndex = 19;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(38, 187);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(188, 29);
            this.lblCustName.TabIndex = 18;
            this.lblCustName.Text = "Customer Name";
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Location = new System.Drawing.Point(238, 239);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(306, 35);
            this.txtAcctNum.TabIndex = 21;
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Location = new System.Drawing.Point(38, 242);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(191, 29);
            this.lblAccountNum.TabIndex = 20;
            this.lblAccountNum.Text = "Account Number";
            // 
            // lstCustomer
            // 
            this.lstCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 20;
            this.lstCustomer.Location = new System.Drawing.Point(597, 32);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(426, 344);
            this.lstCustomer.TabIndex = 22;
            // 
            // txtCustomerTotal
            // 
            this.txtCustomerTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCustomerTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerTotal.Enabled = false;
            this.txtCustomerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCustomerTotal.HideSelection = false;
            this.txtCustomerTotal.Location = new System.Drawing.Point(337, 46);
            this.txtCustomerTotal.Name = "txtCustomerTotal";
            this.txtCustomerTotal.ReadOnly = true;
            this.txtCustomerTotal.Size = new System.Drawing.Size(80, 26);
            this.txtCustomerTotal.TabIndex = 24;
            this.txtCustomerTotal.TabStop = false;
            // 
            // lblCustomerTotal
            // 
            this.lblCustomerTotal.AutoSize = true;
            this.lblCustomerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCustomerTotal.Location = new System.Drawing.Point(245, 49);
            this.lblCustomerTotal.Name = "lblCustomerTotal";
            this.lblCustomerTotal.Size = new System.Drawing.Size(86, 20);
            this.lblCustomerTotal.TabIndex = 23;
            this.lblCustomerTotal.Text = "Customers";
            // 
            // gboxCustCharges
            // 
            this.gboxCustCharges.Controls.Add(this.txtTotalCharges);
            this.gboxCustCharges.Controls.Add(this.txtCustomerTotal);
            this.gboxCustCharges.Controls.Add(this.lblTotal);
            this.gboxCustCharges.Controls.Add(this.lblCustomerTotal);
            this.gboxCustCharges.Controls.Add(this.txtIndustTotal);
            this.gboxCustCharges.Controls.Add(this.lblIndusTotal);
            this.gboxCustCharges.Controls.Add(this.txtCommTotal);
            this.gboxCustCharges.Controls.Add(this.lblCommTotal);
            this.gboxCustCharges.Controls.Add(this.txtResTotal);
            this.gboxCustCharges.Controls.Add(this.lblResTotal);
            this.gboxCustCharges.Location = new System.Drawing.Point(597, 424);
            this.gboxCustCharges.Name = "gboxCustCharges";
            this.gboxCustCharges.Size = new System.Drawing.Size(426, 162);
            this.gboxCustCharges.TabIndex = 26;
            this.gboxCustCharges.TabStop = false;
            this.gboxCustCharges.Text = "Customer Charges";
            // 
            // txtTotalCharges
            // 
            this.txtTotalCharges.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtTotalCharges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalCharges.Enabled = false;
            this.txtTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCharges.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtTotalCharges.HideSelection = false;
            this.txtTotalCharges.Location = new System.Drawing.Point(249, 117);
            this.txtTotalCharges.Name = "txtTotalCharges";
            this.txtTotalCharges.ReadOnly = true;
            this.txtTotalCharges.Size = new System.Drawing.Size(168, 29);
            this.txtTotalCharges.TabIndex = 34;
            this.txtTotalCharges.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTotal.Location = new System.Drawing.Point(245, 94);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 20);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Total Charges:";
            // 
            // txtIndustTotal
            // 
            this.txtIndustTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtIndustTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIndustTotal.Enabled = false;
            this.txtIndustTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndustTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtIndustTotal.HideSelection = false;
            this.txtIndustTotal.Location = new System.Drawing.Point(105, 120);
            this.txtIndustTotal.Name = "txtIndustTotal";
            this.txtIndustTotal.ReadOnly = true;
            this.txtIndustTotal.Size = new System.Drawing.Size(130, 26);
            this.txtIndustTotal.TabIndex = 32;
            this.txtIndustTotal.TabStop = false;
            // 
            // lblIndusTotal
            // 
            this.lblIndusTotal.AutoSize = true;
            this.lblIndusTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndusTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblIndusTotal.Location = new System.Drawing.Point(6, 123);
            this.lblIndusTotal.Name = "lblIndusTotal";
            this.lblIndusTotal.Size = new System.Drawing.Size(74, 20);
            this.lblIndusTotal.TabIndex = 31;
            this.lblIndusTotal.Text = "Industrial";
            // 
            // txtCommTotal
            // 
            this.txtCommTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtCommTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommTotal.Enabled = false;
            this.txtCommTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtCommTotal.HideSelection = false;
            this.txtCommTotal.Location = new System.Drawing.Point(105, 83);
            this.txtCommTotal.Name = "txtCommTotal";
            this.txtCommTotal.ReadOnly = true;
            this.txtCommTotal.Size = new System.Drawing.Size(130, 26);
            this.txtCommTotal.TabIndex = 30;
            this.txtCommTotal.TabStop = false;
            // 
            // lblCommTotal
            // 
            this.lblCommTotal.AutoSize = true;
            this.lblCommTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCommTotal.Location = new System.Drawing.Point(6, 86);
            this.lblCommTotal.Name = "lblCommTotal";
            this.lblCommTotal.Size = new System.Drawing.Size(92, 20);
            this.lblCommTotal.TabIndex = 29;
            this.lblCommTotal.Text = "Commercial";
            // 
            // txtResTotal
            // 
            this.txtResTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtResTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResTotal.Enabled = false;
            this.txtResTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtResTotal.HideSelection = false;
            this.txtResTotal.Location = new System.Drawing.Point(105, 46);
            this.txtResTotal.Name = "txtResTotal";
            this.txtResTotal.ReadOnly = true;
            this.txtResTotal.Size = new System.Drawing.Size(130, 26);
            this.txtResTotal.TabIndex = 28;
            this.txtResTotal.TabStop = false;
            // 
            // lblResTotal
            // 
            this.lblResTotal.AutoSize = true;
            this.lblResTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblResTotal.Location = new System.Drawing.Point(6, 49);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(88, 20);
            this.lblResTotal.TabIndex = 27;
            this.lblResTotal.Text = "Residential";
            // 
            // btnRemoveCust
            // 
            this.btnRemoveCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCust.Location = new System.Drawing.Point(838, 381);
            this.btnRemoveCust.Name = "btnRemoveCust";
            this.btnRemoveCust.Size = new System.Drawing.Size(185, 37);
            this.btnRemoveCust.TabIndex = 27;
            this.btnRemoveCust.Text = "Remove Customer";
            this.btnRemoveCust.UseVisualStyleBackColor = true;
            this.btnRemoveCust.Click += new System.EventHandler(this.BtnRemoveCust_Click);
            // 
            // powerBillForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 616);
            this.Controls.Add(this.btnRemoveCust);
            this.Controls.Add(this.gboxCustCharges);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.txtAcctNum);
            this.Controls.Add(this.lblAccountNum);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.gBKwhUsed);
            this.Controls.Add(this.gBoxIndust);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCustType);
            this.Controls.Add(this.cboxCustType);
            this.Controls.Add(this.lblPowerBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "powerBillForm";
            this.Text = "CalculatePowerBill";
            this.Load += new System.EventHandler(this.PowerBillForm_Load);
            this.gBoxIndust.ResumeLayout(false);
            this.gBoxIndust.PerformLayout();
            this.gBKwhUsed.ResumeLayout(false);
            this.gBKwhUsed.PerformLayout();
            this.gboxCustCharges.ResumeLayout(false);
            this.gboxCustCharges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPowerBill;
        private System.Windows.Forms.ComboBox cboxCustType;
        private System.Windows.Forms.Label lblCustType;
        private System.Windows.Forms.Label lblKwhUsed;
        private System.Windows.Forms.TextBox txtKwhUsed;
        private System.Windows.Forms.TextBox txtOffPeakHours;
        private System.Windows.Forms.Label lblOffPeakHours;
        private System.Windows.Forms.TextBox txtPeakHours;
        private System.Windows.Forms.Label lblPeakHours;
        private System.Windows.Forms.Label lblKwhIndustrial;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gBoxIndust;
        private System.Windows.Forms.GroupBox gBKwhUsed;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtAcctNum;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.TextBox txtCustomerTotal;
        private System.Windows.Forms.Label lblCustomerTotal;
        private System.Windows.Forms.GroupBox gboxCustCharges;
        private System.Windows.Forms.TextBox txtTotalCharges;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtIndustTotal;
        private System.Windows.Forms.Label lblIndusTotal;
        private System.Windows.Forms.TextBox txtCommTotal;
        private System.Windows.Forms.Label lblCommTotal;
        private System.Windows.Forms.TextBox txtResTotal;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.Button btnRemoveCust;
    }

}

