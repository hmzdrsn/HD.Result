namespace HD.Result
{
    public sealed class Result<T>
    {
        public T? Data { get; set; }
        public List<string>? Messages { get; set; }
        public bool Status { get; set; }
        public static Result<T> Succeed()
        {
            return new Result<T>
            {
                Data = default,
                Messages = new List<string> { SuccessMessages.OperationSuccess },
                Status = true
            };
        }
        public static Result<T> Succeed(T? data, List<string>? messages,bool status=true)
        {
            return new Result<T>
            {
                Data = data,
                Messages = messages ?? new List<string> { SuccessMessages.OperationSuccess },
                Status = status
            };
        }

        public static Result<T> Succeed(T? data, string? message, bool status = true)
        {
            return new Result<T>
            {
                Data = data,
                Messages = new List<string> { message ?? SuccessMessages.OperationSuccess },
                Status = status
            };
        }

        public static Result<T> Succeed(T? data, bool status = true)
        {
            return new Result<T>
            {
                Data = data,
                Messages = new List<string> { SuccessMessages.OperationSuccess },
                Status = status
            };
        }

        public static Result<T> Succeed(List<string>? messages, bool status = true)
        {
            return new Result<T>
            {
                Data = default,
                Messages = messages ?? new List<string> { SuccessMessages.OperationSuccess },
                Status = status
            };
        }

        public static Result<T> Succeed(string? message, bool status = true)
        {
            return new Result<T>
            {
                Data = default,
                Messages = new List<string> { message ?? SuccessMessages.OperationSuccess },
                Status = status
            };
        }
        public static Result<T> Failure()
        {
            return new Result<T>()
            {
                Data = default,
                Messages = new List<string> { ErrorMessages.OperationFailed },
                Status = false
            };
        }
        public static Result<T> Failure(List<string> errors, bool status = false)
        {
            return new Result<T>
            {
                Data = default,
                Messages = errors,
                Status = status
            };
        }

        public static Result<T> Failure(string error, bool status = false)
        {
            return new Result<T>
            {
                Data = default,
                Messages = new List<string> { error ?? ErrorMessages.OperationFailed },
                Status = status
            };
        }
    }

}
