using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Assignment
{
    internal class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary, HRA, TA, PF, DA, TDS, NetSalary, GrossSalary;
        public void getDetails()
        {
            Console.WriteLine("Enter your Employee No. :");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name :");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter your Salary :");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void calculateSalary(double Salary)
        {
            try
            {
                if (Salary < 5000)
                {
                    HRA = Salary * 10 / 100; 
                    TA = Salary * 5 / 100; 
                    DA = Salary * 15 / 100;
                }
                else if (Salary > 5000 && Salary < 10000)
                {
                    HRA = Salary * 15 / 100; 
                    TA = Salary * 10 / 100; 
                    DA = Salary * 20 / 100;


                }
                else if (Salary > 10000 && Salary < 15000)
                {
                    HRA = Salary * 20 / 100; 
                    TA = Salary * 15 / 100; 
                    DA = Salary * 25 / 100;


                }
                else if (Salary > 15000 && Salary < 20000)
                {
                    HRA = Salary * 25 / 100; 
                    TA = Salary * 20 / 100; 
                    DA = Salary * 30 / 100;


                }
                else
                {
                    HRA = Salary * 30 / 100; 
                    TA = Salary * 25 / 100; 
                    DA = Salary * 35 / 100;


                }
                GrossSalary = Salary + HRA + TA + DA;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Salary cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Give a proper salary ");
            }
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
        }
        public void display()
        {
            calculateSalary(Salary);
            Console.WriteLine();
            Console.WriteLine("The details of the salary is given below - ");
            Console.WriteLine("Employee No.  : " + EmpNo);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Gross salary  : " + GrossSalary);
            Console.WriteLine("PF            : " + PF);
            Console.WriteLine("TDS           : " + TDS);
            Console.WriteLine("NET Salary    : " + NetSalary);
        }
    }
}
