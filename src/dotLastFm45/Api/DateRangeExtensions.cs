using System;

namespace DotLastFm45.Api
{
	public static class DateRangeExtensions
	{
		public static long ToUtcSeconds(this DateTime dateTime)
		{
			return Convert.ToInt64(dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
		}
	}
}