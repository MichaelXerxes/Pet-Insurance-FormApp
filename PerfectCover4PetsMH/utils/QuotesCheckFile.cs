using PerfectCover4PetsMH.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectCover4PetsMH.utils
{
    class QuotesCheckFile
    {
        private List<string> policyNumber = new List<string>();
        private List<string> quoteStatus = new List<string>();
        private List<string> firstName = new List<string>();
        private List<string> lastName = new List<string>();
        private List<string> startDate = new List<string>();
        private List<string> yearsWithCompany = new List<string>();
        private List<string> totalCost = new List<string>();
        private List<Pet> pets = new List<Pet>();
        private List<string> testDetails = new List<string>();
        private List<string> pet2 = new List<string>();
        private List<string> pet3 = new List<string>();
        private List<string> pet4 = new List<string>();
        private List<string> pet5 = new List<string>();
        private List<string> pet6 = new List<string>();
        private List<string> pet7 = new List<string>();
        private List<string> pet8 = new List<string>();
        private List<string> pet9 = new List<string>();
        private List<string> pet10 = new List<string>();

        public QuotesCheckFile()
        {
            readFile();

        }
        public List<string> TestDetails
        {
            get
            {
                return testDetails;
            }
        }
        public List<string> PolicyNumber
        {
            get
            {
                return policyNumber;
            }
        }
        public List<string> QuoteStatus
        {
            get
            {
                return quoteStatus;
            }
        }
        public List<string> FisrtName
        {
            get
            {
                return firstName;
            }
        }
        public List<string> LastName
        {
            get
            {
                return lastName;
            }
        }
        public List<string> StartDate
        {
            get
            {
                return startDate;
            }
        }
        public List<string> YearsWithCompany
        {
            get
            {
                return yearsWithCompany;
            }
        }
        public List<string> TotaCost
        {
            get
            {
                return totalCost;
            }
        }
        public List<Pet> Pets
        {
            get
            {
                return pets;
            }
        }
        public void setPets(Pet pet)
        {
            pets.Add(pet);
        }

        public List<string> Pet2
        {
            get
            {
                return pet2;
            }
        }
        public List<string> Pet3
        {
            get
            {
                return pet3;
            }
        }
        public List<string> Pet4
        {
            get
            {
                return pet4;
            }
        }
        public List<string> Pet5
        {
            get
            {
                return pet5;
            }
        }
        public List<string> Pet6
        {
            get
            {
                return pet6;
            }
        }
        public List<string> Pet7
        {
            get
            {
                return pet7;
            }
        }
        public List<string> Pet8
        {
            get
            {
                return pet8;
            }
        }
        public List<string> Pet9
        {
            get
            {
                return pet9;
            }
        }
        public List<string> Pet10
        {
            get
            {
                return pet10;
            }
        }


        private void readFile()
        {

            try
            {
                string date = DateTime.Today.ToString("dd-MM-yyyy"); //get today's date
                string filePath = "quotes_" + date + ".csv";  //create a name of the new csv file (including the date)
                StreamReader reader = File.OpenText(filePath);//rentalAll_11-05-2022.csv
               // StreamReader reader = File.OpenText("rentalAll_11-05-2022.csv");
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String[] values = line.Split(',');

                    policyNumber.Add(values[0]);
                    quoteStatus.Add(values[1]);
                    firstName.Add(values[2]);
                    lastName.Add(values[3]);
                   
                    yearsWithCompany.Add(values[4]);
                    totalCost.Add(values[5]);
                    testDetails.Add(values[6]);
                    
                  

                    try
                    {

                         pet2.Add(values[7]);
                          pet3.Add(values[8]);
                          pet4.Add(values[9]);
                          pet5.Add(values[10]);
                          pet6.Add(values[11]);
                          pet7.Add(values[12]);
                          pet8.Add(values[13]);
                          pet9.Add(values[14]);
                          pet10.Add(values[15]);
                        startDate.Add(values[16]);
                    }
                    catch (System.IndexOutOfRangeException)
                    {

                        continue;
                    }
                   


                }
            }
            catch (FileNotFoundException)
            {


            }

        }
      
        private void cellsDecryption()
        {
           
        }
    }
}
