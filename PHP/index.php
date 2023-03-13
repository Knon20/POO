<?php
    require_once('Car.php');
    require_once('account.php');
    require_once('uberX.php');
    require_once('uberPool.php');
    
    $car = new Car("AW456", new Account("Andres Herrera", "AMS123"));
    $car->printDataCar();

    $uberX = new UberX("EXI098", new Account ("Enrique Vasquez","AND345"), "Chevrolet", "Spark");
    $uberX->PrintDataCar();

    $uberPool = new UberPool("QWE123", new Account("Yoni Pinga","POI789"), "Ferrari", "F1");
    $uberPool->PrintDataCar();

    $uberVan = new UberVan("PRU57A", new Account("Cañon Contecha","11207063"),"","");
    $uberVan->setPassenger(6);
    $uberVan->PrintDataCar();
?>