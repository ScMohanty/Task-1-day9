using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
       class Program3
        {
            public static void Main(string[] args)
            {

                int no_Details = 4;
                int no_Company = 2;

                string c_Name;
                string c_Sector;
                string c_Location;
                int c_Age;
                string company;


                Company[] cArr = new Company[no_Details];
                for (int i = 0; i < no_Company; i++)

                {
                    Console.WriteLine("ENTER THE NAME");
                    c_Name = Console.ReadLine();
                    Console.WriteLine("ENTER SECTOR");
                    c_Sector = Console.ReadLine();
                    Console.WriteLine("ENTER LOCATION");
                    c_Location = Console.ReadLine();
                    Console.WriteLine("ENTER AGE");
                    c_Age = Convert.ToInt32(Console.ReadLine());






                    Company c = new Company(c_Name, c_Sector, c_Location, c_Age);


                    if (!cArr.Contains(c))
                    {
                        cArr[i] = c;
                    }
                    else
                    {
                        Console.WriteLine("Both the company are same");
                    }


                }

                foreach (var item in cArr)
                {
                    Console.WriteLine(item.ToString());
                }
              

            }
        }
    }

