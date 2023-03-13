namespace UberPoo
{
    public class Car
    {
        private int id;
        private string license;
        private Account driver;
        protected int passenger;

        //constructor
        public Car(string license, Account driver)
        {
            this.license = license;
            this.driver = driver;
        }

        //Metodo imprimir datos del carro
        public void PrintDataCar()
        {
            if (passenger != null)
            {
                Console.WriteLine("License: " + license + " Name Driver: " + driver.name + " Pasajeros: " + passenger);
            }
        }

        public void SetPassenger(int passenger)
        {
            if (passenger == 4)
            {
                this.passenger = passenger;
            }
            else
            {
                Console.WriteLine("Necesitas asignar 4 pasajeros!");
            }
        }


        public int Passenger
        {
            get
            {
                return passenger;
            }
            set
            {
                if (value == 4)
                {
                    passenger = value;
                }
                else
                {
                    Console.WriteLine("Necesitas asignar 4 pasajeros!");
                }
            }
        }

        //Gettes and setter
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string License
        {
            get
            {
                return license;
            }
            set
            {
                license = value;
            }
        }

        public Account Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
    }

}