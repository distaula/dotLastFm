//-----------------------------------------------------------------------
// <copyright file="TagTopArtistWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using RestSharp.Deserializers;
using dotLastFm45.Api;
using dotLastFm45.Models;

namespace DotLastFm45.Models.Wrappers
{
	/// <summary>
	///     Wrapper for user's artist tracks
	/// </summary>
	public class UserArtistTracksWrapper
	{
		/// <summary>
		///     Gets or sets the artists of the tag.
		/// </summary>
		/// <value>
		///     The artists of the tag.
		/// </value>
		[DeserializeAs(Name = "artisttracks")]
		public List<ArtistTrack> ArtistTracks { get; set; }
	}
}