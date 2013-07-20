//-----------------------------------------------------------------------
// <copyright file="ArtistSimilarArtist.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace DotLastFm45.Models
{
	/// <summary>
	///     Last.fm artist
	/// </summary>
	public class ArtistSimilarArtist : Artist
	{
		/// <summary>
		///     Gets or sets the images collection.
		/// </summary>
		/// <value>
		///     The images collection.
		/// </value>
		public List<Image> Images { get; set; }
	}
}