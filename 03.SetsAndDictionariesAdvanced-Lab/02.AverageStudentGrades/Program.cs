namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (decimal grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():F2})");
            }
        }
    }
}