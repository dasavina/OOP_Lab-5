class Person
{
    public string name
    {
            get { return name; }
            set { if (value is null || value.Equals("") || value.Equals(" ")) { throw new Exception("name can't be empty"); } else { name = value; } }
    }
    public double money
    {
        get { return money; }
        private set { if (value >= 0) { money = value; } else { throw new Exception("money cannot be negative"); } }
    }
    List<Product> products { get; set; }

    public Person(string name, double money)
    {
        this.name = name;
        this.money = money;
        this.products = products;
    }

    public void buyProduct (Product product)
    {
        if (money >= product.cost)
        {
            products.Add(product);
            money = money - product.cost;
        }
        else
        {
            Console.WriteLine(name + " can't afford " + product.name);
        }
    }

    public void getAllProducts()
    {
        foreach (Product product in products)
        {
            Console.WriteLine(name + "bought " + product.name);
        }
    }
}