using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HW_Sharp_12
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string JobTitle { get; set; }
        public int Payment { get; set; }
        public string CorpEMail { get; set; }

        public Employee(string firstName, string secondName, string thirdName, string jobTitle, int payment, string corpEMail)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            JobTitle = jobTitle;
            Payment = payment;
            CorpEMail = corpEMail;
        }


    }
    internal class Program
    {
        static public void AddEmployee(Employee employee, ref List<Employee> list)
        {
            list.Add(employee);
        }
        static public void RemoveEmployee(int indx, ref List<Employee> list)
        {
            list.Remove(list[indx]);
        }
        static public void ChangeInfo(int indx, Employee employee, ref List<Employee> list)
        {
            list[indx].FirstName = employee.FirstName;
            list[indx].SecondName = employee.SecondName;
            list[indx].ThirdName = employee.ThirdName;
            list[indx].JobTitle = employee.JobTitle;
            list[indx].Payment = employee.Payment;
            list[indx].CorpEMail = employee.CorpEMail;
        }
        static public int FindByFirstName(string firstName, ref List<Employee> list)
        {
            int indx = 0;
            foreach (Employee obj in list)
            {
                if (obj.FirstName == firstName)
                {
                    return indx;
                }
                indx++;
            }
            return -1;
        }
        static public int FindBySecondName(string secondName, ref List<Employee> list)
        {
            int indx = 0;
            foreach (Employee obj in list)
            {
                if (obj.SecondName == secondName)
                {
                    return indx;
                }
                indx++;
            }
            return -1;
        }
        static public int FindByTgirdName(string thirdName, ref List<Employee> list)
        {
            int indx = 0;
            foreach (Employee obj in list)
            {
                if (obj.ThirdName == thirdName)
                {
                    return indx;
                }
                indx++;
            }
            return -1;
        }
        static public int FindByJobTitle(string  jobTitle, ref List<Employee> list)
        {
            int indx = 0;
            foreach (Employee obj in list)
            {
                if (obj.JobTitle == jobTitle)
                {
                    return indx;
                }
                indx++;
            }
            return -1;
        }
        static public int FindByPayment(int  payment, ref List<Employee> list)
        {
            int indx = 0;
            foreach (Employee obj in list)
            {
                if (obj.Payment == payment)
                {
                    return indx;
                }
                indx++;
            }
            return -1;
        }
        static public int FindByCorpEmail(string corpEmail, ref List<Employee> list)
        {
            int indx = 0;
            foreach (Employee obj in list)
            {
                if (obj.CorpEMail == corpEmail)
                {
                    return indx;
                }
                indx++;
            }
            return -1;
        }
        static public void SortBy(int paramIndx, ref List<Employee> list)
        {
            if (paramIndx == 0)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int y = 0; y < list.Count - i - 1; y++)
                    {
                        int comp = String.Compare(list[y].FirstName, list[y + 1].FirstName, StringComparison.InvariantCultureIgnoreCase);
                        if (comp > 0)
                        {
                            Employee temp = list[y];
                            list[y] = list[y + 1];
                            list[y + 1] = temp;
                        }
                    }
                }
            }
            else if (paramIndx == 1)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int y = 0; y < list.Count - i - 1; y++)
                    {
                        int comp = String.Compare(list[y].SecondName, list[y + 1].SecondName, StringComparison.InvariantCultureIgnoreCase);
                        if (comp > 0)
                        {
                            Employee temp = list[y];
                            list[y] = list[y + 1];
                            list[y + 1] = temp;
                        }
                    }
                }
            }
            else if (paramIndx == 2)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int y = 0; y < list.Count - i - 1; y++)
                    {
                        int comp = String.Compare(list[y].ThirdName, list[y + 1].ThirdName, StringComparison.InvariantCultureIgnoreCase);
                        if (comp > 0)
                        {
                            Employee temp = list[y];
                            list[y] = list[y + 1];
                            list[y + 1] = temp;
                        }
                    }
                }
            }
            else if (paramIndx == 3)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int y = 0; y < list.Count - i - 1; y++)
                    {
                        int comp = String.Compare(list[y].JobTitle, list[y + 1].JobTitle, StringComparison.InvariantCultureIgnoreCase);
                        if (comp > 0)
                        {
                            Employee temp = list[y];
                            list[y] = list[y + 1];
                            list[y + 1] = temp;
                        }
                    }
                }
            }
            else if (paramIndx == 4)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int y = 0; y < list.Count - i - 1; y++)
                    {
                        if (list[y].Payment > list[y + 1].Payment)
                        {
                            Employee temp = list[y];
                            list[y] = list[y + 1];
                            list[y + 1] = temp;
                        }
                    }
                }
            }
            else if (paramIndx == 5)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int y = 0; y < list.Count - i - 1; y++)
                    {
                        int comp = String.Compare(list[y].CorpEMail, list[y + 1].CorpEMail, StringComparison.InvariantCultureIgnoreCase);
                        if (comp > 0)
                        {
                            Employee temp = list[y];
                            list[y] = list[y + 1];
                            list[y + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect option!");
            }
        }
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Employee test1 = new Employee("A", "Z", "H", "U", 1, "J");
            Employee test2 = new Employee("B", "C", "S", "Y", 3, "A");
            Employee test3 = new Employee("C", "D", "K", "E", 2, "Q");
            list.Add(test1); list.Add(test2); list.Add(test3);
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.FirstName}");
            }
            SortBy(1, ref list);
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.FirstName}");
            }
        }
    }
}
