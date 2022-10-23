using ClassroomSimulator.Library;
namespace ClassroomSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj imie prowadzacego: ");
            string teacherName = Console.ReadLine();
            if(string.IsNullOrEmpty(teacherName))
            {
                Console.WriteLine("Imie jest nieprawidlowe");
                return;
            }


            Teacher teacher = new Teacher(teacherName);

            List<Student> students = StudentDataReader.GetStudentsFromFile("StudentData.txt");



        }

    }
}