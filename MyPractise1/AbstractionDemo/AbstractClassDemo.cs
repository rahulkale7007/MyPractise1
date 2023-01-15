/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.AbstractionDemo
{
    abstract class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public long phoneNumber;


       *//* public long PhoneNumber
        {
            set
            {
                this.phoneNumber = value;
            }
            get
            {
                return this.phoneNumber;
            }
        }*//*
        public abstract void PrintDetails();
    }
    class Student : Person
    {
        public int rollNo;
        public int fees;
        public override void PrintDetails()
        {
            string name = firstName + " " + lastName;
            Console.WriteLine("Student name is : {0}", name);
            Console.WriteLine("Student age is : {0}",age);
            Console.WriteLine("Student phone number is : {0}",this.phoneNumber);
            Console.WriteLine("Student roll no is : {0}", this.rollNo);
            Console.WriteLine("Student fees is : {0}", this.fees);

        }
    }
    class Teacher : Person
    {
        public string qualification;
        public int salary;
        public override void PrintDetails()
        {
            string name = firstName + " " + lastName;
            Console.WriteLine("Teacher name is : {0}", name);
            Console.WriteLine("Teacher age is : {0}", age);
            Console.WriteLine("Teacher phone number is : {0}", this.phoneNumber);
            Console.WriteLine("Teacher roll no is : {0}", this.qualification);
            Console.WriteLine("Teacher fees is : {0}", this.salary);
        }
    }
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.firstName = "rahul";
            s.lastName = "kale";
            s.age = 24;
            s.phoneNumber = 9579249745;
            s.rollNo = 10;
            s.fees = 100000;
            //s.PhoneNumber = 575875785879;
            s.PrintDetails();

            Console.WriteLine("/........................./");

            Teacher t = new Teacher();
            t.firstName = "shital";
            t.lastName = "chaudhary";
            t.age = 30;
            t.phoneNumber = 9579259695;
            t.qualification = "ME";
            t.salary = 100000;
            t.PrintDetails();
            Console.ReadLine();
        }
    }
}
*/