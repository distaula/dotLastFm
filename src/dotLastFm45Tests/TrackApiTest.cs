//-----------------------------------------------------------------------
// <copyright file="TrackApiTest.cs" company="IxoneCz">
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
	///     Test for Last.fm's Track methods
	/// </summary>
	[TestClass]
	public class TrackApiTest
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="TrackApiTest" /> class.
		/// </summary>
		public TrackApiTest()
		{
			Api = new LastFmApi(new TestLastFmConfig());
		}

		/// <summary>
		///     Gets or sets the API.
		/// </summary>
		/// <value>
		///     The API wrapper.
		/// </value>
		private LastFmApi Api { get; set; }

		/// <summary>
		///     Track.getTopTags method.
		/// </summary>
		[TestMethod]
		public void TrackGetTopTags()
		{
			IEnumerable<TopTag> list = Api.Track.GetTopTags("Moby", "Porcelain");
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}

		/// <summary>
		///     Track.getInfo method.
		/// </summary>
		[TestMethod]
		public void TrackGetInfo()
		{
			const string artist = "Moby";
			const string title = "Porcelain";
			TrackWithDetails track = Api.Track.GetInfo(artist, title);
			Assert.IsNotNull(track);
			Assert.AreEqual(title, track.Name);
			Assert.IsNotNull(track.Album);
			Assert.IsNotNull(track.Artist);
			Assert.AreEqual(artist, track.Artist.Name);
			Assert.IsNotNull(track.Tags);
			Assert.IsNotNull(track.Streamable);
		}

		/// <summary>
		///     Track.getSimilar method.
		/// </summary>
		[TestMethod]
		public void TrackSimilar()
		{
			const string artist = "Moby";
			const string title = "Porcelain";
			IEnumerable<TrackSimilar> list = Api.Track.GetSimilar(artist, title);
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}
	}
}