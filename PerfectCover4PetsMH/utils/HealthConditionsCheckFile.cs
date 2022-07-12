using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectCover4PetsMH.utils
{
    class HealthConditionsCheckFile
    {
        private List<string> health = new List<string>();
        private List<string> procentHealth = new List<string>();

        public HealthConditionsCheckFile()
        {
            readFile();

        }
        public List<string> Health
        {
            get
            {
                return health;
            }
        }
        public List<string> ProcentHealth
        {
            get
            {
                return procentHealth;
            }
        }
        private void readFile()
        {
            StreamReader reader = File.OpenText("Health Conditions.csv");

            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String[] values = line.Split(',');

                health.Add(values[0]);
                procentHealth.Add(values[1]);

            }


        }
    }
}
