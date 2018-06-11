namespace Programassign
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelPriceOfPostage = new System.Windows.Forms.Label();
            this.ListBoxPostage = new System.Windows.Forms.ListBox();
            this.LabelHandlingNotice = new System.Windows.Forms.Label();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.LabelHandlingCharge = new System.Windows.Forms.Label();
            this.TextBoxHandlingCharge = new System.Windows.Forms.TextBox();
            this.TextBoxPostageCharge = new System.Windows.Forms.TextBox();
            this.LabelPostageCharge = new System.Windows.Forms.Label();
            this.LabelOffer = new System.Windows.Forms.Label();
            this.LabelDiscount = new System.Windows.Forms.Label();
            this.TextBoxDiscount = new System.Windows.Forms.TextBox();
            this.ListBoxGender = new System.Windows.Forms.ListBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.LabelFinalCost = new System.Windows.Forms.Label();
            this.TextBoxFinalCost = new System.Windows.Forms.TextBox();
            this.TextBoxTotalPriceAfterVAT = new System.Windows.Forms.TextBox();
            this.TextBoxTotalPriceBeforeVAT = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.LabelVAT = new System.Windows.Forms.Label();
            this.LabelTotalPriceBeforeVAT = new System.Windows.Forms.Label();
            this.TextBoxCustomerNumber = new System.Windows.Forms.TextBox();
            this.TextBoxCustomerName = new System.Windows.Forms.TextBox();
            this.TextBoxNumberofDesktops = new System.Windows.Forms.TextBox();
            this.TextBoxNumberofLaptops = new System.Windows.Forms.TextBox();
            this.TextBoxNumberofServers = new System.Windows.Forms.TextBox();
            this.LabelNunberofDesktops = new System.Windows.Forms.Label();
            this.LabelNumberofLaptops = new System.Windows.Forms.Label();
            this.LabelNumberofServers = new System.Windows.Forms.Label();
            this.LabelSystemsRequest = new System.Windows.Forms.Label();
            this.ListBoxPriceOfSystems = new System.Windows.Forms.ListBox();
            this.LabelPriceOfSystems = new System.Windows.Forms.Label();
            this.ListBoxVATStatus = new System.Windows.Forms.ListBox();
            this.LabelVATStatus = new System.Windows.Forms.Label();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.LabelCustomerGender = new System.Windows.Forms.Label();
            this.LabelCustomerNumber = new System.Windows.Forms.Label();
            this.LabelCustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPriceOfPostage
            // 
            this.LabelPriceOfPostage.AutoSize = true;
            this.LabelPriceOfPostage.Location = new System.Drawing.Point(374, 502);
            this.LabelPriceOfPostage.Name = "LabelPriceOfPostage";
            this.LabelPriceOfPostage.Size = new System.Drawing.Size(85, 13);
            this.LabelPriceOfPostage.TabIndex = 75;
            this.LabelPriceOfPostage.Text = "Price of Postage";
            // 
            // ListBoxPostage
            // 
            this.ListBoxPostage.FormattingEnabled = true;
            this.ListBoxPostage.Items.AddRange(new object[] {
            "Server - £35",
            "Laptop - £30",
            "Desktop - £30"});
            this.ListBoxPostage.Location = new System.Drawing.Point(482, 502);
            this.ListBoxPostage.Name = "ListBoxPostage";
            this.ListBoxPostage.Size = new System.Drawing.Size(73, 43);
            this.ListBoxPostage.TabIndex = 74;
            // 
            // LabelHandlingNotice
            // 
            this.LabelHandlingNotice.Location = new System.Drawing.Point(173, 345);
            this.LabelHandlingNotice.Name = "LabelHandlingNotice";
            this.LabelHandlingNotice.Size = new System.Drawing.Size(132, 82);
            this.LabelHandlingNotice.TabIndex = 73;
            this.LabelHandlingNotice.Text = "Charities and Overseas Companies have a 10% Handling Charge";
            // 
            // ButtonReport
            // 
            this.ButtonReport.Location = new System.Drawing.Point(483, 438);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(129, 24);
            this.ButtonReport.TabIndex = 72;
            this.ButtonReport.Text = "Generate Report";
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click_1);
            // 
            // LabelHandlingCharge
            // 
            this.LabelHandlingCharge.Location = new System.Drawing.Point(480, 266);
            this.LabelHandlingCharge.Name = "LabelHandlingCharge";
            this.LabelHandlingCharge.Size = new System.Drawing.Size(152, 14);
            this.LabelHandlingCharge.TabIndex = 71;
            this.LabelHandlingCharge.Text = "Handling Charge";
            // 
            // TextBoxHandlingCharge
            // 
            this.TextBoxHandlingCharge.Location = new System.Drawing.Point(483, 285);
            this.TextBoxHandlingCharge.Name = "TextBoxHandlingCharge";
            this.TextBoxHandlingCharge.Size = new System.Drawing.Size(155, 20);
            this.TextBoxHandlingCharge.TabIndex = 70;
            this.TextBoxHandlingCharge.Text = "£";
            // 
            // TextBoxPostageCharge
            // 
            this.TextBoxPostageCharge.Location = new System.Drawing.Point(482, 233);
            this.TextBoxPostageCharge.Name = "TextBoxPostageCharge";
            this.TextBoxPostageCharge.Size = new System.Drawing.Size(155, 20);
            this.TextBoxPostageCharge.TabIndex = 69;
            this.TextBoxPostageCharge.Text = "£";
            // 
            // LabelPostageCharge
            // 
            this.LabelPostageCharge.Location = new System.Drawing.Point(479, 208);
            this.LabelPostageCharge.Name = "LabelPostageCharge";
            this.LabelPostageCharge.Size = new System.Drawing.Size(95, 22);
            this.LabelPostageCharge.TabIndex = 68;
            this.LabelPostageCharge.Text = "Postage Charge";
            // 
            // LabelOffer
            // 
            this.LabelOffer.Location = new System.Drawing.Point(35, 342);
            this.LabelOffer.Name = "LabelOffer";
            this.LabelOffer.Size = new System.Drawing.Size(132, 82);
            this.LabelOffer.TabIndex = 67;
            this.LabelOffer.Text = "Offer: If you purchase more than 20 systems you are entitled to a 10% discount!";
            // 
            // LabelDiscount
            // 
            this.LabelDiscount.Location = new System.Drawing.Point(479, 148);
            this.LabelDiscount.Name = "LabelDiscount";
            this.LabelDiscount.Size = new System.Drawing.Size(95, 22);
            this.LabelDiscount.TabIndex = 66;
            this.LabelDiscount.Text = "Discount";
            // 
            // TextBoxDiscount
            // 
            this.TextBoxDiscount.Location = new System.Drawing.Point(483, 173);
            this.TextBoxDiscount.Name = "TextBoxDiscount";
            this.TextBoxDiscount.Size = new System.Drawing.Size(155, 20);
            this.TextBoxDiscount.TabIndex = 65;
            this.TextBoxDiscount.Text = "£";
            // 
            // ListBoxGender
            // 
            this.ListBoxGender.FormattingEnabled = true;
            this.ListBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ListBoxGender.Location = new System.Drawing.Point(164, 171);
            this.ListBoxGender.Name = "ListBoxGender";
            this.ListBoxGender.Size = new System.Drawing.Size(118, 69);
            this.ListBoxGender.TabIndex = 64;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(482, 400);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(130, 24);
            this.ButtonCalculate.TabIndex = 63;
            this.ButtonCalculate.Text = "Calculate Cost";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelFinalCost
            // 
            this.LabelFinalCost.Location = new System.Drawing.Point(479, 321);
            this.LabelFinalCost.Name = "LabelFinalCost";
            this.LabelFinalCost.Size = new System.Drawing.Size(152, 14);
            this.LabelFinalCost.TabIndex = 62;
            this.LabelFinalCost.Text = "Final Cost";
            // 
            // TextBoxFinalCost
            // 
            this.TextBoxFinalCost.Location = new System.Drawing.Point(483, 342);
            this.TextBoxFinalCost.Name = "TextBoxFinalCost";
            this.TextBoxFinalCost.Size = new System.Drawing.Size(156, 20);
            this.TextBoxFinalCost.TabIndex = 61;
            this.TextBoxFinalCost.Text = "£";
            // 
            // TextBoxTotalPriceAfterVAT
            // 
            this.TextBoxTotalPriceAfterVAT.Location = new System.Drawing.Point(483, 107);
            this.TextBoxTotalPriceAfterVAT.Name = "TextBoxTotalPriceAfterVAT";
            this.TextBoxTotalPriceAfterVAT.Size = new System.Drawing.Size(156, 20);
            this.TextBoxTotalPriceAfterVAT.TabIndex = 60;
            this.TextBoxTotalPriceAfterVAT.Text = "£";
            // 
            // TextBoxTotalPriceBeforeVAT
            // 
            this.TextBoxTotalPriceBeforeVAT.Location = new System.Drawing.Point(483, 61);
            this.TextBoxTotalPriceBeforeVAT.Name = "TextBoxTotalPriceBeforeVAT";
            this.TextBoxTotalPriceBeforeVAT.Size = new System.Drawing.Size(156, 20);
            this.TextBoxTotalPriceBeforeVAT.TabIndex = 59;
            this.TextBoxTotalPriceBeforeVAT.Text = "£";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(483, 62);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(0, 13);
            this.Label12.TabIndex = 58;
            // 
            // LabelVAT
            // 
            this.LabelVAT.Location = new System.Drawing.Point(479, 89);
            this.LabelVAT.Name = "LabelVAT";
            this.LabelVAT.Size = new System.Drawing.Size(34, 15);
            this.LabelVAT.TabIndex = 57;
            this.LabelVAT.Text = "VAT";
            this.LabelVAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotalPriceBeforeVAT
            // 
            this.LabelTotalPriceBeforeVAT.Location = new System.Drawing.Point(480, 34);
            this.LabelTotalPriceBeforeVAT.Name = "LabelTotalPriceBeforeVAT";
            this.LabelTotalPriceBeforeVAT.Size = new System.Drawing.Size(152, 14);
            this.LabelTotalPriceBeforeVAT.TabIndex = 56;
            this.LabelTotalPriceBeforeVAT.Text = "Total price before VAT";
            // 
            // TextBoxCustomerNumber
            // 
            this.TextBoxCustomerNumber.Location = new System.Drawing.Point(164, 84);
            this.TextBoxCustomerNumber.Name = "TextBoxCustomerNumber";
            this.TextBoxCustomerNumber.Size = new System.Drawing.Size(208, 20);
            this.TextBoxCustomerNumber.TabIndex = 55;
            this.TextBoxCustomerNumber.Text = "Enter your number here...";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.Location = new System.Drawing.Point(164, 19);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(208, 20);
            this.TextBoxCustomerName.TabIndex = 54;
            this.TextBoxCustomerName.Text = "Enter your name here...";
            // 
            // TextBoxNumberofDesktops
            // 
            this.TextBoxNumberofDesktops.Location = new System.Drawing.Point(164, 602);
            this.TextBoxNumberofDesktops.Name = "TextBoxNumberofDesktops";
            this.TextBoxNumberofDesktops.Size = new System.Drawing.Size(208, 20);
            this.TextBoxNumberofDesktops.TabIndex = 53;
            this.TextBoxNumberofDesktops.Text = "0";
            // 
            // TextBoxNumberofLaptops
            // 
            this.TextBoxNumberofLaptops.Location = new System.Drawing.Point(164, 628);
            this.TextBoxNumberofLaptops.Name = "TextBoxNumberofLaptops";
            this.TextBoxNumberofLaptops.Size = new System.Drawing.Size(208, 20);
            this.TextBoxNumberofLaptops.TabIndex = 52;
            this.TextBoxNumberofLaptops.Text = "0";
            // 
            // TextBoxNumberofServers
            // 
            this.TextBoxNumberofServers.Location = new System.Drawing.Point(164, 578);
            this.TextBoxNumberofServers.Name = "TextBoxNumberofServers";
            this.TextBoxNumberofServers.Size = new System.Drawing.Size(208, 20);
            this.TextBoxNumberofServers.TabIndex = 51;
            this.TextBoxNumberofServers.Text = "0";
            // 
            // LabelNunberofDesktops
            // 
            this.LabelNunberofDesktops.Location = new System.Drawing.Point(35, 605);
            this.LabelNunberofDesktops.Name = "LabelNunberofDesktops";
            this.LabelNunberofDesktops.Size = new System.Drawing.Size(136, 27);
            this.LabelNunberofDesktops.TabIndex = 50;
            this.LabelNunberofDesktops.Text = "Number of Desktops";
            // 
            // LabelNumberofLaptops
            // 
            this.LabelNumberofLaptops.Location = new System.Drawing.Point(35, 632);
            this.LabelNumberofLaptops.Name = "LabelNumberofLaptops";
            this.LabelNumberofLaptops.Size = new System.Drawing.Size(136, 27);
            this.LabelNumberofLaptops.TabIndex = 49;
            this.LabelNumberofLaptops.Text = "Number of Laptops";
            // 
            // LabelNumberofServers
            // 
            this.LabelNumberofServers.Location = new System.Drawing.Point(35, 578);
            this.LabelNumberofServers.Name = "LabelNumberofServers";
            this.LabelNumberofServers.Size = new System.Drawing.Size(136, 27);
            this.LabelNumberofServers.TabIndex = 48;
            this.LabelNumberofServers.Text = "Number of Servers";
            // 
            // LabelSystemsRequest
            // 
            this.LabelSystemsRequest.Location = new System.Drawing.Point(35, 551);
            this.LabelSystemsRequest.Name = "LabelSystemsRequest";
            this.LabelSystemsRequest.Size = new System.Drawing.Size(136, 27);
            this.LabelSystemsRequest.TabIndex = 47;
            this.LabelSystemsRequest.Text = "Systems Request";
            // 
            // ListBoxPriceOfSystems
            // 
            this.ListBoxPriceOfSystems.FormattingEnabled = true;
            this.ListBoxPriceOfSystems.Items.AddRange(new object[] {
            "Server £999.99",
            "Desktop £322.99",
            "Laptop £201.99"});
            this.ListBoxPriceOfSystems.Location = new System.Drawing.Point(164, 449);
            this.ListBoxPriceOfSystems.Name = "ListBoxPriceOfSystems";
            this.ListBoxPriceOfSystems.Size = new System.Drawing.Size(90, 43);
            this.ListBoxPriceOfSystems.TabIndex = 46;
            // 
            // LabelPriceOfSystems
            // 
            this.LabelPriceOfSystems.AutoSize = true;
            this.LabelPriceOfSystems.Location = new System.Drawing.Point(35, 449);
            this.LabelPriceOfSystems.Name = "LabelPriceOfSystems";
            this.LabelPriceOfSystems.Size = new System.Drawing.Size(85, 13);
            this.LabelPriceOfSystems.TabIndex = 45;
            this.LabelPriceOfSystems.Text = "Price of Systems";
            // 
            // ListBoxVATStatus
            // 
            this.ListBoxVATStatus.FormattingEnabled = true;
            this.ListBoxVATStatus.Items.AddRange(new object[] {
            "Private",
            "UK Company",
            "Charity",
            "Overseas Company"});
            this.ListBoxVATStatus.Location = new System.Drawing.Point(164, 266);
            this.ListBoxVATStatus.Name = "ListBoxVATStatus";
            this.ListBoxVATStatus.Size = new System.Drawing.Size(124, 69);
            this.ListBoxVATStatus.TabIndex = 44;
            // 
            // LabelVATStatus
            // 
            this.LabelVATStatus.Location = new System.Drawing.Point(35, 266);
            this.LabelVATStatus.Name = "LabelVATStatus";
            this.LabelVATStatus.Size = new System.Drawing.Size(100, 23);
            this.LabelVATStatus.TabIndex = 43;
            this.LabelVATStatus.Text = "VAT Status";
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Location = new System.Drawing.Point(174, 223);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.RadioButtonFemale.TabIndex = 42;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Location = new System.Drawing.Point(174, 174);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonMale.TabIndex = 41;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // LabelCustomerGender
            // 
            this.LabelCustomerGender.Location = new System.Drawing.Point(35, 171);
            this.LabelCustomerGender.Name = "LabelCustomerGender";
            this.LabelCustomerGender.Size = new System.Drawing.Size(189, 59);
            this.LabelCustomerGender.TabIndex = 40;
            this.LabelCustomerGender.Text = "Customer Gender";
            // 
            // LabelCustomerNumber
            // 
            this.LabelCustomerNumber.Location = new System.Drawing.Point(35, 84);
            this.LabelCustomerNumber.Name = "LabelCustomerNumber";
            this.LabelCustomerNumber.Size = new System.Drawing.Size(189, 59);
            this.LabelCustomerNumber.TabIndex = 39;
            this.LabelCustomerNumber.Text = "Customer Number";
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.Location = new System.Drawing.Point(35, 19);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(189, 49);
            this.LabelCustomerName.TabIndex = 38;
            this.LabelCustomerName.Text = "Customer Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 666);
            this.Controls.Add(this.LabelPriceOfPostage);
            this.Controls.Add(this.ListBoxPostage);
            this.Controls.Add(this.LabelHandlingNotice);
            this.Controls.Add(this.ButtonReport);
            this.Controls.Add(this.LabelHandlingCharge);
            this.Controls.Add(this.TextBoxHandlingCharge);
            this.Controls.Add(this.TextBoxPostageCharge);
            this.Controls.Add(this.LabelPostageCharge);
            this.Controls.Add(this.LabelOffer);
            this.Controls.Add(this.LabelDiscount);
            this.Controls.Add(this.TextBoxDiscount);
            this.Controls.Add(this.ListBoxGender);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.LabelFinalCost);
            this.Controls.Add(this.TextBoxFinalCost);
            this.Controls.Add(this.TextBoxTotalPriceAfterVAT);
            this.Controls.Add(this.TextBoxTotalPriceBeforeVAT);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.LabelVAT);
            this.Controls.Add(this.LabelTotalPriceBeforeVAT);
            this.Controls.Add(this.TextBoxCustomerNumber);
            this.Controls.Add(this.TextBoxCustomerName);
            this.Controls.Add(this.TextBoxNumberofDesktops);
            this.Controls.Add(this.TextBoxNumberofLaptops);
            this.Controls.Add(this.TextBoxNumberofServers);
            this.Controls.Add(this.LabelNunberofDesktops);
            this.Controls.Add(this.LabelNumberofLaptops);
            this.Controls.Add(this.LabelNumberofServers);
            this.Controls.Add(this.LabelSystemsRequest);
            this.Controls.Add(this.ListBoxPriceOfSystems);
            this.Controls.Add(this.LabelPriceOfSystems);
            this.Controls.Add(this.ListBoxVATStatus);
            this.Controls.Add(this.LabelVATStatus);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.LabelCustomerGender);
            this.Controls.Add(this.LabelCustomerNumber);
            this.Controls.Add(this.LabelCustomerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(699, 705);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(699, 705);
            this.Name = "Form1";
            this.Text = "Main Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelPriceOfPostage;
        internal System.Windows.Forms.ListBox ListBoxPostage;
        internal System.Windows.Forms.Label LabelHandlingNotice;
        internal System.Windows.Forms.Button ButtonReport;
        internal System.Windows.Forms.Label LabelHandlingCharge;
        internal System.Windows.Forms.TextBox TextBoxHandlingCharge;
        internal System.Windows.Forms.TextBox TextBoxPostageCharge;
        internal System.Windows.Forms.Label LabelPostageCharge;
        internal System.Windows.Forms.Label LabelOffer;
        internal System.Windows.Forms.Label LabelDiscount;
        internal System.Windows.Forms.TextBox TextBoxDiscount;
        internal System.Windows.Forms.ListBox ListBoxGender;
        internal System.Windows.Forms.Button ButtonCalculate;
        internal System.Windows.Forms.Label LabelFinalCost;
        internal System.Windows.Forms.TextBox TextBoxFinalCost;
        internal System.Windows.Forms.TextBox TextBoxTotalPriceAfterVAT;
        internal System.Windows.Forms.TextBox TextBoxTotalPriceBeforeVAT;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label LabelVAT;
        internal System.Windows.Forms.Label LabelTotalPriceBeforeVAT;
        internal System.Windows.Forms.TextBox TextBoxCustomerNumber;
        internal System.Windows.Forms.TextBox TextBoxCustomerName;
        internal System.Windows.Forms.TextBox TextBoxNumberofDesktops;
        internal System.Windows.Forms.TextBox TextBoxNumberofLaptops;
        internal System.Windows.Forms.TextBox TextBoxNumberofServers;
        internal System.Windows.Forms.Label LabelNunberofDesktops;
        internal System.Windows.Forms.Label LabelNumberofLaptops;
        internal System.Windows.Forms.Label LabelNumberofServers;
        internal System.Windows.Forms.Label LabelSystemsRequest;
        internal System.Windows.Forms.ListBox ListBoxPriceOfSystems;
        internal System.Windows.Forms.Label LabelPriceOfSystems;
        internal System.Windows.Forms.ListBox ListBoxVATStatus;
        internal System.Windows.Forms.Label LabelVATStatus;
        internal System.Windows.Forms.RadioButton RadioButtonFemale;
        internal System.Windows.Forms.RadioButton RadioButtonMale;
        internal System.Windows.Forms.Label LabelCustomerGender;
        internal System.Windows.Forms.Label LabelCustomerNumber;
        internal System.Windows.Forms.Label LabelCustomerName;
    }
}

