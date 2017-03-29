//-----------------------------------------------------------------------
// <copyright file="Student.cs" company="XXXXXXX">
// Copyright (c) XXXXXXX. All rights reserved
// </copyright>
//-----------------------------------------------------------------------
namespace JsonConversions.Models
{
    /// <summary>
    /// Student model
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the student
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets age of the student
        /// </summary>
        public int Age { get; set; }
    }
}
