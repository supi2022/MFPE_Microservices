﻿using AuditChecklistModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditChecklistModule.Repository
{
    public interface IChecklist
    {
        public List<Questions> GetQuestions(AuditType auditType);        
    }
}
