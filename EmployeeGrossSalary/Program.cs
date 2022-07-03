using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampFundamentalWeek1Project2
{
    enum userType { Engineers, Managers, Analysts }

    class Users
    {
        string _name;
        string _type;
        public Users()
        {
            _name = "";
            _type = "";
        }
        public Users(string n, string t)
        {
            this._name = n;
            this._type = t;
        }
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
        public string Type
        {
            get { return _type; }
            set { this._type = value; }
        }

    }
    class Employees
    {
        string _name;
        string _type;
        double _baseSalary;
        double _fuel;
        double _medicalAllowances;
        double _grossSalary;

        // Default Constructor
        public Employees()
        {
            this._name = "";
            this._type = "";
            this._baseSalary = 1500;
            this._fuel = 0;
            this._medicalAllowances = 0;
            this._grossSalary = 0;
        }
        // Perametarized Constructor
        public Employees(string n, string t)
        {
            this._name = n;
            this._type = t;
            this._baseSalary = 1500;
            this._fuel = 0;
            this._medicalAllowances = 0;
            this._grossSalary = 0;
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string UserType
        {
            get { return this._type; }
            set { this._type = value; }
        }
        public double BaseSalary
        {
            get { return this._baseSalary; }
            set { this._baseSalary = value; }
        }
        public double Fuel
        {
            get { return this._fuel; }
            set { this._fuel = value; }
        }
        public double MedicalAllowances
        {
            get { return this._medicalAllowances; }
            set { this._medicalAllowances = value; }
        }

        public double GrossSalary
        {
            get { return this._grossSalary; }
            set { this._grossSalary = value; }
        }

        public virtual double calculateGrossSalary()
        {
            return this._grossSalary;
        }
    }
    class Engineers : Employees
    {
        public Engineers()
        {
            this.Name = "";
            this.UserType = "";
            this.BaseSalary = 1500;
            this.Fuel = 100;
            this.MedicalAllowances = 500;
        }
        public Engineers(string n, string t)
        {
            this.Name = n;
            this.UserType = t;
            this.BaseSalary = 1500;
            this.Fuel = 100;
            this.MedicalAllowances = 500;
        }

        public override double calculateGrossSalary()
        {
            this.GrossSalary = this.BaseSalary + this.Fuel + this.MedicalAllowances;
            return this.GrossSalary;
        }
    }
    class Managers : Employees
    {
        public Managers()
        {
            this.Name = "";
            this.UserType = "";
            this.BaseSalary = 1500;
            this.Fuel = 250;
            this.MedicalAllowances = 1000;
        }
        public Managers(string n, string t)
        {
            this.Name = n;
            this.UserType = t;
            this.BaseSalary = 1500;
            this.Fuel = 250;
            this.MedicalAllowances = 1000;
        }

        public override double calculateGrossSalary()
        {
            this.GrossSalary = this.BaseSalary + this.Fuel + this.MedicalAllowances;
            return this.GrossSalary;
        }
    }
    class Analysts : Employees
    {
        public Analysts()
        {
            this.Name = "";
            this.UserType = "";
            this.BaseSalary = 1500;
            this.Fuel = 150;
            this.MedicalAllowances = 800;
        }
        public Analysts(string n, string t)
        {
            this.Name = n;
            this.UserType = t;
            this.BaseSalary = 1500;
            this.Fuel = 150;
            this.MedicalAllowances = 800;
        }

        public override double calculateGrossSalary()
        {
            this.GrossSalary = this.BaseSalary + this.Fuel + this.MedicalAllowances;
            return this.GrossSalary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int noOfEmp = 0;
            do
            {
                Console.Write("Enter No. of employees you want to add : ");
                noOfEmp = Convert.ToInt32(Console.ReadLine());
                if (noOfEmp < 1)
                {
                    Console.WriteLine("Please enter a number greater than 0");
                }
            } while (noOfEmp < 1);

            string nameOfEmployee = "", typeOfEmployee = "";
            int typeOfEmployeeNo = 0, idx = 0;

            List<Users> UsersList = new List<Users>();
            List<Engineers> EngineersList = new List<Engineers>();
            List<Managers> ManagersList = new List<Managers>();
            List<Analysts> AnalystsList = new List<Analysts>();
            for (int i = 0; i < noOfEmp; i++)
            {
                Console.Write("\nEnter name of Employee no. " + (i + 1) + " : ");
                nameOfEmployee = Console.ReadLine();

                do
                {
                    Console.Write("Select employee type of employee no. " + (i + 1) + ", ");
                    Console.Write("\n1. Engineer | 2. Manager | 3. Analyst : ");
                    typeOfEmployeeNo = Convert.ToInt32(Console.ReadLine());
                    if (typeOfEmployeeNo == 1)
                    {
                        typeOfEmployee = userType.Engineers.ToString();
                    }
                    else if (typeOfEmployeeNo == 2)
                    {
                        typeOfEmployee = userType.Managers.ToString();
                    }
                    else if (typeOfEmployeeNo == 3)
                    {
                        typeOfEmployee = userType.Analysts.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct menu number. ");
                    }
                } while (typeOfEmployeeNo < 1 || typeOfEmployeeNo > 3);

                UsersList.Add(new Users(nameOfEmployee, typeOfEmployee));
                if (userType.Engineers.ToString() == "Engineers")
                {
                    EngineersList.Add(new Engineers(nameOfEmployee, typeOfEmployee));
                    idx = EngineersList.Count - 1;
                    EngineersList[idx].calculateGrossSalary();
                }
                else if (userType.Managers.ToString() == "Managers")
                {
                    ManagersList.Add(new Managers(nameOfEmployee, typeOfEmployee));
                    idx = ManagersList.Count - 1;
                    ManagersList[idx].calculateGrossSalary();
                }
                else if (userType.Analysts.ToString() == "Analysts")
                {
                    AnalystsList.Add(new Analysts(nameOfEmployee, typeOfEmployee));
                    idx = AnalystsList.Count - 1;
                    AnalystsList[idx].calculateGrossSalary();
                }

                nameOfEmployee = "";
                typeOfEmployee = "";
                typeOfEmployeeNo = 0; 
                idx = 0;
            }

            for (int i = 0; i < noOfEmp; i++)
            {
                Console.WriteLine("\nEmployee No. " + (i + 1) + " Data is [ \nName: \"" + UsersList[i].Name + "\", \nEmployee type : \"" + UsersList[i].Type + "\" ]");
                Console.Write("\nGross Salary is : ");
                if (UsersList[i].Type.ToString() == "Engineers")
                {
                    Console.Write(EngineersList.FirstOrDefault(o => o.Name == UsersList[i].Name.ToString()).calculateGrossSalary());
                    Console.WriteLine("");
                }
                else if (UsersList[i].Type.ToString() == "Managers")
                {
                    Console.Write(ManagersList.FirstOrDefault(o => o.Name == UsersList[i].Name.ToString()).calculateGrossSalary());
                    Console.WriteLine("");
                }
                else if (UsersList[i].Type.ToString() == "Analysts")
                {
                    Console.Write(AnalystsList.FirstOrDefault(o => o.Name == UsersList[i].Name.ToString()).calculateGrossSalary());
                    Console.WriteLine("");
                }
            }


        }
    }
}
