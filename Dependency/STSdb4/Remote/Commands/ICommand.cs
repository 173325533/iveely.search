﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iveely.WaterfallTree;

namespace Iveely.Remote.Commands
{
    public interface ICommand
    {
        int Code { get; }
        bool IsSynchronous { get; }
    }
}
