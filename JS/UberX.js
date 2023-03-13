class UberX extends Car {
    constructor(license, driver, brand, model){
        super(license, driver)
        this.brand = brand;
        this.model = model;
    }

    printDataCar(){
        super.printDataCar();
        console.log(`Model: ${this._model} Brand: ${this._brand}`);
    }

}