using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_implementação_do_diagrama
{
    internal class Subject
    {
        public String SubjectName {  get; set; }
        public int SubjectId {  get; set; }
        public List<Student> Students { get; set; }
        public Subject(string subjectname,int SubejectID) 
        {
            SubjectName = subjectname;
            SubjectId = SubejectID;
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
    }
}
