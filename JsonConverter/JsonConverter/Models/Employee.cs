//-----------------------------------------------------------------------
// <copyright file="Employee.cs" company="XXXXXXX">
// Copyright (c) XXXXXXX. All rights reserved
// </copyright>
//-----------------------------------------------------------------------
namespace JsonConverter.Models
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Employee model
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the employee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets age of the employee
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets list of departments
        /// </summary>
        public IList<Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets departments as string
        /// </summary>
        public string DepartmentsAsString
        {
            get
            {
                return this.DepartmentsString;
            }

            set
            {
                this.DepartmentsString = this.DeptsString();
            }
        }

        /// <summary>
        /// Gets or sets departments
        /// </summary>
        private string DepartmentsString { get; set; }

        /// <summary>
        /// Helper method to get departments as string
        /// </summary>
        /// <returns>Departments string</returns>
        private string DeptsString()
        {
            return string.Join("|", this.Departments.Select(x => x.Name).ToArray());
        }
    }
}
