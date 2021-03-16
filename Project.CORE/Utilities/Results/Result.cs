using System;
using System.Collections.Generic;
using System.Text;

namespace Project.CORE.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success,string messange):this(success)
        {
            Messange = messange;
        }
        public Result(bool success)
        {
            Success = success;
        }



        public bool Success { get; }

        public string Messange { get; }
    }
}
