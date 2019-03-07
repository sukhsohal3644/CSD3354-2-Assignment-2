using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Student Name = Sukhdeep Sohal     Student ID = C0731586
// CSD3354 Section 2
// Assignment 2
// March 7,2019



// Student Name = Manjot Singh       Student ID = C0730244
// CSD3354 Section 2
// Assignment 2
// March 7,2019





namespace DelegateAndEvents
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1()

        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()

        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }

}

// Student Name = Sukhdeep Sohal     Student ID = C0731586
// CSD3354 Section 2
// Assignment 2
// March 7,2019



// Student Name = Manjot Singh       Student ID = C0730244
// CSD3354 Section 2
// Assignment 2
// March 7,2019







