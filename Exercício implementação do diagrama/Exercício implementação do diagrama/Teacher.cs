using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_implementação_do_diagrama
{
    internal class Teacher
    {
        public String Name { get; set; }
        public String Departament { get; set; }
        public int TeacherId {  get; set; }
        public int Group { get; set; }
        public List<Subject> Subjects { get; set; }

        public Teacher(string name,string departament,int teacherId,int group) 
        {
            Name = name;
            Departament = departament;
            TeacherId = teacherId;
            Group = group;
            Subjects = new List<Subject>();   
        }
        public Subject AssignSubject (Subject Subject) 
        {
            Subjects.Add(Subject);
            return Subject;

        }
        public int GradeStudent (Student student,int mark)
        {
            student.AddGrade(mark);
                return mark;
        }

    }
}
