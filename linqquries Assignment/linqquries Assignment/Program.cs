using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace linqlistQuriesAssignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public String City { get; set; }

        public static void Main(String[] args)
        {
            List<Employee> emplist = new List<Employee>();
            Employee emp1 = new Employee()
            {
                EmployeeID = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = Convert.ToDateTime("11/16/1984"),
                DOJ = Convert.ToDateTime("08/06/2011"),
                City = "Mumbai"
            };
            emplist.Add(emp1);

            Employee emp2 = new Employee()
            {
                EmployeeID = 1002,
                FirstName = "Asdin",
                LastName = "Dhalla",
                Title = "AsstManager",
                DOB = Convert.ToDateTime("08/20/1984"),
                DOJ = Convert.ToDateTime("07/07/2012"),
                City = "Mumbai"
            };
            emplist.Add(emp2);

            Employee emp3 = new Employee()
            {
                EmployeeID = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = Convert.ToDateTime("11/14/1987"),
                DOJ = Convert.ToDateTime("11/14/1987"),
                City = "Pune"
            };
            emplist.Add(emp3);
            Employee emp4 = new Employee()
            {
                EmployeeID = 1004,
                FirstName = "Saba",
                LastName = "Shaikh",
                Title = "SE",
                DOB = Convert.ToDateTime("03/06/1990"),
                DOJ = Convert.ToDateTime("03/06/1990"),
                City = "Pune"
            };
            emplist.Add(emp4);
            Employee emp5 = new Employee()
            {
                EmployeeID = 1005,
                FirstName = "Nazia",
                LastName = "shaikh",
                Title = "SE",
                DOB = Convert.ToDateTime("08/03/1991"),
                DOJ = Convert.ToDateTime("02/02/2016"),
                City = "Mumbai"
            };
            emplist.Add(emp5);
            Employee emp6 = new Employee()
            {
                EmployeeID = 1006,
                FirstName = " Amit",
                LastName = "Pathak",
                Title = "Consultant",
                DOB = Convert.ToDateTime("07/11/1989"),
                DOJ = Convert.ToDateTime("08/08/2014"),
                City = "Chennai"


            };
            emplist.Add(emp6);

            Employee emp7 = new Employee()
            {
                EmployeeID = 1007,
                FirstName = " Vijay",
                LastName = "Natrajan",
                Title = "Consultant",
                DOB = Convert.ToDateTime("02/12/1989"),
                DOJ = Convert.ToDateTime("01/06/2015"),
                City = "Mumbai"

            };
            emplist.Add(emp7);

            Employee emp8 = new Employee()
            {
                EmployeeID = 1008,
                FirstName = " Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = Convert.ToDateTime("11/11/1993"),
                DOJ = Convert.ToDateTime("06/11/2014"),
                City = "Chennai"


            };
            emplist.Add(emp8);

            Employee emp9 = new Employee()
            {
                EmployeeID = 1009,
                FirstName = " Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = Convert.ToDateTime("12/08/1992"),
                DOJ = Convert.ToDateTime("03/12/2014"),
                City = "Chennai"


            };
            emplist.Add(emp9);

            Employee emp10 = new Employee()
            {
                EmployeeID = 1010,
                FirstName = " Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOB = Convert.ToDateTime("12/04/1991"),
                DOJ = Convert.ToDateTime("02/01/2016"),
                City = "Pune"

            };
            emplist.Add(emp10);

            IEnumerable<Employee> Result1 = from obj in emplist select obj;
            Console.WriteLine("---------Details of All Employees----------");
            Console.WriteLine("                              ");
            foreach (Employee emp in Result1)
            {

                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }

            IEnumerable<Employee> Result2 = from obj in emplist where (obj.City != "Mumbai") select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Details of who's Location is not mumbai");
            Console.WriteLine("                              ");
            foreach (Employee emp in Result2)
            {
                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }


            IEnumerable<Employee> Result3 = from obj in emplist where (obj.Title == "AsstManager") select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Details of who's Title is AsstManager");
            Console.WriteLine("                              ");
            foreach (Employee emp in Result3)
            {
                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }

            IEnumerable<Employee> Result4 = from obj in emplist where (obj.LastName.StartsWith("S")) select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Details of who's Lastname starts with S");
            Console.WriteLine("                              ");
            foreach (Employee emp in Result4)
            {
                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }

            IEnumerable<Employee> Result5 = from obj in emplist where obj.DOJ < Convert.ToDateTime("1/1/2015") select obj;
            Console.WriteLine("                              ");
            Console.WriteLine(" Displaying Details of who have joined before 1/1/2015 ");
            foreach (Employee emp in Result5)
            {
                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }

            IEnumerable<Employee> Result6 = from obj in emplist where obj.DOB > Convert.ToDateTime("1/1/1990") select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Details of whose date of birth is after 1/1/1990");
            Console.WriteLine("                              ");
            foreach (Employee emp in Result6)
            {
                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }

            IEnumerable<Employee> Result7 = from obj in emplist where (obj.Title == "Consultant" || obj.Title == "Associate") select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Details of whose Desigination is Consultant and Associate");
            Console.WriteLine("                              ");
            foreach (Employee emp in Result7)
            {
                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }

            IEnumerable<Employee> Result8 = from obj in emplist select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying total number of Employees");
            Console.WriteLine("                              ");
            Console.WriteLine("Total number of employees {0}", Result8.Count());

            IEnumerable<Employee> Result9 = from obj in emplist where (obj.City == "Chennai") select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Details of who's belonging to Chennai");
            Console.WriteLine("                              ");

            Console.WriteLine(" Total Employees belonging to Chennai {0} ", Result9.Count());


            var Result10 = emplist.Select(x => x.EmployeeID);
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Highest Employee ID");
            Console.WriteLine("                              ");
            Console.WriteLine("Highest Employee ID is {0}", Result10.Max());

            IEnumerable<Employee> Result11 = from obj in emplist where obj.DOJ > Convert.ToDateTime("1/1/2015") select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Details of who have joined after 1/1/2015");
            Console.WriteLine("                              ");
            foreach (Employee emp in Result11)
            {
                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }

            IEnumerable<Employee> Result12 = from obj in emplist where (obj.Title != "Associate") select obj;
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying Details of who's Title is not Associate");
            Console.WriteLine("                              ");
            foreach (Employee emp in Result12)
            {
                Console.WriteLine("  " + emp.EmployeeID + " , " + emp.FirstName + " , " + emp.LastName + " , " + emp.Title + " , " + emp.DOB + " , " + emp.DOJ + " , " + emp.City + "");
            }

            var Result13 = from obj in emplist group obj by obj.City;
            Console.WriteLine("                              ");
            Console.WriteLine("Displying Employee Details based on City");
            Console.WriteLine("                              ");
            foreach (var emp in Result13)
            {
                Console.WriteLine("{0} - {1}", emp.Key, emp.Count());
            }

            var Result14 = from obj in emplist group obj by new { obj.City, obj.Title };
            Console.WriteLine("                              ");
            Console.WriteLine("Displying Employee Details based on City AND Title");
            Console.WriteLine("                              ");
            foreach (var emp in Result14)
            {
                Console.WriteLine("{0} - {1}", emp.Key, emp.Count());
            }

            var Result15 = emplist.Select(x => x.DOB);
            Console.WriteLine("                              ");
            Console.WriteLine("Displaying the total number of younger Employees");
            Console.WriteLine("                              ");
            Console.WriteLine("Total number of younger Employee {0}", Result15.Min());

        }
    }
}


