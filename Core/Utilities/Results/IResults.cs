using System;
namespace Core.Utilities.Results
{
    public interface IResults
    {
        bool Success { get; }

        string Message { get; }
    }
}

