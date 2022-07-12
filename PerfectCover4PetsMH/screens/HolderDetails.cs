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

namespace PerfectCover4PetsMH.screens
{
    public partial class frmHolderDetails : Form
    {
        public static frmHolderDetails Current;// current form object
        private int numberPets;// number of pets int 
      
        
        private Holder holderData; //object to store holder details
        private DateTime dateCurrent;//to store current date

        public static List<Pet> listPetsData;//list used to stare pets data using Pet class
        public static bool isClosed = false;//to check if current PetDetails form is closed
        public static decimal numberYearExtraCost;// Discount, for each year with the company 1%
        public static int FormNumber { set ;
            get; }//used as index to pick PetDetails form, from list arrayPets
      
        private List<frmPetDetails> arrayPets;//list used to stare pets data from Pets details forms
        private frmSummary summary;// Summary form object
        public frmHolderDetails()
       
        {//default constructor
            InitializeComponent();

        }
        public frmHolderDetails(int numberpets)
        {//construcotr with one parameter
            InitializeComponent();
            Current = this;
            this.ControlBox = false;
            this.numberPets = numberpets;
            timerHolder.Start();
            timerHolder.Interval = 1000;
            isClosed = false;
            arrayPets = new List<frmPetDetails>();
            listPetsData = new List<Pet>();
            setdataPickers();
        }
        private void setdataPickers()
        {
            dateCurrent = DateTime.UtcNow;//set current date
            dateTimePickerNumberYears.MinDate = dateCurrent.AddYears(-6);// set  min date 6 years previuos from current date
            
            dateCurrent = DateTime.UtcNow;
            dateTimePickerStartingDate.MinDate = dateCurrent.AddDays(1);// set starting date AFTER today 
            dateCurrent = DateTime.UtcNow;
            dateTimePickerNumberYears.MaxDate = dateCurrent.AddDays(-1);
        }
        public void collectHolderData()
        {//method collecting holders data using holder class object with 4 parameters
            string fname, lname, numberY, policyNo;// 4 local strings
            DateTime userPick = dateTimePickerStartingDate.Value;
           
            fname = textBox1.Text;// user input value
            lname = textBox2.Text;// user input value
            numberY = getHolderTimeWithCompany();// count number of year with company using method
            numberYearExtraCost = (decimal.Parse(numberY)/100)+1m;
            policyNo = getPolicyNumber(lname);// get policy number using method
            holderData = new Holder(fname,lname,numberY,policyNo);
            holderData._policyStartDate = userPick.ToString();

        }
        private string getHolderTimeWithCompany()
        {// a method to count the number of years the current user has been with this company
            string str;
            int differenceInDays,years;
            DateTime userPick = dateTimePickerNumberYears.Value;// assign user pick value

            TimeSpan tspan = dateCurrent - userPick;// count diffrent
            differenceInDays = tspan.Days;// he difference between today's date and the one chosen by the user in days
            years = calculateYears(differenceInDays);// call method to calculate years using number of days 

            str = years.ToString();// store int value as string

            return str;//return string
        }
       private int calculateYears(int daysNumber)
        {// this method will return only full years 
            int years;
            years = (int)daysNumber / 365;//count number of years
            return years;
        }
        private string getPolicyNumber(string lastName)
        {// method to create Policy number
            
           
            int currentNumber = frmMenuStart.currentQuoteNumber;
            string output = currentNumber.ToString().PadLeft(6, '0');
           
            string policy;
            policy = lastName.Substring(0, 3) + output;//a.ToString()+b.ToString()+c.ToString() ;
            return policy;

        }
      
        public int getNumberPETS { get {
                return numberPets;
            } }

        private void btnMenuBackHolder_Click(object sender, EventArgs e)
        {//close current form and show Menu form method
            
            if (MessageBox.Show("  Yes Back to Menu.", "No Stay , make new Qoute", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                frmMenuStart.Current.Show();
            }
        }

        private void btnAcceptHolder_Click(object sender, EventArgs e)
        {//method for button Accept holder details
            int numberPets = getNumberPETS;
           

         
            for (int i = 1; i <=numberPets; i++)
            {//for loop to create number of PetDetails forms and add to list arrayPets
                frmPetDetails frmPet = new frmPetDetails(i);
                if (numberPets == 1)
                {// incrise starting pet price by 5% for single pet
                    frmPet.startPrice = 105;
                }
                else
                {//decrise starting pet price by 10% for mutli pets
                    frmPet.startPrice = 90;
                }

                arrayPets.Add(frmPet);
             
            }
            isClosed = true;

            collectHolderData();//call method
            this.Hide();
        }

        private void timerHolder_Tick(object sender, EventArgs e)
        {//timer for button Accept
            if ((textBox1.Text!="")&&(textBox2.Text!="")&&(textBox2.Text.Length>=3))
            {
                btnAcceptHolder.Enabled = true;
                btnAcceptHolder.BackColor = Color.Green;
            }
            if (textBox2.Text.Length<3)
            {
                btnAcceptHolder.Enabled = false;
                btnAcceptHolder.BackColor = Color.Red;
            }
            if (isClosed)
            {// if value is true
                try
                {// show form PetDetails from List arrayPets with index FormNumber
                    var formX = arrayPets[FormNumber];
                    formX.Show();
                }
                catch (ArgumentOutOfRangeException)
                {//when index FormNumber is out of range 

                    
                    summary = new frmSummary();
                    foreach (var item in listPetsData)
                    {// assign data in new summary object value quote
                        summary.quote.setPets(item);
                    }
                    ////////////////////////////////////
                    int numberPetsInList = summary.quote.Pets.Count();//assign number of exisiting pets
                    for (int i = numberPetsInList; i < 10; i++)
                    {// for loop for not existing pets to avoid problems with csv file
                        summary.quote.setPets(new Pet(""));
                    }
                    ///////////////////////////////////////////
                    summary.quote._holder = holderData;
                    summary.readData();
                    summary.Show();
                    FormNumber = 0;
                    this.Close();

                }
             
            }
        }
    }
}
