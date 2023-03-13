namespace UberPoo
{

    class UberX : Car
    {
        public string brand;
        public string model;

        public UberX(string license, Account driver, string brand, string model) : base(license, driver)
        {
            this.brand = brand;
            this.model = model;
        }

        public new void PrintDataCar(){
            base.PrintDataCar();
            System.Console.WriteLine("Model: "+ model + " Brand: " + brand);
        }
    }
}