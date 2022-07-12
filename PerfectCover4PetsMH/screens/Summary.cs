using PerfectCover4PetsMH.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PerfectCover4PetsMH.screens
{
    public partial class frmSummary : Form
    {
        public frmSummary Current;//current form object
        public Quote quote { get; set; }// for current quote data
        private List<decimal> arrayPetPrice;// list with pet`s insurance prices
        private decimal totalQuoteCost;//total quote price
        public frmSummary()
        {//default constructor
            InitializeComponent();
            Current = this;
            this.ControlBox = false;
            btnBackMenu2.Visible = false;
            quote = new Quote();
            arrayPetPrice =new List<decimal>();
            totalQuoteCost = 0m;
    
        }

     
        public void readData()
        {//method to Display quote details
            try
            {
                label2.Text = "Policy No. :" + quote._holder.PolicyNumber + "\nHolder Name : " + quote._holder.FirstName + "\nHolder Surname : " + quote._holder.LastName +  "\nYears with Company : " + quote._holder.NumberYears;
          
              
                label1.Text = quote.Pets.Count.ToString();
                for (int i = 0; i < quote.Pets.Count; i++)
                {//add each pet details to data grid in proper order
                    dataGridView1.Rows.Add(quote.Pets[i]._petName,quote.Pets[i]._status, quote.Pets[i]._petDoB, quote.Pets[i]._petBreed,
                        quote.Pets[i]._petType, quote.Pets[i]._petHealth, quote.Pets[i]._petTotalPrice);

                    arrayPetPrice.Add(quote.Pets[i]._petTotalPrice);
                    countTotalQuoteCOst(quote.Pets[i]._petTotalPrice);
                 

                }
                label1.Text = "Total Quote cost is : " + totalQuoteCost.ToString();
                label3.Text = "Start Date : " + quote._holder._policyStartDate;
            }
            catch (System.NullReferenceException)
            {

                label2.Text = "Error";
               
            }
            
        }
        private void countTotalQuoteCOst(decimal singlePetCost) 
        {//method to count total quote price
            totalQuoteCost += singlePetCost;   
        }
    
        private void saveFile()
        {// method to save file in csv format
            string date = DateTime.Today.ToString("dd-MM-yyyy"); //get today's date
            string filePath = "quotes_" + date + ".csv";  //create a name of the new csv file (including the date)

           // string filePath = "quotesAll5.csv";
            string delimiter = ",";//comma needed to create new csv file
            string distributor = "@";
            quote.totalQuotePrice= totalQuoteCost.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(quote._holder.PolicyNumber + delimiter + quote.quoteStatus + delimiter + quote._holder.FirstName + delimiter + quote._holder.LastName +
                           delimiter+  quote._holder.NumberYears + delimiter+ quote.TotalPrice + delimiter); 
            foreach (var item in quote.Pets)
            {
                sb.Append(
                    item._petName+distributor+item._petDoB+distributor+item._petBreed+distributor+item._petType+distributor+item._petHealth+distributor+item._petTotalPrice+distributor+
                    item._status+delimiter);
            }
            sb.Append(quote._holder._policyStartDate + delimiter);
            sb.AppendLine();
           
               frmHolderDetails.Current.Close();
          
                File.AppendAllText(filePath, sb.ToString()); //add the new string (made up of SEVERAL lines, each representing data from ONE order) to the end of the csv file
            
            

            MessageBox.Show("Orders saved to file");


        }
       
        private void btnAcceptQuote_Click(object sender, EventArgs e)
        {// method to accept quote details
            quote.quoteStatus= AcceptOrDecline("Accept");//assign value suign method
        }
        private void btnDecline_Click(object sender, EventArgs e)
        {//method to decline quote details
            quote.quoteStatus= AcceptOrDecline("Decline");//assign value suign method
        }
        private string AcceptOrDecline(string status)
        {//method that will check if total  price is 0 the will Decline whole quote
            string str="";
            btnBackMenu2.Enabled = true;
            btnBackMenu2.Visible = true;
            btnAcceptQuote.Visible = false;
            btnDecline.Visible = false;
            str = status;
            if (totalQuoteCost==0)
            {// if total cost is 0 quote would be decline automaticly
                str = "Decline";
            }
           

            return str;
        }

        private void btnBackMenu2_Click(object sender, EventArgs e)
        {// close current form and show Menu form
            if (MessageBox.Show("  Yes Back to Menu.", "No Stay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                saveFile();// call method to sava data on csv fiel
                frmMenuStart.currentQuoteNumber += 1;// fixed after Test 8 !!!!!!! quote Number
                frmMenuStart.Current.Show();
                totalQuoteCost = 0;
                Current.Close();

            }
        }

       
    }
}
