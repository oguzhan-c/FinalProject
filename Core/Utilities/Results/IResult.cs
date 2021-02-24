using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Basic void operations have to get this interface for return  	feedback 
    public interface IResult
    {
        bool Success { get;} 
        String Message { get; }
    }
}
