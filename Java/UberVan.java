import java.util.ArrayList;
import java.util.Map;

class UberVan extends Car {
    /**
     *
     */
    Map<String, Map<String,Integer>> typeCarAccepted;
    ArrayList<String> seatMaterial;
    //private Integer passenger;
    
    //Constructor1
    public UberVan(String license, Account driver, Map<String, Map<String,Integer>> typeCarAccepted, ArrayList<String> seatMaterial ){
        super(license, driver);
        this.typeCarAccepted = typeCarAccepted;
        this.seatMaterial = seatMaterial;
    }

    //Constructor2
    public UberVan(String license, Account driver){
        super(license, driver);
    }

    //SobreEscribir metodo:
    @Override
    public void setPassenger(Integer passenger) {
        if(passenger == 6){
            this.passenger = passenger;
        }else{
            System.out.println("Necesitas asiganar 6 pasajeros! ");
        }
    }
}