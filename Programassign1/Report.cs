using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programassign
{
    public partial class Form2 : Form
    {
        public Form2(string CustomerName, string CustomerNumber, 
            string CustomerGender, string Discount, 
            string FinalCost, string HandlingCharge, 
            string PostageCharge, string PriceAfterVAT, 
            string PriceBeforeVAT, string VATStatus)
        {
            InitializeComponent();
            //shows form1 text in form2 label
            LabelCustomerNameOutPut.Text = CustomerName;
            LabelCustomerNumberOutput.Text = CustomerNumber;
            LabelGenderOutput.Text = CustomerGender;
            LabelDiscountOutput.Text = Discount;
            LabelFinalCostOutPut.Text = FinalCost;
            LabelHandlingChargeOutPut.Text = HandlingCharge;
            LabelPostageOutPut.Text = PostageCharge;
            LabelVatOutPut.Text = PriceAfterVAT;
            LabelCostBeforeVATOutPut.Text = PriceBeforeVAT;
            LabelVATStatusOutPut.Text = VATStatus;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
  
        }

        private void LabelCustomerNameOutPut_Click(object sender, EventArgs e)
        {

        }
    }
}
