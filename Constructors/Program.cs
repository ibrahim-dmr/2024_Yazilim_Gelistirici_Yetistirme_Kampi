class Constructors
{
    static void Main(String[] args)
    {
        Customer customer = new Customer { Id = 1, FirstName = "İbrahim Halil", LastName = "Demir", City = "Balıkesir" };

        Customer customer2 = new Customer(2, "Can", "Yücel", "İstanbul");

        Console.WriteLine(customer2.FirstName);

    }

}

class Customer
{
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }


    public Customer()
    {
        Console.WriteLine("Yapıcı blok çalıştı");
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}