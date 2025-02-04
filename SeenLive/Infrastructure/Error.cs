﻿namespace SeenLive.Infrastructure
{
    public class Error
    {
        public string Message { get; init; } = string.Empty;
        public string Field { get; init; } = string.Empty;
        public ErrorType Type { get; init; } = ErrorType.Undefined;
    }

    public enum ErrorType
    {
        Undefined,
        NotFound,
        Unauthorized,
        BadRequest,
        InternalError,
        Validation
    }
}
