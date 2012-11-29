using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKArch.Domain
{
    /// <summary>
    /// Sample Domain Entity
    /// </summary>
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual bool Status { get; set; }
    }
}
