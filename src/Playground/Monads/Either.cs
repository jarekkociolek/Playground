using System;

namespace Playground.Monads
{
    public class Either<TError, TResult>
    {
        private readonly TError Error;
        private readonly TResult Result;
        private readonly bool isError;

        public Either(TError left)
        {
            Error = left;
            isError = true;
        }

        public Either(TResult right)
        {
            Result = right;
            isError = false;
        }

        public T MatchWith<T>(Func<TError, T> error, Func<TResult, T> success) => isError ? error(Error) : success(Result);

        public static implicit operator Either<TError, TResult>(TError b) => new Either<TError, TResult>(b);

        public static implicit operator Either<TError, TResult>(TResult b) => new Either<TError, TResult>(b);
    }
}
