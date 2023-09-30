class Pizza
{
    string name
    {
        get { return name; }
        set { if (value.Length <= 20) { name = value; } else { throw new Exception("Pizza name should be between 1 and 15 symbols."); } }
    }
    List<Toppings> toppings
    {
        get { return toppings; }
        set { if (value.Count > 10 || value.Count < 0) { throw new Exception("Number of toppings should be in range [0..10]."); } else { toppings = value; } }
    }
    Dough dough { get; set; }

    public Pizza(string name, List<Toppings> toppings, Dough dough)
    {
        this.name = name;
        this.toppings = toppings;
        this.dough = dough;
    }

    public string SumCalories()
    {
        double sumCalories = dough.getCalories();
        foreach (Toppings p in toppings)
        {
            sumCalories += p.getCalories();
        }

        return (name + " - " + sumCalories + " Calories");
    }
}