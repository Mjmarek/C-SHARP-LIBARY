using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student jayStudent = new Student();
            //jayStudent.FirstName = "Jay";
            //jayStudent.LastName = "Jackson";
            //jayStudent.Grade = 1;
            //jayStudent.Age = 5;

            //Same thing as 5 lines above, just less text
            Student jayStudent = new Student("Jay", "Jackson", 5, 1);

            Student jenn = new Student("Jenn", "Williams", 12);
        }
    }
}
