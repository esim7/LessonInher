namespace InheretanceLesson
{
    public sealed class Teacher : Person //sealed запрещает наследование от этого класса в будущем
    {
        //делегация на конструктор базового класса
        public Teacher(int id, string name, string phoneN) : base (id, name, phoneN)
        {
           
        }

        public string Subject { get; set; }
        //NEW указывает на то что вы понимаете что перекрываете метод определенный в базовом классе
        public new string GetInfoAsString()
        {
            return $"{base.GetInfoAsString()},{Subject}";
        }
        //переопределение метода из базового класса
        //protected override string GetClassName()
        //{
        //    return "Teacher";
        //}
    }
}
