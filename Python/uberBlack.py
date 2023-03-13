from car import Car

class UberBlack(Car):
    #Atributos de la clase
    typeCarAccepted = []
    seatMaterial = []

    #Constructor
    def __init__(self, license, driver, typeCarAccepted, seatMaterial):
        super().__init__(license, driver)
        self.typeCarAccepted = typeCarAccepted
        self.seatMaterial = seatMaterial