class Main {
    /**
     * @param args
     */
    public static void main(String[] args) {
        System.out.println("Hola Mundo");
        /*Car car = new Car("AMQ123", new Account("Abraham", null));
        car.setPassenger = 4;
        //System.out.println("Car License " + car.license);
        car.printDataCar();*/

        UberX uberX = new UberX("BCD987", new Account("Enrique Vasquez", null), "Chevrolet", "Sonic");
        uberX.setPassenger(4);
        //System.out.println("Car License " + car.license);
        uberX.printDataCar();

        /*UberX car3 = new UberX("ACA123", new Account("Sacarias Piedras", "TOY987"),"Renault", "Logan");
        car3.setPassenger(4);
        car3.printDataCar();*/

        UberVan uberVan = new UberVan("QWE789", new Account("Carlos Vasquez", "POI098"));
        uberVan.setPassenger(6);
        uberVan.printDataCar();
    }
}   