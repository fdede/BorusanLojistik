using System.Text.Json.Serialization;

namespace Borusan.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }

        public List<String> Errors { get; set; }

        public static CustomResponseDto<T> Success(int statusCode, bool isSuccess, T data)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, IsSuccess = isSuccess, Data = data };
        }

        public static CustomResponseDto<T> Success(int statusCode, bool isSuccess)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, IsSuccess = isSuccess };
        }

        public static CustomResponseDto<T> Fail(int statusCode, bool isSuccess, List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, IsSuccess = isSuccess, Errors = errors };
        }

        public static CustomResponseDto<T> Fail(int statusCode, bool isSuccess, string error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, IsSuccess = isSuccess, Errors = new List<string> { error } };
        }

    }
}
