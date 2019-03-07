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

namespace DelegatesAndEvents
{
    public class Program
    {
        public static void Main()
        {
            DelegateExercises Deel = new DelegateExercises();
            Deel.Method3();
            Console.ReadLine();
        }
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate();

        void Method1()
        {
            System.Console.WriteLine("MyDelegate");
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}