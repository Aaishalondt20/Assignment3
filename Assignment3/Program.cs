namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            driver.Name = "Aaisha";
            driver.HasDriversLicense = false;


            Car BMW = new Car(4, 5, true, true, "AL98AD4509", driver,"CA200803");
            BMW.StartEngine();
            BMW.Accelerate(50);

            Console.WriteLine("BMW: " + BMW.speed);

            Console.WriteLine("BMW VIN? :" +  BMW.VinNumber);
            Console.WriteLine("BMW DOORS? : " + BMW.NoOfDoors);
            Console.WriteLine("BMW HAVE GPS? : " + BMW.HasGps);
            BMW.StopEngine();
            Console.WriteLine("BMW Driver? : " + BMW.CurrentDriver.Name);
            Console.WriteLine("BMW Driver License? : " + BMW.CurrentDriver.HasDriversLicense);
            Console.WriteLine("BMW Driver License Number?" + BMW.CurrentDriver.LicenseNumber);
        }
    }
}
