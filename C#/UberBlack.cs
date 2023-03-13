namespace UberPoo
{
    class UberBlack : Car
    {
        Dictionary<string, Dictionary<string, int>> typeCarAccepted;
        List<string> seatMaterial;

        public UberBlack(string license, Account driver, Dictionary<string, 
            Dictionary<string, int>> typeCarAccepted, List<string> seatMaterial)
            : base(license, driver)
        {
            this.typeCarAccepted = typeCarAccepted;
            this.seatMaterial = seatMaterial;
        }
    }
}