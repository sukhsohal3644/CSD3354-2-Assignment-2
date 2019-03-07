using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    // LAB 2

class Program
{
    static void Main(string[] args)
    {

    }
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
            myDelegate(50);
            
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // TO DO: Call Method2 from the DelegateExercises Class
    }
}


// LAB 3

public class DelegateExercises
{
    public delegate void MyDelegate();
    void Method1(int i)
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




