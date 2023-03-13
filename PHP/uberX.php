<?php
require_once('car.php');
class UberX extends Car {
    //Atributos propios
    public $brand;
    public $model;

    //constructor
    public function __construct($license, $driver, $brand, $model){
        parent::__construct($license, $driver);
        $this->brand = $brand;
        $this->model = $model;
    }

    //Metodo sobreescribir polimorfismo
    public function printDataCar() {
        parent::printDataCar();
        echo "Modelo: " . $this->model . " Brand: " . $this->brand . "\n";
    }
}
?>