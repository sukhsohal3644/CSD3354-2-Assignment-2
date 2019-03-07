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
    class program
    {
        public static void Main()
        {

            DelegateExercises newDel = new DelegateExercises();
            newDel.Method3();
            Console.ReadLine();
        }
    }
    public delegate int MyDelegate(out int i);
    public class DelegateExercises
    {
        int Method1(out int i)
        {
            System.Console.WriteLine("Method1");
            i = 10;
            return 0;
        }
    }
    public void Method3()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        MyDelegate myDelegate1 = new MyDelegate(Method1);
        MyDelegate myDelegate2 = myDelegate + myDelegate1;
        int intValue;
        myDelegate2(out intValue);
    }
}