﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disco.Data.Repository.Monitor
{
    public enum RepositoryMonitorEventType
    {
        Added = 0,
        Deleted = 1,
        Modified = 2,
        Detached = 3,
        Unchanged = 4
    }
}
