﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetAdmins();
    }
}