using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public DateTime UserDateOfBirth { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }
    }
}
