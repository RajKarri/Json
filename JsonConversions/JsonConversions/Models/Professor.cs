//-----------------------------------------------------------------------
// <copyright file="Professor.cs" company="XXXXXXX">
// Copyright (c) XXXXXXX. All rights reserved
// </copyright>
//-----------------------------------------------------------------------
namespace JsonConversions.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Professor model
    /// </summary>
    public class Professor
    {
        /// <summary>
        /// Gets or sets identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the professor
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets age of the professor
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets list of departments
        /// </summary>
        public IList<Department> Departments { get; set; }
    }
}
