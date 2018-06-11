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
    //    Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bmp,0,0);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            /*Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.Show();
            */

         //   PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview;

            PrintForm1.Print();
        }

        private void LabelVatOutPut_Click(object sender, EventArgs e)
        {

        }

        private void LabelHandlingChargeOutPut_Click(object sender, EventArgs e)
        {

        }

        private void LabelPostageOutPut_Click(object sender, EventArgs e)
        {

        }

        private void LabelFinalCostOutPut_Click(object sender, EventArgs e)
        {

        }

        private void LabelDiscountOutput_Click(object sender, EventArgs e)
        {

        }

        private void LabelVATStatusOutPut_Click(object sender, EventArgs e)
        {

        }

        private void LabelCustomerNumberOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
