﻿using KodElan_Api.Contexts;
using KodElan_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Abstractions
{
    public class OperatingModeRepository : GeneralRepository<OperatingMode>, IOperatingModeRepository
    {
        private readonly KodElanContext db;

        public OperatingModeRepository(KodElanContext db): base(db)
        {
            this.db = db;
        }
    }
}
