using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RealEstateApp realEstateApp = new RealEstateApp();
            while (true)
            {
                Console.WriteLine("Please enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                RealEstateListing realEstateListing = new RealEstateListing();  
                switch (choice)
                {

                    case 0:

                        Console.WriteLine("Please Enter ID");

                        realEstateListing.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please Enter Title");

                        realEstateListing.Title = Console.ReadLine();

                        Console.WriteLine("Please Enter description");

                        realEstateListing.Description = Console.ReadLine();

                        Console.WriteLine("Please Enter price");

                        realEstateListing.Price = Convert.ToInt32(Console.ReadLine());


                        realEstateApp.AddListing(realEstateListing);
                        break;

                case 1:

                        var list = realEstateApp.GetListings();

                        foreach(var t in list)
                        {
                            Console.WriteLine($"{ t.Title}");

                        }




                        break;
                }
            }
        }
    }
}
