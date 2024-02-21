class Interfaces
{
    // interface new'lenemez
    static void Main(string[] args)
    {

        // interface'ler onu implemente eden class'ın referansını tutabilirler
        //IPersonManager customerManager = new CustomerManager();
        //customerManager.Add();
        //customerManager.update();

        //IPersonManager employeeManager = new EmployeeManager();
        //employeeManager.Add();
        //employeeManager.update();

        ProjectManager  projectManager = new ProjectManager();
        projectManager.Add(new CustomerManager());
        

        projectManager.Add(new InternManager());


    }
}

interface IPersonManager
{
    // unimplemented operation
    void Add();
    void update();
        
}


// inherits --> class  ------------------ implements --> interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        // Müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void update()
    {
        Console.WriteLine("Müşteri güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        // Personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }

    public void update()
    {
        Console.WriteLine("Personel güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi");
    }

    public void update()
    {
        Console.WriteLine("Stajyer güncellendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

}