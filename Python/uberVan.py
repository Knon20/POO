from account import Account
from car import Car

class UberVan(Car):
    #Atributos de la clase
    typeCarAccepted = []
    seatMaterial = []

    #Constructor1
    def __init__(self, license, driver):
        super().__init__(license, driver)


    #Constructor2
    def __init__(self, license, driver, typeCarAccepted, seatMaterial):
        super().__init__(license, driver)
        self.typeCarAccepted = typeCarAccepted
        self.seatMaterial = seatMaterial
    
    def setPassenger(self, passenger):
        if passenger == 6:
            self.passenger = passenger
        else:
            print("Necesitas asignar 6 pasajeros!")