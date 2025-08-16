namespace Softmax.Logging
{

	/// <summary>
	/// A record to hold the resolved caller information.
	/// </summary>
	public class CallerInfo
	{
		public string? MethodName { get; set; }
		public string? FilePath { get; set; }
		public int LineNumber { get; set; }

		public static readonly CallerInfo Empty = new CallerInfo()
		{
			MethodName = "N/A",
			FilePath = "N/A",
			LineNumber = 0
		};

		public override string ToString() => $"{MethodName} ({FilePath}:{LineNumber})";
	}
}
