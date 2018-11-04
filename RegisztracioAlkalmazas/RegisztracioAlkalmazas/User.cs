using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    class User
    {
        string name;
        string birthDate;
        bool gender;
        ListBox hobbies;

        

        public User(string name, string birthDate, bool gender, ListBox hobbies)
        {
            this.name = Name;
            this.birthDate = BirthDate;
            this.gender = Gender;
            this.hobbies = Hobbies;
        }


        public string Name
        {
            get
            {
                return name;
            }
        }

        public string BirthDate
        {
            get
            {
                return birthDate;
            }
        }

        public bool Gender
        {
            get
            {
                return gender;
            }
        }


        public ListBox Hobbies
        {
            get
            {
                return hobbies;
            }
        }

    }
}
