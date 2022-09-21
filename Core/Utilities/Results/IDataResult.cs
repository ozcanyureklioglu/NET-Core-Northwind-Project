using System;
namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResults
    {
        T Data { get; }
         
    }
}

