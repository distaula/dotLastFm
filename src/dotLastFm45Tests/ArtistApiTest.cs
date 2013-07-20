//-----------------------------------------------------------------------
// <copyright file="ArtistApiTest.cs" company="IxoneCz">
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
	///     Test for Last.fm's Artist methods
	/// </summary>
	[TestClass]
	public class ArtistApiTest
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ArtistApiTest" /> class.
		/// </summary>
		public ArtistApiTest()
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
		///     Artist.getInfo method.
		/// </summary>
		[TestMethod]
		public void ArtistGetInfo()
		{
			const string artistName = "Moby";
			ArtistWithDetails artist = Api.Artist.GetInfo(artistName);
			Assert.IsNotNull(artist);
			Assert.AreEqual(artistName, artist.Name);
			Assert.IsNotNull(artist.Tags);
			Assert.IsNotNull(artist.Stats);
			Assert.IsNotNull(artist.SimilarArtists);
			Assert.IsTrue(artist.SimilarArtists.Count > 0);
			Assert.IsNotNull(artist.Streamable);
		}

		/// <summary>
		///     Artist.getTopTags method.
		/// </summary>
		[TestMethod]
		public void ArtistGetTopTags()
		{
			IEnumerable<TopTag> list = Api.Artist.GetTopTags("Moby");
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}
	}
}