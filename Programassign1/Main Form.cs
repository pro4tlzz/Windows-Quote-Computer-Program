using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Programassign
{    
    public partial class Form1 : Form
    {
        
        string CustomerName;
        string CustomerNumber;
        // DECLARE TOTALS AND SUBTOTALS DECLARES PRICES VAT
        double CostServer = 999.99;
        double CostDesktop = 322.99;
        double CostLaptop = 201.99;
        double Total;
        double SubTotalServer;
        double SubTotalDesktop;
        double SubTotalLaptop;
        double VAT;
        double VATUKandPrivateonly;
        // CREATE THE VARIABLES FOR THE AMOUNT OF COMPUTER SYSTEM OF EACH SORT BROUGHT
        int AmountServer;
        int AmountDesktop;
        int AmountLaptop;
        double Discount;
        // CREATE THE VARIABLES FOR POSTAGE
        double PostageServer = 35;
        double PostageDesktop = 30;
        double PostageLaptop = 30;
        double HandlingCharge;
        double SubTotalPostageServer;
        double SubTotalPostageDesktop;
        double SubTotalPostageLaptop;
        double FinalPostageTotal;
        public static string PassText;
        
        public Form1()
        {


            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {




            // PUT THE NUMBER OF PCS BOUGHT INTO THE VARIABLES, block errors
            try
            {


                AmountServer = Int32.Parse(TextBoxNumberofServers.Text);
                AmountDesktop = Int32.Parse(TextBoxNumberofDesktops.Text);
                AmountLaptop = Int32.Parse(TextBoxNumberofLaptops.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter a numerical value into this box");
            }


     
            // WORK OUT SUBTOTALS FOR EACH TYPE OF COMPUTER SYSTEM AND POSTAGE
            SubTotalServer = CostServer * AmountServer;
            SubTotalDesktop = CostDesktop * AmountDesktop;
            SubTotalLaptop = CostLaptop * AmountLaptop;
            SubTotalPostageServer = PostageServer * AmountServer;
            SubTotalPostageLaptop = PostageLaptop * AmountLaptop;
            SubTotalPostageDesktop = PostageDesktop * AmountDesktop;
            FinalPostageTotal = SubTotalPostageDesktop + SubTotalPostageLaptop + SubTotalPostageServer;
            // WORK OUT TOTAL AND VAT AND HANDLING CHARGE


            Total = SubTotalServer + SubTotalDesktop + SubTotalLaptop;
            VAT = Total * 0.2;
            VATUKandPrivateonly = (Total + FinalPostageTotal) * 0.2;
            // handling charge contains postage
            HandlingCharge = Total * 0.1;



            // CREATES SELECTION, USED FOR OUTPUTTING VAT separately FROM FINAL COST, rounds up cost and assigns currency, calculates discounts
            if (ListBoxVATStatus.SelectedItem == "Private")
            {
                TextBoxTotalPriceAfterVAT.Text = "£" + Math.Round(VAT, 2);
                TextBoxTotalPriceBeforeVAT.Text = "£" + Math.Round(Total, 2);
                // Me.TextBoxFinalCost.Text = "£" & Math.Round(VAT + Total + FinalPostageTotal, 2)
                TextBoxHandlingCharge.Text = "£" + 0;
                TextBoxPostageCharge.Text = "£" + Math.Round(FinalPostageTotal, 2);
            }

            // sets condition for Private to be set alongside discount, more than 20 have to be bough to trigger this selection
            if (ListBoxVATStatus.SelectedItem == "Private" & AmountServer + AmountDesktop + AmountLaptop >= 20)
            {
                TextBoxFinalCost.Text = "£" + Math.Round((Total + VAT + FinalPostageTotal), 2) * 0.9;
                Discount = Total * 0.9;
                TextBoxDiscount.Text = "£" + Math.Round((Total + VAT + FinalPostageTotal), 2) * 0.1;
                TextBoxHandlingCharge.Text = "£" + 0;
                TextBoxPostageCharge.Text = "£" + Math.Round(FinalPostageTotal, 2);
            }
            else if (ListBoxVATStatus.SelectedItem == "Private" & AmountDesktop + AmountServer + AmountLaptop <= 19)
            {
                TextBoxFinalCost.Text = "£" + Math.Round((Total + VAT + FinalPostageTotal), 2);
                TextBoxDiscount.Text = "£" + 0;
                TextBoxHandlingCharge.Text = "£" + 0;
                TextBoxPostageCharge.Text = "£" + Math.Round(FinalPostageTotal, 2);
            }

            // selection for uk company, no handling charge or discount required

            if (ListBoxVATStatus.SelectedItem == "UK Company")
            {
                TextBoxTotalPriceAfterVAT.Text = "£" + Math.Round(VAT, 2);
                TextBoxFinalCost.Text = "£" + Math.Round(VAT + Total + FinalPostageTotal, 2);
                TextBoxTotalPriceBeforeVAT.Text = "£" + Math.Round(Total, 2);
                TextBoxDiscount.Text = ("£" + 0);
                TextBoxHandlingCharge.Text = "£" + 0;
                TextBoxPostageCharge.Text = "£" + Math.Round(FinalPostageTotal, 2);
            }
            // selection for charity, calculates total, handling charge and discount
            if (ListBoxVATStatus.SelectedItem == "Charity")
            {
                TextBoxTotalPriceBeforeVAT.Text = "£" + Math.Round(Total, 2);
                TextBoxFinalCost.Text = "£" + Math.Round(Total + HandlingCharge + FinalPostageTotal, 2);
                TextBoxTotalPriceAfterVAT.Text = "£" + 0;
                TextBoxPostageCharge.Text = "£" + Math.Round(FinalPostageTotal, 2);
                TextBoxHandlingCharge.Text = "£" + Math.Round(HandlingCharge);
            }

            // activates selection if charity is selected and more than 20 pcs required, adds 10% discount
            if (ListBoxVATStatus.SelectedItem == "Charity" & AmountDesktop + AmountLaptop + AmountServer >= 20)
            {
                TextBoxFinalCost.Text = "£" + Math.Round((Total + HandlingCharge + FinalPostageTotal), 2) * 0.9;
                Discount = Total * 0.9;
                TextBoxDiscount.Text = "£" + Math.Round((Total + HandlingCharge + FinalPostageTotal), 2) * 0.1;
                TextBoxHandlingCharge.Text = "£" + Math.Round(HandlingCharge, 2);
                TextBoxPostageCharge.Text = "£" + Math.Round(FinalPostageTotal, 2);
            }
            else if (ListBoxVATStatus.SelectedItem == "Charity" & AmountDesktop + AmountServer + AmountLaptop <= 19)
            {
                TextBoxFinalCost.Text = "£" + Math.Round((Total + HandlingCharge + FinalPostageTotal), 2);
                TextBoxDiscount.Text = "£" + (0);
                TextBoxHandlingCharge.Text = "£" + Math.Round(HandlingCharge, 2) + "0";
                TextBoxPostageCharge.Text = "£" + Math.Round(FinalPostageTotal, 2);
            }
            // activates selection if overseas company is selected and does not add 10% discount, total vat postage and handling charge calculated
            if (ListBoxVATStatus.SelectedItem == "Overseas Company")
            {
                TextBoxTotalPriceBeforeVAT.Text = "£" + Math.Round(Total, 2);
                TextBoxFinalCost.Text = "£" + Math.Round(Total + HandlingCharge + FinalPostageTotal, 2);
                TextBoxTotalPriceAfterVAT.Text = "£" + 0;
                TextBoxDiscount.Text = "£" + 0;
                TextBoxPostageCharge.Text = "£" + Math.Round(FinalPostageTotal, 2);
                TextBoxHandlingCharge.Text = "£" + Math.Round(HandlingCharge, 2) + "0";
            }
            
   
           
        }



       

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //default selection
            ListBoxVATStatus.SelectedIndex = 0;
            ListBoxGender.SelectedIndex = 0;
            ListBoxPostage.SelectedIndex = 0;
        }

        private void ButtonReport_Click_1(object sender, EventArgs e)
        {
            //opens new form
            this.Hide();
            Form2 f2 = new Form2(TextBoxCustomerName.Text, TextBoxCustomerNumber.Text,
                ListBoxGender.Text,  TextBoxDiscount.Text, 
                TextBoxFinalCost.Text, TextBoxHandlingCharge.Text,
                TextBoxPostageCharge.Text, TextBoxTotalPriceAfterVAT.Text,
                TextBoxTotalPriceBeforeVAT.Text, ListBoxVATStatus.Text);
            f2.Show();
        }
    }


    }


