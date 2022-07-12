using PerfectCover4PetsMH.screens;
using PerfectCover4PetsMH.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectCover4PetsMH
{
    public partial class frmMenuStart : Form
    {
        public static frmMenuStart Current;// current form object
        public static int currentQuoteNumber;// program wil start from quote number 000001 and incrise this number until application is close
     
        public frmMenuStart()
        {//constructor
            InitializeComponent();
            Current = this;// assaignt current form object
            this.ControlBox = false;
           // readFile = new PolicyLastNumberReadFile();

            currentQuoteNumber = 1;//changed from 0 to 1 after Test 9 !!!!
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {//method for exit button
            if (MessageBox.Show("  Yes Exit Program.", "No Stay , make new Qoute", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                  //  readFile = null;
                   
                
              //  saveNumberInFile();
                Application.Exit();//close application
            }
        }

        private void btnQuotes_Click(object sender, EventArgs e)
        {//button Quotes to open new form 
            frmDisplayQuotes displayQuotes = new frmDisplayQuotes();
            Current.Hide();
            displayQuotes.Show();

        }

        private void btnNewQuote_Click(object sender, EventArgs e)
        {// start new quote button that open Decison form
            frmDecison decison = new frmDecison();
           
            
            if (frmDisplayQuotes.Current!=null)
            {
                frmDisplayQuotes.Current = null;
            }
         
            
           // currentQuoteNumber += 1; fixed problem after Test 8
            decison.Show();
            Current.Hide();


        }
        private void btnMouseHover(object sender, EventArgs e)
        {// method to change back and fore colours for button exit and open quotes
            if (btnQuotes.BackColor == Color.White)
            {//

                btnQuotes.BackColor = Color.Black;
                btnExit.BackColor = Color.Black;
                btnQuotes.ForeColor = Color.White;
                btnExit.ForeColor = Color.White;
            }
            else if (btnQuotes.BackColor==Color.Black)
            {
               
                btnQuotes.BackColor = Color.White;
                btnExit.BackColor = Color.White;
                btnQuotes.ForeColor = Color.Black;
                btnExit.ForeColor = Color.Black;
            }

        }
    

    }
}
