//-----------------------------------------------------------------------
// <copyright file="AlbumApiTest.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using DotLastFm45.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotLastFm45;

namespace doLastFmTests
{
	/// <summary>
	///     Test for Last.fm's Album methods
	/// </summary>
	[TestClass]
	public class AlbumApiTest
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="AlbumApiTest" /> class.
		/// </summary>
		public AlbumApiTest()
		{
			Api = new LastFmApi(new TestLastFmConfig());
		}

		/// <summary>
		///     Gets or sets the API.
		/// </summary>
		/// <value>
		///     The API.
		/// </value>
		private LastFmApi Api { get; set; }

		/// <summary>
		///     Album.getInfo method.
		/// </summary>
		[TestMethod]
		public void AlbumGetInfo()
		{
			const string artist = "Moby";
			const string albumName = "Play";
			AlbumWithDetails album = Api.Album.GetInfo(albumName, artist);
			Assert.IsNotNull(album);
			Assert.AreEqual(albumName, album.Name);
			Assert.IsNotNull(album.Tracks);
			Assert.AreEqual(artist, album.ArtistName);
			Assert.IsNotNull(album.Tags);
			Assert.IsNotNull(album.Wiki);
		}

		/// <summary>
		///     Album.getTopTags method.
		/// </summary>
		[TestMethod]
		public void AlbumGetTopTags()
		{
			IEnumerable<TopTag> list = Api.Album.GetTopTags("Moby", "Play");
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}
	}
}