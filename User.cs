using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class User
    {
        private bool _displayAge = true;
        private int? _age;
        public User(DateTime birthday)
        {
            Age = DateTime.Now.Year - Birthday.Year;
        }
       public string FullName { get; set; }
       public string Email { get; set; }
       public DateTime Birthday { get; set; }
        public int? Age
        {
            get { return _displayAge ? _age : int.MinValue; }
            set { _age = value; }
        }
        public Gender Gender { get; set; }
       public string Password { get; set; }
       public DateTime Created { get; } = DateTime.Now;

        public void ToggleAgePrivacy() 
        {
            _displayAge = !_displayAge;
        }
    }
}
