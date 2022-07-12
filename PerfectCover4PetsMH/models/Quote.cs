using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectCover4PetsMH.models
{
   public class Quote
    {
        public Holder _holder { get; set; }
        
        private List<Pet> _pets = new List<Pet>();
        public string totalQuotePrice { get; set; }
        public string quoteStatus { get; set; }
        public Quote()
        {
            
        }
       
      
        public List<Pet> Pets { get
            {
                return _pets;
            } }
        public void setPets(Pet pet)
        {
            _pets.Add(pet);
        }
      
        public string TotalPrice
        {
            get
            {
                return totalQuotePrice;
            }
        }
        
    }
}
