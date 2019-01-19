using System;

namespace C0732134
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet _Mary = new DataSet("Mary", 3.8, 20);
            DataSet _John = new DataSet("John", 2.0, 10);
            DataSet _Mark = new DataSet("Mark", 0.2, 3);
            DataSet _Steve = new DataSet("Mary", 2.9, 16);
            DataSet _Cindy = new DataSet("Cindy", 3.3, 18);

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
    }
}
