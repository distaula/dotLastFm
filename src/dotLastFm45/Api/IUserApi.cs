using System.Collections.Generic;
using DotLastFm45.Models;
using dotLastFm45.Models;

namespace dotLastFm45.Api
{
	public interface IUserApi
	{
		/// <summary>
		///     Get the top artists for a user on Last.fm, ordered by listen count.
		/// </summary>
		/// <param name="user">The username.</param>
		/// <param name="limit">The number of top Artists for given user.</param>
		/// <returns>List of TopTags objects.</returns>
		IEnumerable<UserTopArtist> GetWeeklyTopArtists(string user, int limit);

		/// <summary>
		///     Get the top tracks of this user, ordered by play count.
		/// </summary>
		/// <param name="user">The user name.</param>
		/// <param name="artist">The number of results to fetch per page. Defaults to 50.</param>
		/// <returns>
		///     List of Track objects.
		/// </returns>
		IEnumerable<ArtistTrack> GetArtistTracks(string user, string artist);
	}
}