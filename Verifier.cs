namespace knightmoves;
public class Verifier
{
    public string IsVehicle(bool hasWheels, bool canFly, bool canSwim)
    {
        // If wheels OR fly OR swim is true, return "is vehicle"
        if (hasWheels || canFly || canSwim)
        {
            return "is vehicle";
        }
    
        return "";
    }


    public string IsVehicle(bool hasWheels, bool canFly, bool canSwim)
    {
        // Check if hasWheels is true
        if (hasWheels)
        {
            // hasWheels is true, so it's a vehicle regardless of others
            return "is vehicle";
        }
        else
        {
            // hasWheels is false, now check canFly
            if (canFly)
            {
                // canFly is true, so it's a vehicle
                return "is vehicle";
            }
            else
            {
                // hasWheels is false AND canFly is false, now check canSwim
                if (canSwim)
                {
                    // canSwim is true, so it's a vehicle
                    return "is vehicle";
                }
                else
                {
                    // All three are false
                    return "";
                }
            }
        }
    }



