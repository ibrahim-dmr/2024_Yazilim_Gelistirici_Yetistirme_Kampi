
class ReferanceType
{
    static void Main(String[] args)
    {
        // int, decimal, float, enum, boolean --> value types
        int sayi1 = 10;
        int sayi2 = 20;

        sayi1 = sayi2;
        sayi2 = 100;

        Console.WriteLine("Sayı 1 :" + sayi1);

        //Arrays, class, interface --> Referance types
        int[] sayilar1 = { 1, 2, 3, 4, };
        int[] sayilar2 = { 10, 20, 30, 40 };

        sayilar1 = sayilar2;
        sayilar2[0] = 1000;

        Console.WriteLine("Sayilar1[0]: " + sayilar1[0]);



        Person person = new();
        Person person2 = new();
        person.FirstName = "İbrahim";

        person2 = person;
        person.FirstName = "Halil";
        Console.WriteLine("Person 2 First Name: " + person2.FirstName);

        Customer customer = new();
        customer.FirstName = "Nazım";
        customer.CreditCardNumber = "5124402545415";

        Employee employee = new();
        employee.FirstName = "Cemalettin Seber";

        Person person3 = customer;
        Console.WriteLine(person3.FirstName);

        // Boxing
        Console.WriteLine(((Customer)person3).CreditCardNumber);

        PersonManager personManager = new PersonManager();
        personManager.Add(person);
        personManager.Add(customer);
        personManager.Add(employee);

    }
}

// Base Class : Person
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);

    }
}