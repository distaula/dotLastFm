using System.Collections.Generic;
using DotLastFm45.Models;

namespace dotLastFm45.Models
{
	/// <summary>
	///     Top user artist
	/// </summary>
	public class UserTopArtist : Artist
	{
		/// <summary>
		///     Gets or sets a value indicating whether this <see cref="UserTopArtist" /> is streamable.
		/// </summary>
		/// <value>
		///     <c>true</c> if streamable; otherwise, <c>false</c>.
		/// </value>
		public bool Streamable { get; set; }

		/// <summary>
		///     Gets or sets the mb ID.
		/// </summary>
		/// <value>
		///     The valeu of mb ID.
		/// </value>
		public string MbId { get; set; }

		/// <summary>
		///     Gets or sets the rank of artist.
		/// </summary>
		/// <value>
		///     The rank of artist.
		/// </value>
		public int Rank { get; set; }

		/// <summary>
		///     Gets or sets the images collection.
		/// </summary>
		/// <value>
		///     The images collection.
		/// </value>
		public List<Image> Images { get; set; }

		/// <summary>
		///     Gets or sets the user's playcount.
		/// </summary>
		/// <value>
		///     The playcount.
		/// </value>
		public int PlayCount { get; set; }
	}
}