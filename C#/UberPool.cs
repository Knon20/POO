namespace UberPoo
{

    class UberPool : Car
    {
        public string brand;
        public string model;

        public UberPool(string license, Account driver, string brand, string model) : base(license, driver)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}