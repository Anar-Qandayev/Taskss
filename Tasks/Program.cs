using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            Person student1 = new Student();
            Person student2 = new Student();
            Person student3 = new Student();
            Person teacher1 = new Teacher();

            student1.Name = "Asif";
            student1.Surname = "Qandayev";
            student1.Age = 20;
            student1.Name = "Vasif";
            student1.Surname = "Qandayev";
            student1.Age = 21;
            student1.Name = "Agasif";
            student1.Surname = "Qandayev";
            student1.Age = 22;
            teacher1.Name = "Ulvi";
            teacher1.Surname = "Abdullazade";
            teacher1.Age = 24;
            student2.ShowInfo();
            student3.ShowInfo();
            student1.ShowInfo();
            teacher1.ShowInfo();


        }
    }
    abstract class Person
    {
        public static int Id { get; set; } = 0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person()
        {
            Id++;
        }
        public abstract void ShowInfo();
        
    }
    class Student : Person
    {
        public int Point { get; set; }
        public Student()
        {
            Id++;
        }
        public Student(int Point)
        {
            this.Point = Point;
        }

        public static bool operator >(Student s1, Student s2) {
            return s1.Point > s2.Point;
        }
        public static bool operator <(Student s1, Student s2) {
            return s1.Point < s2.Point;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Surname: {Surname} Age:{Age}");
        }

    }
    class Teacher : Person
    {
        public int Salary;


        public static bool operator >(Teacher t1, Teacher t2)
        {
            return t1.Salary > t2.Salary;
        }
        public static bool operator <(Teacher t1, Teacher t2)
        {
            return t1.Salary < t2.Salary;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Age:{Age}");
        }
    }   
    class GroupMate
    {
        public Student[] _student = new Student[0];

        public void Sort()
        {
           Array.Sort(_student);
            Array.Reverse(_student);
            Console.WriteLine();
        }


    }
}
