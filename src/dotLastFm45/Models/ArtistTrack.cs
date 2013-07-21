using System;
using System.Collections.Generic;

namespace DotLastFm45.Models
{
	/// <summary>
	///     ArtistTrack
	/// </summary>
	public class ArtistTrack : Track
	{
		/// <summary>
		///     Gets or sets the artist name.
		/// </summary>
		/// <value>
		///     The artist name.
		/// </value>
		public string Artist { get; set; }

		/// <summary>
		///     Gets or sets the title of the album.
		/// </summary>
		/// <value>
		///     The title of the album.
		/// </value>
		public string Album { get; set; }

		/// <summary>
		///     Gets or sets the date of the last play.
		/// </summary>
		/// <value>
		///     The date of the track played.
		/// </value>
		public DateTime Date { get; set; }

		/// <summary>
		///     Gets or sets the images collection.
		/// </summary>
		/// <value>
		///     The images collection.
		/// </value>
		public List<Image> Images { get; set; }

		/// <summary>
		///     Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		///     A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return string.Format("{0} - {1}", Artist, Name);
		}
	}
}