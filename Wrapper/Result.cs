using System.Collections.Generic;
using System.Threading.Tasks;

namespace modulum.Shared.Wrapper
{
    public class Result : IResult
    {
        public Result()
        {
        }

        public List<string> Messages { get; set; } = new List<string>();

        public bool Succeeded { get; set; }

        public Dictionary<string, string> Fields { get; set; } = new();

        public static IResult Fail()
        {
            return new Result { Succeeded = false };
        }

        public static IResult Fail(string message)
        {
            return new Result { Succeeded = false, Messages = new List<string> { message } };
        }

        public static IResult Fail(List<string> messages)
        {
            return new Result { Succeeded = false, Messages = messages };
        }

        public static IResult Fail(Dictionary<string, string> fields) 
        {
            return new Result { Succeeded = false, Fields = fields };
        }

        public static IResult Fail(string message, Dictionary<string, string> fields)
        {
            return new Result { Messages = new List<string> { message }, Succeeded = false, Fields = fields };
        }

        public static IResult Fail(List<string> messages, Dictionary<string, string> fields)
        {
            return new Result { Messages = messages, Succeeded = false, Fields = fields };
        }

        public static Task<IResult> FailAsync()
        {
            return Task.FromResult(Fail());
        }

        public static Task<IResult> FailAsync(string message)
        {
            return Task.FromResult(Fail(message));
        }

        public static Task<IResult> FailAsync(List<string> messages)
        {
            return Task.FromResult(Fail(messages));
        }

        public static Task<IResult> FailAsync(Dictionary<string, string> fields)
        {
            return Task.FromResult(Fail(fields));
        }

        public static Task<IResult> FailAsync(string message, Dictionary<string, string> fields)
        {
            return Task.FromResult(Fail(message, fields));
        }

        public static Task<IResult> FailAsync(List<string> messages, Dictionary<string, string> fields)
        {
            return Task.FromResult(Fail(messages, fields));
        }

        public static IResult Success()
        {
            return new Result { Succeeded = true };
        }

        public static IResult Success(string message)
        {
            return new Result { Succeeded = true, Messages = new List<string> { message } };
        }

        public static IResult Success(Dictionary<string, string> fields) {
            return new Result { Succeeded = true, Fields = fields };
        }

        public static IResult Success(string message, Dictionary<string, string> fields)
        {
            return new Result { Messages = new List<string> { message }, Succeeded = true, Fields = fields };
        }

        public static IResult Success(List<string> messages, Dictionary<string, string> fields)
        {
            return new Result { Messages = messages, Succeeded = true, Fields = fields };
        }

        public static Task<IResult> SuccessAsync()
        {
            return Task.FromResult(Success());
        }

        public static Task<IResult> SuccessAsync(string message)
        {
            return Task.FromResult(Success(message));
        }

        public static Task<IResult> SuccessAsync(Dictionary<string, string> fields) {
            return Task.FromResult(Success(fields));
        }

        public static Task<IResult> SuccessAsync(string message, Dictionary<string, string> fields)
        {
            return Task.FromResult(Success(message, fields));
        }

        public static Task<IResult> SuccessAsync(List<string> messages, Dictionary<string, string> fields)
        {
            return Task.FromResult(Success(messages, fields));
        }
    }

    public class Result<T> : Result, IResult<T>
    {
        public Result()
        {
        }

        public T Data { get; set; }

        public new static Result<T> Fail()
        {
            return new Result<T> { Succeeded = false };
        }

        public new static Result<T> Fail(string message)
        {
            return new Result<T> { Succeeded = false, Messages = new List<string> { message } };
        }

        public new static Result<T> Fail(List<string> messages)
        {
            return new Result<T> { Succeeded = false, Messages = messages };
        }

        public new static Result<T> Fail(Dictionary<string, string> fields) { 
            return new Result<T> { Succeeded = false, Fields = fields };
        }

        public new static Result<T> Fail(string message, Dictionary<string, string> fields)
        {
            return new Result<T> { Messages = new List<string> { message }, Succeeded = false, Fields = fields };
        }

        public new static Result<T> Fail(List<string> messages, Dictionary<string, string> fields)
        {
            return new Result<T> { Messages = messages, Succeeded = false, Fields = fields };
        }

        public new static Task<Result<T>> FailAsync()
        {
            return Task.FromResult(Fail());
        }

        public new static Task<Result<T>> FailAsync(string message)
        {
            return Task.FromResult(Fail(message));
        }

        public new static Task<Result<T>> FailAsync(List<string> messages)
        {
            return Task.FromResult(Fail(messages));
        }

        public new static Task<Result<T>> FailAsync(Dictionary<string, string> fields)
        { 
            return Task.FromResult(Fail(fields));
        }

        public new static Task<Result<T>> FailAsync(string message, Dictionary<string, string> fields)
        {
            return Task.FromResult(Fail(message, fields));
        }

        public new static Task<Result<T>> FailAsync(List<string> messages, Dictionary<string, string> fields)
        {
            return Task.FromResult(Fail(messages, fields));
        }

        public new static Result<T> Success()
        {
            return new Result<T> { Succeeded = true };
        }

        public new static Result<T> Success(string message)
        {
            return new Result<T> { Succeeded = true, Messages = new List<string> { message } };
        }

        public static Result<T> Success(T data)
        {
            return new Result<T> { Succeeded = true, Data = data };
        }

        public static Result<T> Success(T data, string message)
        {
            return new Result<T> { Succeeded = true, Data = data, Messages = new List<string> { message } };
        }

        public static Result<T> Success(T data, List<string> messages)
        {
            return new Result<T> { Succeeded = true, Data = data, Messages = messages };
        }

        public static Result<T> Success(T data, Dictionary<string, string> fields)
        { 
            return new Result<T> { Succeeded = true, Data = data, Fields = fields };
        }

        public static Result<T> Success(T data, Dictionary<string, string> fields, string message)
        {
            return new Result<T> { Succeeded = true, Data = data, Fields = fields, Messages = new List<string> { message } };
        }

        public new static Task<Result<T>> SuccessAsync()
        {
            return Task.FromResult(Success());
        }

        public new static Task<Result<T>> SuccessAsync(string message)
        {
            return Task.FromResult(Success(message));
        }

        public static Task<Result<T>> SuccessAsync(T data)
        {
            return Task.FromResult(Success(data));
        }

        public static Task<Result<T>> SuccessAsync(T data, string message)
        {
            return Task.FromResult(Success(data, message));
        }

        public static Task<Result<T>> SuccessAsync(T data, Dictionary<string, string> fields)
        { 
            return Task.FromResult(Success(data, fields));
        }

        public static Task<Result<T>> SuccessAsync(T data, Dictionary<string, string> fields, string message)
        {
            return Task.FromResult(Success(data, fields, message));
        }
    }
}