using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milbury_Pelletier_FinalProject
{
    public class Cars : Products
    {

        public string make;
        public string model;
        public int gears;
        public string type;

        public string Make
        {
            get;
            set;
        }

        public string Model { get; set; }
        public string Transmission { get; set; }
        public int Gears { get; set; }
        public string Type {get; set; }


        public Cars()
        {

        }

        public Cars(decimal inPrice, string inMake, string inModel, string inType)
        {
            Price = inPrice;
            Make = inMake;
            Model = inModel;
            Type = inType;
        }
        public override string ToString()
        {
            string carString =
                "Price: " + Price.ToString("c2")
                +
                " Make: " +
                Make + " Model: " +
                Model + " Type: " +
                Type + " Stock: " + Stock;

            return carString;
        }

        
        public static SportsCar CloneSport(Cars car)
        {
            SportsCar sportsCar = new SportsCar();
            sportsCar.Price = car.Price;
            sportsCar.Make = car.Make;
            sportsCar.Model = car.Model;
            sportsCar.Type = car.Type;
            sportsCar.Stock = car.Stock;
            return sportsCar;
        }
        public static LuxuryCar CloneLuxury(Cars car)
        {
            LuxuryCar luxuryCar = new LuxuryCar();
            luxuryCar.Price = car.Price;
            luxuryCar.Make = car.Make;
            luxuryCar.Model = car.Model;
            luxuryCar.Type = car.Type;
            luxuryCar.Stock = car.Stock;
            return luxuryCar;
        }
    }
}
