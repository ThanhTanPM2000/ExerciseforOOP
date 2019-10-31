using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public string GetName()
        {
            return this.name;
        }

        public string getEmail()
        {
            return this.email;
        }

        public char GetGender()
        {
            return this.gender;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public override string ToString()
        {
            return string.Format("Author[name={0}, email={1}, gender={2}]", this.name, this.email, this.gender);
        }
    }
}
