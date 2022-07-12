using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectCover4PetsMH.models
{
    public class Pet
    {
        public string _petName { get; set; }
        public string _petDoB { get; set; }
        public string _petBreed { get; set; }
        public string _petType { get; set; }
        public string _petHealth { get; set; }
        public string _petProcentType { get; set; }
        public string _petProcentHealth { get; set; }
        public decimal _petTotalPrice { get;  set; }
        public string _status { get; set; }

        public Pet()
        {

        }
        public Pet(string name,string dob,string breed,string type,string health,decimal cost,string status)
        {
            this._petName = name;
            this._petDoB = dob;
            this._petBreed = breed;
            this._petType = type;
            this._petHealth = health;
            this._petTotalPrice = cost;
            this._status = status;
        }
        public Pet(string name)
        {
            this._petName = name;
        }

        public String displayInfo()
        {
            return ("\n" + _petName + "\n" + _petBreed + "\n" + _petDoB + "\n" + _petType + "\n" + _petHealth + "\n" + _petTotalPrice);
        }
   
    }
}
