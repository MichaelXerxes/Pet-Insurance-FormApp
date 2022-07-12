using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectCover4PetsMH.utils
{
    class PetTypesCheckFile
    {
        private List<string> dogType = new List<string>();
        private List<string> procentForDog = new List<string>();

        public PetTypesCheckFile()
        {
            readFile();

        }
        public List<string> DogType { get
            {
                return dogType;
            } }
        public List<string> DogProcent
        {
            get
            {
                return procentForDog;
            }
        }
        private void readFile()
        {
           
            try
            {
                StreamReader reader = File.OpenText("PetTypes.csv");

                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String[] values = line.Split(',');

                    dogType.Add(values[0]);
                    procentForDog.Add(values[1]);

                }
            }
            catch (FileNotFoundException)
            {

                
            }
          
        }
    }
}
