using System;
using System.Collections.Generic;

namespace C0732134
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet _Mary = new DataSet("Mary", 3.8, 20);
            DataSet _John = new DataSet("John", 2.00, 10);
            DataSet _Mark = new DataSet("Mark", 0.2, 3);
            DataSet _Steve = new DataSet("Mary", 2.9, 16);
            DataSet _Cindy = new DataSet("Cindy", 3.3, 18);

            var StudentList = new List<DataSet>();
            StudentList.Add(_Mary);
            StudentList.Add(_John);
            StudentList.Add(_Mark);
            StudentList.Add(_Steve);
            StudentList.Add(_Cindy);

            Console.WriteLine("\tName \tGPA \tAtendance\n");
            foreach (var student in StudentList)
            {
                Console.WriteLine("\t"+student.name +"\t"+student.gpa+"\t"+student.Attendance);
            }
            Console.ReadLine();
        }

        class DataSet
        {
            public string name;
            public double gpa ;
            public int Attendance ;

            public DataSet(string name_a, double gpa_a ,int Attendance_a)
            {
                name = name_a;
                gpa = gpa_a;
                Attendance = Attendance_a;
            }
        }

        class StudentList
        {
            public void CICS()
            {
                
            }
        }
    }
}
