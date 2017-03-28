//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="XXXXXXX">
// Copyright (c) XXXXXXX. All rights reserved
// </copyright>
//-----------------------------------------------------------------------
namespace JsonConverter
{
    using System.Collections.Generic;
    using JsonConverter.Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Program to test JSON conversion scenarios
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Start of the project
        /// </summary>
        /// <param name="args">Arguments for the main</param>
        public static void Main(string[] args)
        {
            // 1. Json serialization and deserialization test for simple object
            Student student = new Student() { Id = 101, Name = "Dave", Age = 20 };
            string jsonStudent = JsonConvert.SerializeObject(student);
            student = JsonConvert.DeserializeObject<Student>(jsonStudent);

            // 2. Json serialization and deserialization test for complex object with nested objects
            Professor professor = new Professor() { Id = 201, Name = "John", Age = 20 };
            professor.Departments = new List<Department>
            {
                new Department() { Id = 301, Name = "Physics" },
                new Department() { Id = 302, Name = "Computers" }
            };
            string jsonProfessor = JsonConvert.SerializeObject(professor);
            professor = JsonConvert.DeserializeObject<Professor>(jsonProfessor);

            // 3. Json serialization and deserialization test for complex object with nested objects and read only property
            AssistantProfessor assistantProfessor = new AssistantProfessor() { Id = 201, Name = "John", Age = 20 };
            assistantProfessor.Departments = new List<Department>
            {
                new Department() { Id = 301, Name = "Physics" },
                new Department() { Id = 302, Name = "Computers" }
            };
            string jsonAssistantProfessor = JsonConvert.SerializeObject(assistantProfessor);
            assistantProfessor = JsonConvert.DeserializeObject<AssistantProfessor>(jsonAssistantProfessor);

            // 4. Json serialization and deserialization test for complex object with nested objects and read and write property
            // Notice difference in "DepartmentsAsString" property before and after serialization
            Employee employee = new Employee() { Id = 201, Name = "John", Age = 20 };
            employee.Departments = new List<Department>
            {
                new Department() { Id = 301, Name = "Physics" },
                new Department() { Id = 302, Name = "Computers" }
            };
            string jsonEmployee = JsonConvert.SerializeObject(employee);
            employee = JsonConvert.DeserializeObject<Employee>(jsonEmployee);
        }
    }
}
