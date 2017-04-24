using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index+" index";
            }
        }
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country +" - country";
            }
        } 
    
    }
}
