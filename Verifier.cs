namespace knightmoves;
public class Verifier
{
    public string Taxable(state, taxExempt){
        if (state = IA && taxExempt = false){
            return "is taxable";
        }
        if (state = IA && taxExempt = true){
            return "";
        }
        if (state = FL && taxExempt = false){
            return "";
        }
}


public string IsVehicle(bool hasWheels, bool canFly, bool canSwim)
{
    // Returns "is vehicle" if at least one parameter is true
    if (hasWheels || canFly || canSwim)
    {
        return "is vehicle";
    }

    // Returns an empty string if all parameters are false
    return "";
}

