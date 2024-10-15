

//Task 1

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("bmw", "i525");
            Motorcycle bicycle = new Motorcycle("amotor", "722t");
            car.showfullinfo();
            bicycle.showfullinfo();

        }
    }

    class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;

        public Vehicle(string Brand, string Model)
        {
            this.Brand = Brand;
            this.Model = Model;


        }
    }

    class Car : Vehicle
    {
        public int DoorsNum;

        public Car( string Brand, string Model) : base(Brand, Model)
        {
            


        }

        public void showfullinfo()
        {
            Console.WriteLine(Brand + " " + Model);

        }
    }

    class Motorcycle : Vehicle
    {
        public int WheelNum;

        public Motorcycle( string Brand, string Model) : base(Brand, Model)
        {
            

        }

        public void showfullinfo()
        {
            Console.WriteLine(Brand + " " + Model);

        }
    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////


//Task 2

//namespace Class
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Notebook notebook = new Notebook(8, "hp", 0, 1700);

//            notebook.Sale();
//            notebook.ShowFullData();

//        }


//    }

//    class Product
//    {
//        public string Name;
//        public string Description;
//        public int Count;
//        public bool IsStock;
//        public double Price;

//        public Product(string Name, int Count, double Price)
//        {
//            this.Name = Name;
//            this.Count = Count;
//            this.Price = Price;
//        }

//        public void Sale()
//        {
//            if (Count <= 0)
//            {

//                Console.WriteLine("Mehsul yoxdur");
//            }


//        }

//    }

//    class Notebook:Product
//    {
//        public byte RAM;
//        public int Storage;

//        public Notebook(byte RAM,string Name, int Count, double Price):base(Name,Count,Price)
//        {
//            this.RAM = RAM;

//        }

//        public void GetFullInfo()
//        {

//        }

//        public void ShowFullData()
//        {
//            Console.WriteLine(RAM+" "+Name+" "+Count+" "+Price);

//        }
//    }
//}