var car = new Car("ABC789", new Account("Abraham Cañon", "DEF123"))
car.passenger = 4;
car.printDataCar();

var uberX = new UberX("ABC789", new Account("Catalina Beltran", "TRE345"), "Toyota", "4Runner")
uberX.passenger = 4;
uberX.printDataCar();

var uberVan = new UberVan("EXI098", new Account("Cañon Beltran", "EXI098"))
uberVan.passenger = 6;
uberVan.printDataCar();