namespace Shared.EventOps.Result
{
    public class Result<T, E>
    {
        public readonly T? Value;
        public readonly E? Error;
        
        private bool _isSuccess;
        public bool IsFailure => !_isSuccess;

        private Result(T value)
        {
            _isSuccess = true;
            Value = value;
            Error = default;
        }

        private Result(E error)
        {
            _isSuccess = false;
            Value = default;
            Error = error;
        }

        public static Result<T, E> Success(T value) => new(value);
        public static Result<T, E> Failure(E error) => new(error);
    }
}
