
using System.Xml.Linq;

class Toppings
{
    string type
    {
        get { return type; }
        set { if (value.Equals("meat") || value.Equals("veggies") || value.Equals("cheese")||value.Equals("sauce")  ) { type = value; } 
            else { throw new Exception("Cannot place" + value + " on top of your pizza."); } }
    }
       double weight
    {
        get { return weight; }
        set { if (value > 0 && value <= 50) { weight = value; } else { throw new Exception("Weight must be 1 to 50"); } }
    }

    public Toppings(string type, double weight)
    {
        this.type = type;
        this.weight = weight;
    }

    public double getCalories()
    {
        double calories = 2 * weight;
        switch (type)
        {
            case "meat":
                { calories *= 1.2; }
                break;
            case "veggies":
                { calories *= 0.8; }
                break;
            case "cheese":
                { calories *= 1.1; }
                break;
            case "sauce":
                { calories *= 0.9; }
                break;
            
            default:
                { }
                break;
        }

      

        return calories;
    }

}
