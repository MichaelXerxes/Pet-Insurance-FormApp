using PerfectCover4PetsMH.models;
using PerfectCover4PetsMH.utils;
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
    public partial class frmPetDetails : Form
    {
        public frmPetDetails Current;// currnet form object 
        private Pet pet;// pet object to store pet data
        private DateTime dateCurrent;//to set current date
        public int _numberPets { get; set; }//to set number of pets in label7
        private decimal extraForBreed,total;// to count total price for current pet
        public decimal startPrice { get; set; }//premium strating prcie

        public frmPetDetails(int numberPets)
        {//constructor with int parameter
            InitializeComponent();
            Current = this;
            this.ControlBox = false;
            this._numberPets = numberPets;
            pet = new Pet();
            rbtMixedBreed.Checked = true;
            total = 0;
            dateCurrent = DateTime.UtcNow;
           
            dateTimePicker1.MaxDate = dateCurrent.AddDays(-1);// set calednar DoB for yesterday
          
            timer1.Interval = 1000;
            timer1.Start();
            labelDispalyOn();
          
            

        }

        private void btnMenuBackPet_Click(object sender, EventArgs e)
        {// close current form and show Menu form
            if (MessageBox.Show("  Yes Back to Menu.", "No Stay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmHolderDetails.Current.Close();//close form
                frmMenuStart.Current.Show();
                this.Close();

            }
            
           
        }

        private void frmPetDetails_Load(object sender, EventArgs e)
        {// when current form is show load data 

            this.label7.Text = "Pet Number " + _numberPets.ToString();

            PetTypesCheckFile petTypes = new PetTypesCheckFile();//create object and read data from csv file
            HealthConditionsCheckFile checkHealthFile = new HealthConditionsCheckFile();//create object and read data from csv file
            for (int i = 0; i < petTypes.DogType.Count(); i++)
            {//  data  display
                dataGridViewType.Rows.Add(petTypes.DogType[i], petTypes.DogProcent[i]);
            }
            for (int i = 0; i < checkHealthFile.Health.Count(); i++)
            {//  data  display
                dataGridViewHealth.Rows.Add(checkHealthFile.Health[i], checkHealthFile.ProcentHealth[i]);
            }
        }
        private void labelDispalyOn()
        {// methid to display current user input and current price on labelDisplay
            string str;

            str = "Pet Name : " + pet._petName + "\nPet DoB : " + pet._petDoB + "\nPet Breed : " + pet._petBreed +
                "\nPet Type : " + pet._petType + " extra cost up " + pet._petProcentType + "%" +
                "\nPet Health : " + pet._petHealth + " extra cost up " + pet._petProcentHealth + "%" +
                "\nTotal insurance cost for Pet is : " + total.ToString() +"£"+
                "\n\nQuote Status : "+pet._status;
            labelDisplay.Text = str;
            
        }
        private decimal calculateTotal()
        {// calculate insurance price for current pet
            decimal  extraType, extraHelath, petAge;
            total = 0;
            try
            {
                extraType =(decimal.Parse(pet._petProcentType) / 100) + 1m;
                extraHelath = (decimal.Parse(pet._petProcentHealth) / 100) + 1m;
                petAge = decimal.Parse(getProcentForDoBPet());
                total = (startPrice * extraForBreed * extraType * extraHelath * petAge) / frmHolderDetails.numberYearExtraCost;//calculate price
                total=Math.Round(total, 2);
                pet._petTotalPrice = total;
                return total;
            }
            catch (System.ArgumentNullException)
            {

                
            }
            return -999;

        }

        private void dataGridViewType_MouseClick(object sender, MouseEventArgs e)
        {//method to set value  from current clicked row
            string text = "",procent;
            int index;//current clicked row index


            index = dataGridViewType.CurrentRow.Index;
            DataGridViewRow row = dataGridViewType.Rows[index];
            procent = (string)row.Cells[1].Value;
            text= (string)row.Cells[0].Value;
           
          
            label5.Text = "CLick : " + text + "  " + procent+"%";
            pet._petType = text;
            pet._petProcentType = procent;
            pet._petName = textBox1.Text;
           
            getPetBreed();
            calculateTotal();
            labelDispalyOn();
           

        }
        private void changeButtonColor()
        {//,ethod to change button colour after user input
            if (textBox1.Text!="")
            {
                
                btnAcceptPet.BackColor = Color.Green;
            }
        }

        private void dataGridViewHealth_MouseClick(object sender, MouseEventArgs e)
        {//method to set value from current clicked row
            string text = "",procent;
            int index;//current clicked row index
       
            index=dataGridViewHealth.CurrentRow.Index;
        
            DataGridViewRow row = dataGridViewHealth.Rows[index];
            procent =(string) row.Cells[1].Value;
            text = (string)row.Cells[0].Value;
            label6.Text = "CLick : " + text + "  " + procent + "%";
            pet._petHealth = text;
            pet._petProcentHealth = procent;
            pet._petName = textBox1.Text;
            
            getPetBreed();
            calculateTotal();
            labelDispalyOn();
        



        }
        private void getPetBreed()
        {// method to calculate procent for Pet Breed
            if (rbtnCrossBreed.Checked==true)
            {
                pet._petBreed = "Cross Breed";
                extraForBreed = 1.05m;

              
            }
            else if(rbtnPedigree.Checked==true)
            {
                pet._petBreed = "Pedigree";
                extraForBreed = 1.1m;
              
            }
            else if (rbtMixedBreed.Checked==true)
            {
                pet._petBreed = "Mixed Breed";
                extraForBreed = 1m;
              
            }
          
        }
        private string getPetDoB()
        {// method to calculate how old is current pet
            
            DateTime userPick=dateTimePicker1.Value;    //current date     
            TimeSpan tspan = dateCurrent - userPick;
            int differenceInDays = tspan.Days,years;//diffrent in days int number
            string yearsOld;

            years = calculateYears(differenceInDays);// int number suing method
            yearsOld = years.ToString();
            return yearsOld;
        }
        private int calculateYears(int daysNumber)
        {// this method will return only full years 
            int years;
            years = (int)daysNumber / 365;//  save as an integer
            return years;
        }
        private string getProcentForDoBPet()
        {//method to calculate procent for pet Date of Birth
            int yearsOldPet = int.Parse(getPetDoB());
            if (yearsOldPet<1)
            {
                 pet._status="HELD to Young";//if is to young HELD
                pet._petDoB = yearsOldPet.ToString();
                return 1.ToString();
            }
            else if (yearsOldPet>=1 &&yearsOldPet<=7)
            {
                pet._status = "Accepted";
                pet._petDoB = yearsOldPet.ToString();
                return 1.05.ToString();
            }
            else if (yearsOldPet>7 && yearsOldPet<=12)
            {
                pet._status = "Accepted";
                pet._petDoB = yearsOldPet.ToString();
                return 1.1.ToString();
            }
            else if (yearsOldPet>12)
            {
                pet._petDoB = yearsOldPet.ToString();
                pet._status="HELD to Old";//if is to old HELD
                return 1.ToString();
            }
            return 1.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {// timer to check is user input pet name and change per DoB 
            changeButtonColor();
            if (dateTimePicker1.Value==dateCurrent)
            {//if statment o make sure that pet DoB is not today
                
                btnAcceptPet.BackColor = Color.Red;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {//call methods when value is changed
            getPetBreed();
            calculateTotal();
            labelDispalyOn();
        }

        private void btnAcceptPet_Click(object sender, EventArgs e)
        {// accpet pet details , close current form and open next PetDetails form is exist
            decimal checkYears;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please type Pet name");
            }
            else
            {
                pet._petName = textBox1.Text;
            }

            checkYears = decimal.Parse(getProcentForDoBPet());
            
            if (checkYears<=1)
            {
                MessageBox.Show("This quote for Pet is Decline");
            }
            


            getPetBreed();
            if (pet._status!="Accepted")
            {
                pet._petTotalPrice = 0m;
            }
           
            if (textBox1.Text != "" && dateTimePicker1.Value!=dateCurrent)
            {// if is true close current form and add pet details to list - listPetsData 
                frmHolderDetails.FormNumber = _numberPets;
                frmHolderDetails.isClosed = true;//change isCLosed value so next PetDetails form is showed if exist
                frmHolderDetails.listPetsData.Add(pet);
                this.Close();
            }
           
        
        }

       
    }
}
