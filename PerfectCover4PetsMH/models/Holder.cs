using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectCover4PetsMH.models
{
   public class Holder
    {
        private string _firstName;
        private string _lastName;
        private string _numberYears;
        private string _policyNumber;
        public string _policyStartDate { get; set; }
        public Holder(string fname, string lname, string nyear, string pnumber)
        {
            this._firstName = fname;
            this._lastName = lname;
            this._numberYears = nyear;
            this._policyNumber = pnumber;
        }
        public string FirstName {get{
                return _firstName; } }
        public string LastName
        {
            get
            {
                return _lastName;
            }
        }
        public string NumberYears
        {
            get
            {
                return _numberYears;
            }
        }
        public string PolicyNumber
        {
            get
            {
                return _policyNumber;
            }
        }
        public void setFirstName(string name)
        {
            this._firstName=name;
        }
        public void setLastName(string name)
        {
            this._lastName = name;
        }
        public void setNumberOfYears(string number)
        {
            this._numberYears=number;
        }
        public void setPolicyNumber(string number)
        {
            this._policyNumber = number;
        }
    }
}
