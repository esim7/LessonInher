namespace InheretanceLesson
{
    public class Student : Person
    {
        public double AverageMark { get; set; }

        public Student(int id, string name, string phoneN, double average) : base(id, name, phoneN)
        {
            AverageMark = average;
        }
    }
}
