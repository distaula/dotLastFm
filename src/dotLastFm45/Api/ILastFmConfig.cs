﻿//-----------------------------------------------------------------------
// <copyright file="ILastFmConfig.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm45.Api
{
	/// <summary>
	///     Last.fm configuration
	/// </summary>
	public interface ILastFmConfig
	{
		/// <summary>
		///     Gets the base Last.fm's URL.
		/// </summary>
		string BaseUrl { get; }

		/// <summary>
		///     Gets the Last.fm's API key.
		/// </summary>
		string ApiKey { get; }

		/// <summary>
		///     Gets the Last.fm's secret.
		/// </summary>
		string Secret { get; }

		/// <summary>
		///		Gets the verified username
		/// </summary>
		string Username { get; }
	}
}