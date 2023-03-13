namespace UberPoo
{
    class MainUber
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hola mundo");

            Car car = new Car("ABC123,", new Account("Abraham Cañon", "DEF789"));
            car.PrintDataCar();

            UberX car2 = new UberX("BVC987", new Account("Cañon Contecha", "QWE567"), "Chevrolet", "Aveo");
            car2.PrintDataCar();

            UberVan uberVan = new UberVan("EXI098", new Account("Enrique Vasquez", "QWE567"));
            uberVan.SetPassenger(6);
            uberVan.PrintDataCar();
        }
    }
}