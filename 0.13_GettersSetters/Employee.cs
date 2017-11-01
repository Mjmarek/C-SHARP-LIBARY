using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GettersSetters
{
    class Employee
    {
        //"Backing" Fields
        private int _id;
        private string _name;
        private string _workQuote;

        //Properties - Examples of Business Logic
        public int ID
        {
            get
            {
                return _id;
            }

            set
            {
                if (value < 0)
                    throw new Exception("The employee ID is invalid.");
                _id = value;
            }
            
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))//If this is true, then exception is thrown
                    throw new Exception("Invalid employee name.");
                _name = value.Trim();//will cut off whitespace from beginning and end of input
            }
        }

        //Methods - since method is public and in the same class as _workQuote,
        //the SetWorkQuote method can access the _workQuote field, even though the field is private
        public void SetWorkQuote(string quote)
        {
            this._workQuote = quote;
        }

        public string GetQuote()
        {
            return this._workQuote;
        }
    }
}