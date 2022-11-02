using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.ApplicationLayer
{
    public class PackageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private string _weight;

        public string Weight
        {
            get => _weight;
            set
            {
                double i = 0;
                if(double.TryParse(value, out i))
                {
                    _weight = value;
                }
              
            }
        }

    

    }
}
