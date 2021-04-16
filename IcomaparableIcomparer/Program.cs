using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomaparableIcomparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager obj = new Manager(new Developer());
            obj.ManageWork();

            List<Student> listofStudent = new List<Student>();
            listofStudent.Add(new Student()
            {
                Name = "Pooja",
                Marks = 74
            });
            listofStudent.Add(new Student()
            {
                Name = "Prasasd",
                Marks = 79
            });

            SortStudent sortStudent = new SortStudent();
            listofStudent.Sort(sortStudent);
            //foreach (var item in listofStudent)
            //{
            //    Console.WriteLine(item.Marks);
            //}

            Dictionary<string, string> StudentDict= new Dictionary<string, string>();
          
            StudentDict.Add("Mahesh Chand", "Programmer");
            StudentDict.Add("Praveen Kumar", "Project Manager");
            StudentDict.Add("Raj Kumar", "Architect");
            StudentDict.Add("Nipun Tomar", "Asst. Project Manager");
            StudentDict.Add("Dinesh Beniwal", "Manager");

            foreach (var item in StudentDict.Keys)
            {
                Console.WriteLine(item + " " + StudentDict[item]);
            }


            Console.WriteLine("Hashtable");
            Hashtable HT = new Hashtable();
            HT.Add(1, "s");
            HT.Add(3, "n");
            HT.Add(4, "j");
            HT.Add(2, "a");
            HT.Add(5, "u");
            foreach (var item in HT.Keys)
            {
                Console.WriteLine(item + " " + HT[item]);
            }
            var value = HT[6];
            Console.WriteLine(HT[6]);

            HashSet<int> hashset = new HashSet<int>();
            hashset.Add(10);
            hashset.Add(5);
            hashset.Add(12);
            hashset.Add(12);


            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }


    }

    class SortStudent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.Marks.CompareTo(x.Marks);
        }
    }

    interface Iworker
    {
        void Work();
    }
    class Manager
    {
        // Developer dev;
        // Tester tester;
        // public Manager(Developer developer, Tester tester)
        // {
        //     this.dev = developer;
        //     this.tester = tester;
        // }

        //public void giveWork()
        // {
        //     dev.Work();
        //     tester.Work();
        // }

        Iworker worker;
        public Manager(Iworker worker)
        {
            this.worker = worker;
        }
        public void ManageWork()
        {
            worker.Work();
        }
    }

    public class Developer : Iworker
    {
        public void Work()
        {
            Console.WriteLine("Dev working");
        }
    }

   public class Tester : Iworker
    {
        public void Work()
        {
            Console.WriteLine("Tester working");
        }
    }
}
