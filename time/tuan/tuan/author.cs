using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan
{
    internal class author
    {
        private string name;
        private string email;
        private char gender;

        public author()
        {

        }
        public author(string name, string email, char gender)
        {
            this.name = name;
            Email = email;
            Gender = gender;
           
        }

        public string Name { get => name; }
        public string Email
        {
            set
            {
                if (email.Contains("@"))
                {
                    this.email = value;
                }
            }
            get { return  email; }
        }
        public char Gender
        {
            set
            {
                if (gender == 'u' || gender == 'm' || gender == 'f')
                {
                    this.gender = value;   
                }
                
            }
            get
            {
                return gender;
            }
        }
        public string ToString()
        {
            return $"{this.name + Email + Gender}";
        }
      
       
    }
}
