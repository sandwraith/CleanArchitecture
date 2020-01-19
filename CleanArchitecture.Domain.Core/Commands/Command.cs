﻿using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Core.Events;

namespace CleanArchitecture.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
