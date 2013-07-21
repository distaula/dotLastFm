using System;

namespace DotLastFm45.Api
{
	public static class Periods
	{
		public const string Overall = "Overall";
		public const string SevenDay = "7day";
		public const string OneMonth = "1month";
		public const string ThreeMonth = "3month";
		public const string SixMonth = "6month";
		public const string TwelveMonth = "12month";

		public static TimeSpan Now { get { return DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)); } }
		public static long Week { get { return DateTime.UtcNow.Subtract(TimeSpan.FromDays(7)).ToUtcSeconds(); } }
	}
}