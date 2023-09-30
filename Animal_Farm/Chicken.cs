class Chicken
{
    public string name
    {
        get { return name; }
        set { if (value is null || value.Equals("")|| value.Equals(" ")) { throw new Exception("name can't be empty"); } else {name = value; } }
    }

    public int age
    {
        get { return age; }
        private set { if (value > 0 && value <15) { age = value; } else { throw new Exception("Age must be in range of 0 to 15"); } }
    }

    public Chicken(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    private int CalculateProductPerDay()
    {
        Random r = new System.Random();
        return r.Next(0, 7);
    }

    public string getProductPerDay()
    {
        string result = ("Chicken " + name+ " (age " + age  + ") can produce " + CalculateProductPerDay() + " eggs per day.");
        return result;
    }
}