// sealed
// this
// base
// new
// virtual
// override


using ConsoleApp4;

class Program
{
    
    static void Main(string[] args)
    {
        Student student1 = new Student(Guid.NewGuid(),"Nazim",new DateTime(1126,4,18),8.4f);
        Student student2 = new Student(Guid.NewGuid(),"Fazil",new DateTime(1127,12,31),4.4f);

        Console.WriteLine(student1);
        Console.WriteLine(student2);

        student1.CalculateAge();
    }
}