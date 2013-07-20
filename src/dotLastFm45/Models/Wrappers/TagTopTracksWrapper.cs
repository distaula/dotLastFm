//-----------------------------------------------------------------------
// <copyright file="TagTopTracksWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using RestSharp.Deserializers;

namespace DotLastFm45.Models.Wrappers
{
	/// <summary>
	///     Wrapper for tag's top tracks
	/// </summary>
	public class TagTopTracksWrapper
	{
		/// <summary>
		///     Gets or sets the tracks of the tag.
		/// </summary>
		/// <value>
		///     The tracks of the tag.
		/// </value>
		[DeserializeAs(Name = "toptracks")]
		public List<TagTopTrack> TopTracks { get; set; }
	}
}