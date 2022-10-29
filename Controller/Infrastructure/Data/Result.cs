namespace Salary_management.Controller.Infrastructure.Data
{
    public class Result<T>
    {
		/// <summary>
		/// Kết quả có thành công hay không
		/// </summary>
		public bool Success { get; init; }

		/// <summary>
		/// Kết quả trả về
		/// </summary>
        public T? Payload { get; init; }

		/// <summary>
		/// Thông báo lỗi, là null nếu Success = true, là string nếu Success = false. Dùng string này để hiển thị lí do lỗi cho người dùng.
		/// </summary>
        public string? ErrorMessage { get; init; }
    }
}