using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Admin:IEntity
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
