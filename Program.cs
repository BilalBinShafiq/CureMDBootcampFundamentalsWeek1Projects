using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampFundamentalWeek1Projects
{
    internal class Program
    {
        enum userType { Commercial, Residential }
        static void Main(string[] args)
        {
            int noOfUsers = 0;
            do
            {
                Console.Write("Enter No. of users you want to add : ");
                noOfUsers = Convert.ToInt32(Console.ReadLine());
                if (noOfUsers < 1)
                {
                    Console.WriteLine("Please enter a number greater than 0");
                }
            } while (noOfUsers < 1);

            string nameOfUser = "", typeOfUser = "";
            int typeOfUserNo = 0, unitConsumedByUser = 0, idx = 0;

            List<Users> UsersList = new List<Users>();
            List<ResidentialElectricBill> ResidentialElectricBillsList = new List<ResidentialElectricBill>();
            List<CommercialElectricBill> CommercialElectricBillList = new List<CommercialElectricBill>();
            for (int i = 0; i < noOfUsers; i++)
            {
                Console.Write("\nEnter name of user no. " + (i + 1) + " : ");
                nameOfUser = Console.ReadLine();

                do
                {
                    Console.Write("Enter unit consumed by the user no. " + (i + 1) + " : ");
                    unitConsumedByUser = Convert.ToInt32(Console.ReadLine());
                    if (unitConsumedByUser < 1)
                    {
                        Console.WriteLine("Please enter a number greater than 0");
                    }
                } while (unitConsumedByUser < 1);

                do
                {
                    Console.Write("Select user type of user no. " + (i + 1) + ", ");
                    Console.Write("\n   1. Commercial\n   2. Residential : ");
                    typeOfUserNo = Convert.ToInt32(Console.ReadLine());
                    if (typeOfUserNo == 1)
                    {
                        typeOfUser = userType.Commercial.ToString();
                    }
                    else if (typeOfUserNo == 2)
                    {
                        typeOfUser = userType.Residential.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct menu number. ");
                    }
                } while (typeOfUserNo < 1 || typeOfUserNo > 2);

                UsersList.Add(new Users(nameOfUser, typeOfUser, unitConsumedByUser));
                if (userType.Commercial.ToString() == "Commercial")
                {
                    CommercialElectricBillList.Add(new CommercialElectricBill(nameOfUser, unitConsumedByUser, 17));
                    idx = CommercialElectricBillList.Count - 1;
                    CommercialElectricBillList[idx].calculateFinalBill();
                }
                else if (userType.Commercial.ToString() == "Residential")
                {
                    ResidentialElectricBillsList.Add(new ResidentialElectricBill(nameOfUser, unitConsumedByUser, 13));
                    idx = ResidentialElectricBillsList.Count - 1;
                    ResidentialElectricBillsList[idx].calculateFinalBill();
                }

                nameOfUser = "";
                typeOfUser = "";
                typeOfUserNo = 0;
                unitConsumedByUser = 0;
            }
            for (int i = 0; i < noOfUsers; i++)
            {
                Console.WriteLine("\nUser No. " + (i + 1) + " Data is [ \nName: \"" + UsersList[i].Name + "\", \nUnit Consumed : \"" + UsersList[i].UnitConsumed + "\", \nUser tyoe is : \"" + UsersList[i].UserType + "\" ]");
                Console.Write("\nElectric Bill is : ");
                if (UsersList[i].UserType.ToString() == "Commercial")
                {
                    Console.Write(CommercialElectricBillList.FirstOrDefault(o => o.Name == UsersList[i].Name.ToString()).calculateFinalBill());
                    Console.WriteLine("");
                }
                else if (UsersList[i].UserType.ToString() == "Residential")
                {
                    Console.Write(ResidentialElectricBillsList.FirstOrDefault(o => o.Name == UsersList[i].Name.ToString()).calculateFinalBill());
                    Console.WriteLine("");
                }
            }
        }
    }
}
