public class ProgramStruct {
    struct Employee {
        public string firstName;
        public string lastName;
        public int age;
        public float completedTraining;
    }
    public static void Main(string[] args){

        Employee employee1;

        Console.WriteLine("What is your firstName?");
        employee1.firstName = Console.ReadLine();
        Console.WriteLine("What is yourlastName?");
        employee1.lastName = Console.ReadLine();
        Console.WriteLine("How old are you?");
        employee1.age = int.Parse(Console.ReadLine());
        Console.WriteLine("Do you completed the training?");
        employee1.completedTraining = float.Parse(Console.ReadLine());
        Console.WriteLine("You entered");
        Console.WriteLine("firstName: "+ employee1.firstName);
        Console.WriteLine("lastName: "+ employee1.lastName);
        Console.WriteLine("age: "+ employee1.age);
        Console.WriteLine("completedTraining?: "+ employee1.completedTraining);
        }
}
