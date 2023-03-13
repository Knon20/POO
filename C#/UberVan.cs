using System;

namespace UberPoo
{
    public class UberVan : Car
    {
        Dictionary<string, Dictionary<string, int>> typeCarAccepted = new Dictionary<string, Dictionary<string, int>>();
        List<string> seatMaterial = new List<string>();

        public UberVan(string license, Account driver)
            : base(license, driver)
        {
        }

        public UberVan(string license, Account driver, Dictionary<string,
            Dictionary<string, int>> typeCarAccepted, List<string> seatMaterial)
            : base(license, driver)
        {
            this.typeCarAccepted = typeCarAccepted;
            this.seatMaterial = seatMaterial;
        }

        public new void SetPassenger(int passenger)
        {
            if (passenger == 6)
            {
                this.passenger = passenger;
            }
            else
            {
                Console.WriteLine("Necesitas asignar 6 pasajeros!");
            }
        }
    }
}
