using Intro.Business;
using Intro.Entities;



CourseManager courseManager = new();
courseManager.GetAll();

Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "123455678901";
customer1.FirstName = "İbrahim";
customer1.LastName = "Demir";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "1215455221521";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "455245631";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "44854";
customer3.TaxNumber = "8548521";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "65240122";
customer4.TaxNumber = "4683542";


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}





