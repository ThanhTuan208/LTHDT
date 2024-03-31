using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject
{
    internal class Author
    {
        //field
        private string name;
        private string email;
        private char gender;

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.Gender = gender;
        }

        //public string getEmail()
        //{ 
        //    return email;
        //}

        //public void setEmail(string email)
        //{
        //    if (email.Contains("@") == true)
        //        this.email = email;
        //}

        //property
        public string Email
        {
            get
            { return email; }
            
            set
            {
               if (value.Contains("@") == true)
                    this.email = value;
            }

        }

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

      
        public char Gender
        {
            get => gender;
            set
            {
                if (value == 'f'|| value == 'm' || value == 'u')
                    this.gender = value;
            } 
        }

        public string Name { get => name; set => name = value; }

        public string ToString()
        {
            return ($"name = {name}, email =  {email}, gender = {Gender}");
        }
    }
}
