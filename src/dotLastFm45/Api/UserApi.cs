//-----------------------------------------------------------------------
// <copyright file="TagApi.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using DotLastFm45.Api.Rest;
using DotLastFm45.Models;
using DotLastFm45.Models.Wrappers;
using dotLastFm45.Api;
using dotLastFm45.Models;

namespace DotLastFm45.Api
{
	/// <summary>
	///     Last.fm Tag API
	/// </summary>
	public class UserApi : LastFmApiBase, IUserApi
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="UserApi" /> class.
		/// </summary>
		/// <param name="api">The API wrapper.</param>
		public UserApi(ILastFmApi api)
			: base(api)
		{
		}

		/// <summary>
		///     Get the top tracks of this user, ordered by play count.
		/// </summary>
		/// <param name="user">The user name.</param>
		/// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
		/// <returns>
		///     List of Artist objects.
		/// </returns>
		public IEnumerable<UserTopArtist> GetWeeklyTopArtists(string user, int limit)
		{
			FluentRestWrapper call = Rest.Method("user.getTopArtists").AddParam("user", user).AddParam("period", "7day");

			if (limit > 0)
			{
				call.AddParam("limit", limit);
			}

			var wrapper = call.Execute<UserTopArtistWrapper>();

			if (wrapper != null)
			{
				return wrapper.TopArtists;
			}

			return null;
		}
	}
}