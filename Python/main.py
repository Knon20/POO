# from uberVan import UberVan
# from uberX import UberX
# from car import Car
# from account import Account

# if  __name__ == "__main__":
#     print("Hola Mundo")

#     car = Car("ABC123", Account("Abraham Cañon","DFE789"))
#     print(vars(car))
#     print(vars(car.driver))

#     uberX = UberX("EXI098",Account("Cañon Contecha", "11207063"),"Chevrolet","Spark")
#     print(vars(uberX))
#     uberX.setPassenger(4)
#     uberX.printDataCar()

#     uberVan = UberVan("PRU57A", Account("Matias Cañon","1042104243"),"","")
#     print(vars(uberVan))
#     uberVan.setPassenger(6)
#     uberVan.printDataCar()

from uberVan import UberVan
from uberX import UberX
from car import Car
from account import Account

if __name__ == "__main__":
    print("Hola Mundo")

    car = Car("ABC123", Account("Abraham Cañon","DFE789"))
    print(vars(car))
    print(vars(car.driver))

    uberX = UberX("EXI098",Account("Cañon Contecha", "11207063"),"Chevrolet","Spark")
    #print(vars(uberX))
    print(uberX.printDataCar())

    uberVan = UberVan("PRU57A", Account("Matias Cañon","1042104243"),"","")
    #print(vars(uberVan))
    uberVan.printDataCar()
