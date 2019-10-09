﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public interface IStudentRepsitory
    {
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudents();
    }
}
