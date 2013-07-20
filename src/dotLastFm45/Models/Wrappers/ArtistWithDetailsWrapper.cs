//-----------------------------------------------------------------------
// <copyright file="ArtistWithDetailsWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using RestSharp.Deserializers;

namespace DotLastFm45.Models.Wrappers
{
	/// <summary>
	///     Artist with details wrapper
	/// </summary>
	public class ArtistWithDetailsWrapper
	{
		/// <summary>
		///     Gets or sets the artist object.
		/// </summary>
		/// <value>
		///     The artist object.
		/// </value>
		[DeserializeAs(Name = "artist")]
		public ArtistWithDetails Artist { get; set; }
	}
}