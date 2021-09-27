﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inv.DAL.Domain;
using Inv.API.Models;
using Inv.API.Models.CustomEntities;

namespace Inv.API.Models.CustomModel
{
    public class CustomG_USERS : SecurityClass
    {
        public G_USERS G_USERS { get; set; }
        public List<G_RoleUsers> G_RoleUsers { get; set; }
    }
}