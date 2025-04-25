using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview.Models
{
    public class User
    {
        private string _name;
        private int _age;
        private bool _isBaby;
        private bool _isStranger;

        private string _gender;



        public User()
        {
            
            
        }


        public bool IsStranger
        {
            get
            {
                return _isStranger;
            }
            set
            {
                _isStranger = value;
            }
        }
            

        public string Gender
        {
            get { return _gender; }
            set {
                if (value == "male" || value == "female")
                {
                    _gender = value;
                    
                }
                else
                {
                    Console.WriteLine("Enter a real gender! Don't be one of those.");
                }

            }
        }

        


        public bool IsBaby
        {
            get
            {
                return _age < 1;
            }
        }


        public string Name
        {
            get
            {
                if (!_isStranger)
                {
                    return _name;
                }
                else
                {
                    return "I don't want to tell you my name!";
                }

            }
            set
            {
                _name = value;
            }
        }



        public int Age
        {
            get {
                if (!_isStranger & !_isBaby) {
                    return _age;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                _age = value;


            }
               


        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}");
        }











    }
}
