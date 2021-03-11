using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newerversion_of_method_project_1103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************************************************************");
            Console.WriteLine("Maryam Vatanparast");
            Console.WriteLine("C# 1th project");
            Console.WriteLine("**********************************************************************************************************");

           

            string Vehicle;

            do
            {
                Console.WriteLine("PLease Choose Type of your vehicle: 1:Car, 2:Bus, 3:Truck ");

                Vehicle = Console.ReadLine();

            } while (Vehicle != "Car" && Vehicle != "Bus" && Vehicle != "Truck");

            double[] timearray = new double[4];
            Inputtimes(timearray);
            double[] spenttimeArray = new double[3];

            Spenttime(timearray,spenttimeArray); 

            double vehicleCharge = VehicleCharge(Vehicle, spenttimeArray[2]);
         
            Outputformat(Vehicle, timearray, spenttimeArray[0], spenttimeArray[1], spenttimeArray[2], vehicleCharge);

        }

        //Method for time inut from user with data validation
        private static void Inputtimes(double[] timearray)
        {
            double Hourenter;
            double Minenter;
            double Hourleft;
            double Minleft;
         
            do
            {
                Console.WriteLine("Hour vehicle enetered lot: (0-24)");
                Hourenter = Convert.ToInt32(Console.ReadLine());
                timearray[0] = Hourenter;
                Console.WriteLine("Minute vehicle enetered lot: (0-60)");
                Minenter = Convert.ToInt32(Console.ReadLine());
                timearray[1] = Minenter;
                Console.WriteLine("Hour vehicle left lot: (0-24)");
                Hourleft = Convert.ToInt32(Console.ReadLine());
                timearray[2] = Hourleft;
                Console.WriteLine("Minute vehicle left lot: left lot: (0-60)");
                Minleft = Convert.ToInt32(Console.ReadLine());
                timearray[3] = Minleft;

            } while (Hourenter < 0 || Hourenter > 24 || Minenter < 0 || Minenter > 60 || Hourleft < 0 || Hourleft > 24 || Minleft < 0 || Minleft > 60);


            foreach (double item in timearray)
            {
                Console.WriteLine(item);
 
            }

        }

        // Method to calculate actual time spent in parking by vehicle. 
        static void Spenttime(double[] timearray, double [] spenttimeArray) 
        {
            double hourspent = 0;
            double minspent = 0;
            

            if (timearray[3] < timearray[1])
            {
           
                hourspent = (timearray[2]-1) - timearray[0];
                spenttimeArray[0] = Convert.ToInt32(hourspent);


                minspent = (timearray[3]+60) - timearray[1];
                spenttimeArray[1] = Convert.ToInt32(minspent);

                double Totalspenttime = hourspent + Math.Ceiling((minspent / 15) * 0.25);
                spenttimeArray[2] = Convert.ToInt32(Totalspenttime);

            }
            else
            {

                hourspent = timearray[2] - timearray[0];
                spenttimeArray[0] = Convert.ToInt32(hourspent);

                minspent = timearray[3] - timearray[1];
                spenttimeArray[1] = Convert.ToInt32(minspent);


                double Totalspenttime = hourspent + Math.Ceiling((minspent / 15) * 0.25);
                spenttimeArray[2] = Convert.ToInt32(Totalspenttime);
          
            }
            foreach (double item in spenttimeArray)
            {
                Console.WriteLine(item);

            }
        }

        // Method to calculate parking charge!

        static double VehicleCharge(string vehicle, double Totalspenttime)
        {

            if (vehicle == "Car" && Totalspenttime <= 3)
            {
                double VehicleCharge = 0;
                
                return VehicleCharge;

            }
            else if (vehicle == "Car" && Totalspenttime > 3)
            {
                double Newtime = Totalspenttime - 3;
                double VehicleCharge = Newtime * 1.50;
              
                return VehicleCharge;
            }

            else if (vehicle == "Bus" && Totalspenttime <= 1)
            {
                double VehicleCharge = Totalspenttime * 2.00;
                
                return VehicleCharge;
            }
            else if (vehicle == "Bus" && Totalspenttime > 1)
            {
                double Newtime = Totalspenttime - 1;
                double VehicleCharge = Newtime * 3.70 + Totalspenttime * 2.00;
               
                return VehicleCharge;
            }
            else if (vehicle == "Truck" && Totalspenttime <= 2)
            {
                double VehicleCharge = Totalspenttime * 1.00;
              
                return VehicleCharge;

            }
            else if (vehicle == "Truck" && Totalspenttime > 2)
            {
                double Newtime = Totalspenttime - 2;
                double VehicleCharge = Newtime * 2.50 + Totalspenttime * 1.00;
                
                return VehicleCharge;
            }
            else
            {
              
                return 0;
            }


        }
        //Method for output format!
        static void Outputformat(string Vehicle, double[] timearray, double spenthour, double spentime, double totalspenttime, double vehicleCharge)
        {
            Console.WriteLine($"TYPE OF VEHICLE: {Vehicle}");
            Console.WriteLine($"TIME-IN: {timearray[0]} : {timearray[1]}");
            Console.WriteLine($"TIME-OUT: {timearray[2]} : {timearray[3]}");
            Console.WriteLine($"PARKING-TIME: {spenthour}: {spentime}");
            Console.WriteLine($"ROUNDED TOTAL: {totalspenttime}");
            Console.WriteLine($"TOTAL CHARGES: {vehicleCharge} $");


        }
    }
    }

