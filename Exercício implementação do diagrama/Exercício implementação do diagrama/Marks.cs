using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_implementação_do_diagrama
{
    internal class Marks
    {
        public Subject Subject { get; set; }
        public Student Student { get; set; }
        public int GradeValue { get; set; }

        public Marks(Subject subject, Student student, int gradeValue)
        {
            Subject = subject;
            Student = student;
            GradeValue = gradeValue;
        }
        public void AssignGrade(int grade)
        {
            GradeValue = grade;
        }

    }
}
