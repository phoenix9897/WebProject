using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Class
    {
        private string name;
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }


        private string surname;
        public string GetSurname()
        {
            return name;
        }
        public void SetSurname(string value)
        {
            name = value;
        }


        public string Description { get; set; }
        public string GetDescription()
        {
            return name;
        }
        public void SetDescription(string value)
        {
            name = value;
        }
        
    }
}

