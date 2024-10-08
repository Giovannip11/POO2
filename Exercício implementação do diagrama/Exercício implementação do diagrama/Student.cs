using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_implementação_do_diagrama
{
    internal class Student
    {
        public List<Subject> Subjects { get; set; }
        public List<Marks> MarksList { get; set; }
        public int StudentID { get; set; }
        public DateTime DateOfBirth { get;set; }
        public int GroupID { get; set; }
        public string Name { get; set; }

        public Student (string name,int studentID,DateTime dateofbirth,int groupID)
        {
            Name = name;
            StudentID = studentID;
            DateOfBirth = dateofbirth;
            GroupID = groupID;
            Subjects = new List<Subject> ();
            MarksList = new List<Marks> ();
        }
        public void EnrollSubject(Subject subject)
        {
            Subjects.Add (subject);
            subject.AddStudent(this);
        }
        public void ViewGrades()
        {
            foreach(var mark in MarksList)
            {
                Console.WriteLine ($"Subject: {mark.Subject.SubjectName}, Grade: {mark.GradeValue}");
            }
        }
        public void AddGrade(int grade)
        {

        }
    }
}
