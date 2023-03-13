class UberVan extends Car {
    constructor(license, driver, typeCardAccetep, seatMaterial) {
        super(license, driver)
        this.typeCardAccetep = typeCardAccetep;
        this.seatMaterial = seatMaterial;
    }

    set passenger(passenger) {
        if (passenger === 6) {
            this._passenger = passenger;
        } else {
            console.log("Necesitas asignar 6 pasajeros!");
        }
    }
}