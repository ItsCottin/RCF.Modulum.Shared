using System.Collections.Generic;

namespace modulum.Shared.Wrapper
{
    public interface IResult
    {
        List<string> Messages { get; set; }

        bool Succeeded { get; set; }

        Dictionary<string, object> Fields { get; set; }
    }

    public interface IResult<out T> : IResult
    {
        T Data { get; }
    }
}