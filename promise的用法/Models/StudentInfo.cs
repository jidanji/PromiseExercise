using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace promise的用法.Models
{
    public class StudentInfo
    {
        public string Name { get; set; }
        public Guid Id
        {
            get
            {
                return Guid.NewGuid();
            }
        }
    }
}