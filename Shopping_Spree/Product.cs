class Product
{
    public string name
    {
        get { return name; }
        set { if (value is null || value.Equals("") || value.Equals(" ")) { throw new Exception("name can't be empty"); } else { name = value; } }
    }
    public double cost
    {
        get { return cost; }
        private set { if (value >= 0) { cost = value; } else { throw new Exception("cost cannot be negative"); } }
    }

    public Product(string name, double cost)
    {
        this.name = name;
        this.cost = cost;
    }
}
