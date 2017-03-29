//-----------------------------------------------------------------------
// <copyright file="AssistantProfessor.cs" company="XXXXXXX">
// Copyright (c) XXXXXXX. All rights reserved
// </copyright>
//-----------------------------------------------------------------------
namespace JsonConversions.Models
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Assistant professor model
    /// </summary>
    public class AssistantProfessor
    {
        /// <summary>
        /// Gets or sets identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the assistant professor
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets age of the assistant professor
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets list of departments
        /// </summary>
        public IList<Department> Departments { get; set; }

        /// <summary>
        /// Gets departments as string
        /// </summary>
        public string DepartmentsAsString
        {
            get
            {
                return this.DeptsString();
            }
        }

        /// <summary>
        /// Helper method get departments as string
        /// </summary>
        /// <returns>Departments string</returns>
        private string DeptsString()
        {
            return string.Join("|", this.Departments.Select(x => x.Name).ToArray());
        }
    }
}
