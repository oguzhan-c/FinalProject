using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Hangi tipi döndürüceğini bana söyle
    public interface IDataResult<Tip> : IResult
    {
        Tip Data { get; } //Product Customer gibi hangi data 
    }
}
