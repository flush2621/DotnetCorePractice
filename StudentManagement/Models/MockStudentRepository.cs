using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class MockStudentRepository : IStudentRepsitory
    {
        private List<Student> _studentList;

        public MockStudentRepository()
        {
            _studentList = new List<Student>()
            {
                new Student() { Id = 1, Name = "张三", ClassName = "三年级", Email = "6651815@qq.com" },
                new Student() { Id = 2, Name = "李四", ClassName = "二年级", Email = "winflush@163.com" },
                new Student() { Id = 3, Name = "王五", ClassName = "二年级", Email = "winflush@gmail.com" },
            };
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }

        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(a => a.Id == id);
        }
    }
}
