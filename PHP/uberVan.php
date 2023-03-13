<?php 
require_once('car.php');
class UberVan extends Car {
    private $typeCarAccepted;
    private $seatMaterial;

    //Constructor1
    public function __construct(String $license, Account $driver, $typeCarAccepted = null, $seatMaterial = null) {
        parent::__construct($license, $driver);
        $this->typeCarAccepted = $typeCarAccepted ?? [];
        $this->seatMaterial = $seatMaterial ?? [];
    }

    //Metodo sobreescribir Polimorfismo
    public function setPassenger($passenger) {
        if ($passenger == 6) {
            $this->passenger = $passenger;
        } else {
            echo "Necesitas asignar 6 pasajeros!";
        }
    }
}
?>