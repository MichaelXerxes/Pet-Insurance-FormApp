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
    public partial class DisplayQuoteOnly : Form
    {
        public static DisplayQuoteOnly Current;//current form object
        
        private static Pet model1;//current decoded object
        private List<Pet> petsList;// decoded list of Pet objects
        public DisplayQuoteOnly()
        {//default constructor
            InitializeComponent();
            Current = this;
            this.ControlBox = false;
            petsList = new List<Pet>();
            
        }

        private void buttonCircle1_Click(object sender, EventArgs e)
        {//close current form method
           
            
            Current.Close();
          
            frmDisplayQuotes.Current.Show();   
          
            
        }

        private void DisplayQuoteOnly_Load(object sender, EventArgs e)
        {//method call when object is show
          
            displayQouteDetails();//call method
            
        }
        private void displayQouteDetails()
        {// method displaying current row data from DisplayQuotes form
            string policy, fname, lname, status, numberY,totalPrice,startDate;
            status = frmDisplayQuotes.quote.quoteStatus;
            policy = frmDisplayQuotes.holder.PolicyNumber;
            fname = frmDisplayQuotes.holder.FirstName;
            lname = frmDisplayQuotes.holder.LastName;
            numberY = frmDisplayQuotes.holder.NumberYears;
            startDate = frmDisplayQuotes.holder._policyStartDate;
           
            totalPrice = frmDisplayQuotes.quote.totalQuotePrice;
         
            for (int i = 0; i < 10; i++)
            {// for loop to read Pets data and add to list
                petsList.Add(returnPetDetails(frmDisplayQuotes.petsCodedStringList[i]));
            }
            labelHolder.Text = "       *** Policy Details *** \n\nPolicy Number : " + policy + "\nPolicy Status : " + status + "\nFirst Name : " + fname + "\nLast Name : " + lname +
                "\nYears with Company : " + numberY+"\nTotal Price is : "+totalPrice;//display on label
            lblStartDate.Text = "Start Date : " + startDate;
            displayPetsDetails();//call method
        }
        private void displayPetsDetails()
        {//method displaying Pets data
           
            
            for (int i = 0; i < 10; i++)
            {//for loop reads data from 1 to 10 pets
                if (petsList[i]._petName.Equals("")) 
                {// if pets Name is empty continue loop for
                 
                    continue;
                }
                else
                {//if pet name is not empty 
                    listBox1.Items.Add("Pet Name : " + petsList[i]._petName + " Years Old : " + petsList[i]._petDoB + " Pet Breed : " + petsList[i]._petBreed + " Pet Type : " + petsList[i]._petType);
                    listBox1.Items.Add("Health : " + petsList[i]._petHealth + " Insurance Cost : " + petsList[i]._petTotalPrice + " Pet Status : " + petsList[i]._status);
                    listBox1.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                
               
              
            }
        }
        private static Pet returnPetDetails(string line)
        {// method to decode the coded pet data


            string codedDetails, petName, petDob, petBreed, petType, petHealth, petStatus;
            decimal petCost;
            try
            {
                int position = line.IndexOf("@");
                petName = line.Substring(0, position);
                codedDetails = line.Substring(position+1);

                position = codedDetails.IndexOf("@");
                petDob = codedDetails.Substring(0, position);
                codedDetails = codedDetails.Substring(position+1);

                position = codedDetails.IndexOf("@");
                petBreed = codedDetails.Substring(0, position);
                codedDetails = codedDetails.Substring(position+1);

                position = codedDetails.IndexOf("@");
                petType = codedDetails.Substring(0, position);
                codedDetails = codedDetails.Substring(position+1);

                position = codedDetails.IndexOf("@");
                petHealth = codedDetails.Substring(0, position);
                codedDetails = codedDetails.Substring(position+1);

                position = codedDetails.IndexOf("@");
                petCost = decimal.Parse(codedDetails.Substring(0, position).Trim());
                codedDetails = codedDetails.Substring(position+1);

                position = codedDetails.IndexOf("@");
                petStatus = codedDetails.Trim();
             
                model1 = new Pet(petName, petDob, petBreed, petType, petHealth, petCost, petStatus);
                return model1;
            }
            catch (System.ArgumentOutOfRangeException)
            {

                MessageBox.Show("Something with displaing pets went wrong!!");
            }
          

            

            return  null;
        }
    }
}
