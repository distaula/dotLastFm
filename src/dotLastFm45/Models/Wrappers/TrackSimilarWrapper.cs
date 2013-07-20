//-----------------------------------------------------------------------
// <copyright file="TrackSimilarWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using RestSharp.Deserializers;

namespace DotLastFm45.Models.Wrappers
{
	/// <summary>
	///     Wrapper for similar tracks
	/// </summary>
	public class TrackSimilarWrapper
	{
		/// <summary>
		///     Gets or sets the similar tracks.
		/// </summary>
		/// <value>
		///     The similar tracks.
		/// </value>
		[DeserializeAs(Name = "similartracks")]
		public List<TrackSimilar> SimilarTracks { get; set; }
	}
}