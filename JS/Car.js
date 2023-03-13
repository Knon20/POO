class Car {
    constructor(license, driver) {
        this.id;
        this.license = license;
        this.driver = driver;
        this.passenger;
    }

    printDataCar() {
        console.log(this.driver)
        console.log(this.driver.name)
        console.log(this.driver.document)
    }

    set passenger(passenger) {
        if (passenger === 4) {
            this._passenger = passenger;
        } else {
            console.log("Necesitas asiganar 4 pasajeros!");
        }
    }

    get id() {
        return this._id;
    }

    set id(id) {
        this._id = id;
    }

    get license() {
        return this._license;
    }

    set license(license) {
        this._license = license;
    }

    get driver() {
        return this._driver;
    }

    set driver(driver) {
        this._driver = driver;
    }
}
