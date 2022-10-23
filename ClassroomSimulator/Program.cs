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
            
            List<string>studentNames = StudentDataReader.GetStudentNamesFromFile("StudentData.txt");


        }

    }
}