using System;

namespace InheretanceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher(1, "empty", "empty");

            Student student = new Student(1, "empty", "empty", 777);
            Person person = new Person(1, "empty", "empty");

            var people = new Person[] { teacher, student, person };

            if (teacher is Teacher)
            {
                (teacher as Teacher).Subject = "Matematika";
            }
            teacher.Id = 1;
            teacher.FullName = "Олег Сергеевич";
            teacher.Subject = "Informatika";
            teacher.PhoneNumber = "87782256552";
            Console.WriteLine(teacher.GetInfoAsString());
            Console.ReadKey();
        }
    }
}
