namespace Programassign
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LabelDiscountOutput = new System.Windows.Forms.Label();
            this.LabelDiscount = new System.Windows.Forms.Label();
            this.LabelGenderOutput = new System.Windows.Forms.Label();
            this.LabelCustomerDetails = new System.Windows.Forms.Label();
            this.LabelCostDetails = new System.Windows.Forms.Label();
            this.LabelVATStatus = new System.Windows.Forms.Label();
            this.LabelVATStatusOutPut = new System.Windows.Forms.Label();
            this.LabelGender = new System.Windows.Forms.Label();
            this.LabelFinalCostOutPut = new System.Windows.Forms.Label();
            this.LabelHandlingChargeOutPut = new System.Windows.Forms.Label();
            this.LabelFinalCost = new System.Windows.Forms.Label();
            this.LabelHandlingCharge = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelCostBeforeVATOutPut = new System.Windows.Forms.Label();
            this.LabelVatOutPut = new System.Windows.Forms.Label();
            this.LabelPostageOutPut = new System.Windows.Forms.Label();
            this.LabelPostage = new System.Windows.Forms.Label();
            this.LabelCustomerNumberOutput = new System.Windows.Forms.Label();
            this.LabelCustomerNameOutPut = new System.Windows.Forms.Label();
            this.LabelCustomerName = new System.Windows.Forms.Label();
            this.LabelTransactionDetails = new System.Windows.Forms.Label();
            this.LabelCustomerNumber = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.SuspendLayout();
            // 
            // LabelDiscountOutput
            // 
            this.LabelDiscountOutput.AutoEllipsis = true;
            this.LabelDiscountOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelDiscountOutput.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelDiscountOutput.Location = new System.Drawing.Point(224, 424);
            this.LabelDiscountOutput.Name = "LabelDiscountOutput";
            this.LabelDiscountOutput.Size = new System.Drawing.Size(360, 34);
            this.LabelDiscountOutput.TabIndex = 46;
            this.LabelDiscountOutput.Click += new System.EventHandler(this.LabelDiscountOutput_Click);
            // 
            // LabelDiscount
            // 
            this.LabelDiscount.AutoEllipsis = true;
            this.LabelDiscount.AutoSize = true;
            this.LabelDiscount.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDiscount.ForeColor = System.Drawing.Color.Black;
            this.LabelDiscount.Location = new System.Drawing.Point(4, 419);
            this.LabelDiscount.Name = "LabelDiscount";
            this.LabelDiscount.Size = new System.Drawing.Size(86, 25);
            this.LabelDiscount.TabIndex = 45;
            this.LabelDiscount.Text = "Discount:";
            // 
            // LabelGenderOutput
            // 
            this.LabelGenderOutput.AutoEllipsis = true;
            this.LabelGenderOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelGenderOutput.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelGenderOutput.Location = new System.Drawing.Point(229, 532);
            this.LabelGenderOutput.Name = "LabelGenderOutput";
            this.LabelGenderOutput.Size = new System.Drawing.Size(360, 34);
            this.LabelGenderOutput.TabIndex = 44;
            // 
            // LabelCustomerDetails
            // 
            this.LabelCustomerDetails.AutoSize = true;
            this.LabelCustomerDetails.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerDetails.Location = new System.Drawing.Point(222, 473);
            this.LabelCustomerDetails.Name = "LabelCustomerDetails";
            this.LabelCustomerDetails.Size = new System.Drawing.Size(228, 39);
            this.LabelCustomerDetails.TabIndex = 43;
            this.LabelCustomerDetails.Text = "Customer Details";
            // 
            // LabelCostDetails
            // 
            this.LabelCostDetails.AutoSize = true;
            this.LabelCostDetails.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCostDetails.Location = new System.Drawing.Point(221, 64);
            this.LabelCostDetails.Name = "LabelCostDetails";
            this.LabelCostDetails.Size = new System.Drawing.Size(195, 45);
            this.LabelCostDetails.TabIndex = 42;
            this.LabelCostDetails.Text = "Cost Details";
            // 
            // LabelVATStatus
            // 
            this.LabelVATStatus.AutoSize = true;
            this.LabelVATStatus.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVATStatus.Location = new System.Drawing.Point(4, 580);
            this.LabelVATStatus.Name = "LabelVATStatus";
            this.LabelVATStatus.Size = new System.Drawing.Size(109, 25);
            this.LabelVATStatus.TabIndex = 41;
            this.LabelVATStatus.Text = "VAT Status:";
            // 
            // LabelVATStatusOutPut
            // 
            this.LabelVATStatusOutPut.AutoEllipsis = true;
            this.LabelVATStatusOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelVATStatusOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelVATStatusOutPut.Location = new System.Drawing.Point(229, 587);
            this.LabelVATStatusOutPut.Name = "LabelVATStatusOutPut";
            this.LabelVATStatusOutPut.Size = new System.Drawing.Size(360, 34);
            this.LabelVATStatusOutPut.TabIndex = 40;
            this.LabelVATStatusOutPut.Click += new System.EventHandler(this.LabelVATStatusOutPut_Click);
            // 
            // LabelGender
            // 
            this.LabelGender.AutoEllipsis = true;
            this.LabelGender.AutoSize = true;
            this.LabelGender.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGender.Location = new System.Drawing.Point(4, 525);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(69, 25);
            this.LabelGender.TabIndex = 39;
            this.LabelGender.Text = "Gender:";
            // 
            // LabelFinalCostOutPut
            // 
            this.LabelFinalCostOutPut.AutoEllipsis = true;
            this.LabelFinalCostOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelFinalCostOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelFinalCostOutPut.Location = new System.Drawing.Point(224, 364);
            this.LabelFinalCostOutPut.Name = "LabelFinalCostOutPut";
            this.LabelFinalCostOutPut.Size = new System.Drawing.Size(360, 34);
            this.LabelFinalCostOutPut.TabIndex = 38;
            this.LabelFinalCostOutPut.Click += new System.EventHandler(this.LabelFinalCostOutPut_Click);
            // 
            // LabelHandlingChargeOutPut
            // 
            this.LabelHandlingChargeOutPut.AutoEllipsis = true;
            this.LabelHandlingChargeOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelHandlingChargeOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelHandlingChargeOutPut.Location = new System.Drawing.Point(224, 298);
            this.LabelHandlingChargeOutPut.Name = "LabelHandlingChargeOutPut";
            this.LabelHandlingChargeOutPut.Size = new System.Drawing.Size(360, 34);
            this.LabelHandlingChargeOutPut.TabIndex = 37;
            this.LabelHandlingChargeOutPut.Click += new System.EventHandler(this.LabelHandlingChargeOutPut_Click);
            // 
            // LabelFinalCost
            // 
            this.LabelFinalCost.AutoEllipsis = true;
            this.LabelFinalCost.AutoSize = true;
            this.LabelFinalCost.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFinalCost.ForeColor = System.Drawing.Color.Black;
            this.LabelFinalCost.Location = new System.Drawing.Point(4, 359);
            this.LabelFinalCost.Name = "LabelFinalCost";
            this.LabelFinalCost.Size = new System.Drawing.Size(96, 25);
            this.LabelFinalCost.TabIndex = 36;
            this.LabelFinalCost.Text = "Final Cost:";
            // 
            // LabelHandlingCharge
            // 
            this.LabelHandlingCharge.AutoEllipsis = true;
            this.LabelHandlingCharge.AutoSize = true;
            this.LabelHandlingCharge.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHandlingCharge.ForeColor = System.Drawing.Color.Black;
            this.LabelHandlingCharge.Location = new System.Drawing.Point(4, 293);
            this.LabelHandlingCharge.Name = "LabelHandlingCharge";
            this.LabelHandlingCharge.Size = new System.Drawing.Size(142, 25);
            this.LabelHandlingCharge.TabIndex = 35;
            this.LabelHandlingCharge.Text = "Handling Charge:";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoEllipsis = true;
            this.LabelCost.AutoSize = true;
            this.LabelCost.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCost.Location = new System.Drawing.Point(4, 113);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(91, 25);
            this.LabelCost.TabIndex = 34;
            this.LabelCost.Text = "Raw Cost:";
            // 
            // Label1
            // 
            this.Label1.AutoEllipsis = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(4, 234);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 25);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "VAT Charge:";
            // 
            // LabelCostBeforeVATOutPut
            // 
            this.LabelCostBeforeVATOutPut.AutoEllipsis = true;
            this.LabelCostBeforeVATOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCostBeforeVATOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelCostBeforeVATOutPut.Location = new System.Drawing.Point(224, 118);
            this.LabelCostBeforeVATOutPut.Name = "LabelCostBeforeVATOutPut";
            this.LabelCostBeforeVATOutPut.Size = new System.Drawing.Size(360, 34);
            this.LabelCostBeforeVATOutPut.TabIndex = 32;
            // 
            // LabelVatOutPut
            // 
            this.LabelVatOutPut.AutoEllipsis = true;
            this.LabelVatOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelVatOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelVatOutPut.Location = new System.Drawing.Point(224, 249);
            this.LabelVatOutPut.Name = "LabelVatOutPut";
            this.LabelVatOutPut.Size = new System.Drawing.Size(360, 34);
            this.LabelVatOutPut.TabIndex = 31;
            this.LabelVatOutPut.Click += new System.EventHandler(this.LabelVatOutPut_Click);
            // 
            // LabelPostageOutPut
            // 
            this.LabelPostageOutPut.AutoEllipsis = true;
            this.LabelPostageOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelPostageOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelPostageOutPut.Location = new System.Drawing.Point(224, 185);
            this.LabelPostageOutPut.Name = "LabelPostageOutPut";
            this.LabelPostageOutPut.Size = new System.Drawing.Size(360, 34);
            this.LabelPostageOutPut.TabIndex = 30;
            this.LabelPostageOutPut.Click += new System.EventHandler(this.LabelPostageOutPut_Click);
            // 
            // LabelPostage
            // 
            this.LabelPostage.AutoEllipsis = true;
            this.LabelPostage.AutoSize = true;
            this.LabelPostage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPostage.Location = new System.Drawing.Point(4, 170);
            this.LabelPostage.Name = "LabelPostage";
            this.LabelPostage.Size = new System.Drawing.Size(130, 25);
            this.LabelPostage.TabIndex = 29;
            this.LabelPostage.Text = "Postage Charge:";
            // 
            // LabelCustomerNumberOutput
            // 
            this.LabelCustomerNumberOutput.AutoEllipsis = true;
            this.LabelCustomerNumberOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCustomerNumberOutput.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelCustomerNumberOutput.Location = new System.Drawing.Point(229, 655);
            this.LabelCustomerNumberOutput.Name = "LabelCustomerNumberOutput";
            this.LabelCustomerNumberOutput.Size = new System.Drawing.Size(360, 34);
            this.LabelCustomerNumberOutput.TabIndex = 28;
            this.LabelCustomerNumberOutput.Click += new System.EventHandler(this.LabelCustomerNumberOutput_Click);
            // 
            // LabelCustomerNameOutPut
            // 
            this.LabelCustomerNameOutPut.AutoEllipsis = true;
            this.LabelCustomerNameOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCustomerNameOutPut.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.LabelCustomerNameOutPut.Location = new System.Drawing.Point(229, 709);
            this.LabelCustomerNameOutPut.Name = "LabelCustomerNameOutPut";
            this.LabelCustomerNameOutPut.Size = new System.Drawing.Size(360, 34);
            this.LabelCustomerNameOutPut.TabIndex = 26;
            this.LabelCustomerNameOutPut.Click += new System.EventHandler(this.LabelCustomerNameOutPut_Click);
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoEllipsis = true;
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerName.ForeColor = System.Drawing.Color.Black;
            this.LabelCustomerName.Location = new System.Drawing.Point(-1, 704);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(135, 25);
            this.LabelCustomerName.TabIndex = 25;
            this.LabelCustomerName.Text = "Customer Name:";
            // 
            // LabelTransactionDetails
            // 
            this.LabelTransactionDetails.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTransactionDetails.Location = new System.Drawing.Point(122, 9);
            this.LabelTransactionDetails.Name = "LabelTransactionDetails";
            this.LabelTransactionDetails.Size = new System.Drawing.Size(390, 68);
            this.LabelTransactionDetails.TabIndex = 24;
            this.LabelTransactionDetails.Text = "Transaction Details";
            // 
            // LabelCustomerNumber
            // 
            this.LabelCustomerNumber.AutoEllipsis = true;
            this.LabelCustomerNumber.AutoSize = true;
            this.LabelCustomerNumber.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerNumber.Location = new System.Drawing.Point(0, 648);
            this.LabelCustomerNumber.Name = "LabelCustomerNumber";
            this.LabelCustomerNumber.Size = new System.Drawing.Size(151, 25);
            this.LabelCustomerNumber.TabIndex = 27;
            this.LabelCustomerNumber.Text = "Customer Number:";
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(244, 767);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 47;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrintForm1
            // 
            this.PrintForm1.DocumentName = "document";
            this.PrintForm1.Form = this;
            this.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.PrintForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("PrintForm1.PrinterSettings")));
            this.PrintForm1.PrintFileName = null;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 818);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.LabelDiscountOutput);
            this.Controls.Add(this.LabelDiscount);
            this.Controls.Add(this.LabelGenderOutput);
            this.Controls.Add(this.LabelCustomerDetails);
            this.Controls.Add(this.LabelCostDetails);
            this.Controls.Add(this.LabelVATStatus);
            this.Controls.Add(this.LabelVATStatusOutPut);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.LabelFinalCostOutPut);
            this.Controls.Add(this.LabelHandlingChargeOutPut);
            this.Controls.Add(this.LabelFinalCost);
            this.Controls.Add(this.LabelHandlingCharge);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabelCostBeforeVATOutPut);
            this.Controls.Add(this.LabelVatOutPut);
            this.Controls.Add(this.LabelPostageOutPut);
            this.Controls.Add(this.LabelPostage);
            this.Controls.Add(this.LabelCustomerNumberOutput);
            this.Controls.Add(this.LabelCustomerNameOutPut);
            this.Controls.Add(this.LabelCustomerName);
            this.Controls.Add(this.LabelTransactionDetails);
            this.Controls.Add(this.LabelCustomerNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 857);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(795, 857);
            this.Name = "Form2";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelDiscountOutput;
        internal System.Windows.Forms.Label LabelDiscount;
        internal System.Windows.Forms.Label LabelGenderOutput;
        internal System.Windows.Forms.Label LabelCustomerDetails;
        internal System.Windows.Forms.Label LabelCostDetails;
        internal System.Windows.Forms.Label LabelVATStatus;
        internal System.Windows.Forms.Label LabelVATStatusOutPut;
        internal System.Windows.Forms.Label LabelGender;
        internal System.Windows.Forms.Label LabelFinalCostOutPut;
        internal System.Windows.Forms.Label LabelHandlingChargeOutPut;
        internal System.Windows.Forms.Label LabelFinalCost;
        internal System.Windows.Forms.Label LabelHandlingCharge;
        internal System.Windows.Forms.Label LabelCost;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabelCostBeforeVATOutPut;
        internal System.Windows.Forms.Label LabelVatOutPut;
        internal System.Windows.Forms.Label LabelPostageOutPut;
        internal System.Windows.Forms.Label LabelPostage;
        internal System.Windows.Forms.Label LabelCustomerNumberOutput;
        internal System.Windows.Forms.Label LabelCustomerNameOutPut;
        internal System.Windows.Forms.Label LabelCustomerName;
        internal System.Windows.Forms.Label LabelTransactionDetails;
        internal System.Windows.Forms.Label LabelCustomerNumber;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        internal Microsoft.VisualBasic.PowerPacks.Printing.PrintForm PrintForm1;
    }
}