
class Dough
{
    string flourType
    {
        get { return flourType; }
        set { if (value.Equals("white") || value.Equals("wholegrain")) { flourType = value; } else { throw new Exception("Invalid type of dough."); } }
    }
    string bakingType
    {
        get { return bakingType; }
        set { if (value.Equals("crispy") || value.Equals("chewy") || value.Equals("homemade") ){ bakingType = value; } else{ throw new Exception("Invalid type of dough."); }   }
    }

    double weight
    {
        get { return weight; }
        set { if (value > 0 && value <=200) { weight = value; } else { throw new Exception("Weight must be 1 to 200"); } }
    }

    public double getCalories()
    {
        double calories = 2 * weight;
        switch (flourType)
        {
            case "white":
                { calories *= 1.5; }
                break;
            case "wholegrain":
                { calories *= 1; }
                break;
            default:
                { }
                break;
        }

        switch (bakingType)
        {
            case "crispy":
                { calories *= 0.9; }
                break;

            case "chewy":
                { calories *= 1.1; }
                break;
            case "homemade":
                { calories *= 1.0; }
                break;
            default: { } break;

        }

        return calories;
    }
    
}
