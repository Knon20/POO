from account import Account


class Car:
    id = int
    license = str
    driver = Account("", "")
    passenger = int

    def __init__(self, license, driver):
        self.license = license
        self.driver = driver

    def printDataCar(self):
        if self.passenger is not None:
            print("License: " + self.license + " Name Driver: " +
                self.driver.name + " Pasajeros: " + str(self.passenger))


    def getPassenger(self):
        return self.passenger


    def setPassenger(self, passenger):
        if passenger == 4:
            self.passenger = passenger
        else:
            print("Necesitas asignar 4 pasajeros!")


    def getId(self):
        return self.id


    def setId(self, id):
        self.id = id


    def getLicense(self):
        return self.license


    def setLicense(self, license):
        self.license = license


    def getDriver(self):
        return self.driver


    def setDriver(self, driver):
        self.driver = driver
