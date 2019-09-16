using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheretanceLesson
{
    public class Person : Entity
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int id, string name, string phoneN)
        {
            Id = id;
            FullName = name;
            PhoneNumber = phoneN;
        }
        public string GetInfoAsString()
        {
            return $"{Id} - {FullName}, t. {PhoneNumber}";
        }
        //virtual - слово, указывающее на то что метод ЖЕЛАТЕЛЬНО должен быть переопределен у наследников
        //метод чаще всего имеет реализацию по умолчанию
        protected virtual string GetClassName()
        {
            return "Person";
        }

        public override void Method()
        {
            //STUB;
        }
    }
}
