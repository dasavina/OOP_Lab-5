string[] people = Console.ReadLine().Split(";");
List<Person> persons = new List<Person>();
for (int i = 0; i < people.Length; i++)
{
    string[] personDescription = people[i].Split("=");
    Person person = new Person(personDescription[0], Convert.ToInt32(personDescription[1]));
    persons.Add(person);
}

string[] productsString = Console.ReadLine().Split(";");
List<Product> products = new List<Product>();
for (int i = 0; i < productsString.Length; i++)
{
    string[] productDescription = productsString[i].Split("=");
    Product product = new Product(productDescription[0], Convert.ToInt32(productDescription[1]));
    products.Add(product);
}

string Command = Console.ReadLine();
while (!Command.Equals("END"))
{
    string[] purchase = Command.Split(" ");
    persons.Find(x => x.name.Equals(purchase[0])).buyProduct(products.Find(x => x.name.Equals(purchase[1])));

}

foreach (Person person in persons)
{
    person.getAllProducts();
}
