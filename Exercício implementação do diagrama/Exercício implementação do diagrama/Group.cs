using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_implementação_do_diagrama
{
    internal class Group
    {
        public String GroupName {  get; set; }
        public int GroupID {  get; set; }
        public List<Student>Students { get; set; }
        public List<Teacher> Teachers { get; set; } 

        public Group(String groupName,int groupID)
        {
            GroupName = GroupName;
            GroupID = groupID;
            Students = new List<Student>();
            Teachers = new List<Teacher>();
             
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
    }
}
