using System;
using System.Collections.Generic;
using System.Text;

namespace Project.CORE.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Messange { get; }
    }
}
