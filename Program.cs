namespace Practice__Aggregation_and_Containment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instructor will = new Instructor("Will", "Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming","124","J102",will );

            Student stu1 = new Student("Jennifer", "Key", 100, 90);
            prog124.AddStudent(stu1);

            Student stu2 = new Student("Joseph", "Dam", 98, 87);
            prog124.AddStudent(stu2);

            Student stu3 = new Student("Ricky", "Mckoy", 102, 95);
            prog124.AddStudent(stu3);

            Console.WriteLine(prog124);
            Console.WriteLine(will );
            Console.WriteLine(stu1);
            Console.WriteLine(stu2);
            Console.WriteLine(stu3);

        }
    }
}