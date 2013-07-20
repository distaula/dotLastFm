//-----------------------------------------------------------------------
// <copyright file="TagTopAlbumWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using RestSharp.Deserializers;

namespace DotLastFm45.Models.Wrappers
{
	/// <summary>
	///     Tag top album wrapper
	/// </summary>
	public class TagTopAlbumWrapper
	{
		/// <summary>
		///     Gets or sets the top albums.
		/// </summary>
		/// <value>
		///     The top albums.
		/// </value>
		[DeserializeAs(Name = "topalbums")]
		public List<TagTopAlbum> TopAlbums { get; set; }
	}
}