//-----------------------------------------------------------------------
// <copyright file="TagApiTest.cs" company="IxoneCz">
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
	///     Test for Last.fm's Tag methods
	/// </summary>
	[TestClass]
	public class TagApiTest
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="TagApiTest" /> class.
		/// </summary>
		public TagApiTest()
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
		///     Tag.getTopArtists method.
		/// </summary>
		[TestMethod]
		public void TagGetTopArtists()
		{
			IEnumerable<TagTopArtist> list = Api.Tag.GetTopArtists("pop");
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}

		/// <summary>
		///     Tag.getTopAlbums method.
		/// </summary>
		[TestMethod]
		public void TagGetTopAlbums()
		{
			IEnumerable<TagTopAlbum> list = Api.Tag.GetTopAlbums("pop");
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}

		/// <summary>
		///     Tag.getTopTracks method.
		/// </summary>
		[TestMethod]
		public void TagGetTopTracks()
		{
			IEnumerable<TagTopTrack> list = Api.Tag.GetTopTracks("pop");
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}

		/// <summary>
		///     Tag.getTopTags method.
		/// </summary>
		[TestMethod]
		public void TagGetTopTags()
		{
			IEnumerable<TopTag> list = Api.Tag.GetTopTags();
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}

		/// <summary>
		///     Tag.getSimilar method.
		/// </summary>
		[TestMethod]
		public void TagGetSimilar()
		{
			IEnumerable<Tag> list = Api.Tag.GetSimilar("pop");
			Assert.IsNotNull(list);
			Assert.IsTrue(list.Any());
		}

		/// <summary>
		///     Tag.getInfo method.
		/// </summary>
		[TestMethod]
		public void TagGetInfo()
		{
			TagWithDetails list = Api.Tag.GetInfo("pop");
			Assert.IsNotNull(list);
			Assert.IsNotNull(list.Wiki);
			Assert.IsNotNull(list.Name);
			Assert.IsNotNull(list.Url);
		}
	}
}