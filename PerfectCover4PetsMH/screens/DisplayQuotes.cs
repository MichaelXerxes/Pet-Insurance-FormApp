using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerfectCover4PetsMH.models;
using PerfectCover4PetsMH.screens;
using PerfectCover4PetsMH.utils;

namespace PerfectCover4PetsMH.screens
{
    public partial class frmDisplayQuotes : Form
    {
        private int count = 0;
        private DisplayQuoteOnly display;
        
        private QuotesCheckFile quotes;
        public static frmDisplayQuotes Current;
        public static Quote quote;
       // public static string quoteStatus;
        public static Holder holder;
        public static string teststring;
        public static List<string> petsCodedStringList;
        private List<Color> colors;
        public frmDisplayQuotes()
        {//constructor
            InitializeComponent();
            Current = this;
            this.ControlBox = false;
            
           // quote = new Quote();


        }

        private void btnMenuBack_Click(object sender, EventArgs e)
        {
            
            frmMenuStart.Current.Show();
           // frmStart = new frmMenuStart();
           // frmStart.Show();
            Current.Close();
            quotes = null;
        }

        private void DisplayQuotes_Load(object sender, EventArgs e)
        {
            RefreshData();
          
        }
        private void RefreshData()
        {
           
             quotes = new QuotesCheckFile();

            for (int i = 0; i < quotes.FisrtName.Count(); i++)
            {

             dataGridView1.Rows.Add(quotes.PolicyNumber[i], quotes.QuoteStatus[i], quotes.FisrtName[i], quotes.LastName[i], quotes.YearsWithCompany[i], quotes.TotaCost[i], quotes.TestDetails[i],
             quotes.Pet2[i], quotes.Pet3[i], quotes.Pet4[i], quotes.Pet5[i], quotes.Pet6[i], quotes.Pet7[i], quotes.Pet8[i], quotes.Pet9[i], quotes.Pet10[i],quotes.StartDate[i]);



            }
        }
        private void readRow()
        {
            petsCodedStringList = new List<string>();
            int rowNumber = dataGridView1.CurrentRow.Index;
            holder = null;
            quote = null;
            quote = new Quote();

            
            
            try
            {
                string policy, fname, lname, numberYears;
                policy = dataGridView1.Rows[rowNumber].Cells[0].Value.ToString();
                quote.quoteStatus = dataGridView1.Rows[rowNumber].Cells[1].Value.ToString();
                fname = dataGridView1.Rows[rowNumber].Cells[2].Value.ToString();
                lname = dataGridView1.Rows[rowNumber].Cells[3].Value.ToString();
                numberYears = dataGridView1.Rows[rowNumber].Cells[4].Value.ToString();
                quote.totalQuotePrice= dataGridView1.Rows[rowNumber].Cells[5].Value.ToString();
              

                holder = new Holder(fname,lname, numberYears, policy);

                for (int i = 6; i < 16; i++)
                {
                    petsCodedStringList.Add(dataGridView1.Rows[rowNumber].Cells[i].Value.ToString());
                }
                holder._policyStartDate = dataGridView1.Rows[rowNumber].Cells[16].Value.ToString();
            }
            catch (System.NullReferenceException)
            {

                
            }
         

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           
           display = null;
            readRow();
            display = new DisplayQuoteOnly();
            display.Show();
            Current.Hide();
            petsCodedStringList = null;
          
         
        }
       

        private void btnMouseHover(object sender, EventArgs e)
        {
            colors = null;
            getRandomColor();
            btnMenuBack.BackColor = colors[0];
            
            btnMenuBack.ForeColor = colors[1];
            frmDisplayQuotes.Current.BackColor = colors[2];

            
        }
        private void getRandomColor()
        {
            Random rdm = new Random();
            Color color;
            colors = new List<Color>();

            int red, green, blue;
            for (int i = 0; i < 3; i++)
            {
                red = rdm.Next(0, 255);
                green = rdm.Next(0, 255);
                blue = rdm.Next(0, 255);
                 color = Color.FromArgb(red, green, blue);
                colors.Add(color);
            }
            
            
            
        }
       
  
    }
}
