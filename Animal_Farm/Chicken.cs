class Chicken
{
    public string name
    {
        get { return name; }
        set { if (value is null) { throw new Exception("name can't be null"); } else {name = value; } }
    }

    public int age
    {
        get { return age; }
        private set { if (value > 0) { age = value; } else { throw new Exception("Age cannot be 0 or less"); } }
    }
}