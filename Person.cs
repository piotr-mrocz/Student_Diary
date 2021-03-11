using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Person
    {
        public string grade;
        public uint id_ucznia;
        public string name;
        public string surname;


        public Person()
        {
            grade = "1A";
            id_ucznia = 0;
            name = "Adam";
            surname = "Kowalski";
        }

        public Person(uint id_ucznia, string name, string surname, string grade)
        {
            this.id_ucznia = id_ucznia;
            this.name = name;
            this.surname = surname;
            this.grade = grade;
        }





    }
}
