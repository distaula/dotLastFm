﻿//-----------------------------------------------------------------------
// <copyright file="LastFmApiException.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using DotLastFm45.Models;

namespace DotLastFm45.Api.Rest
{
	/// <summary>
	///     Last.fm API exception
	/// </summary>
	public class LastFmApiException : Exception
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="LastFmApiException" /> class.
		/// </summary>
		/// <param name="error">The last.fm error.</param>
		/// <param name="status">The last.fm status.</param>
		public LastFmApiException(LastFmError error, string status)
			: base(string.Format("Last.fm API Error ({0}): {1}", error.Code, error.Value))
		{
			LastFmError = error;
			LastFmStatus = status;
		}

		/// <summary>
		///     Gets the last.fm status.
		/// </summary>
		public string LastFmStatus { get; private set; }

		/// <summary>
		///     Gets the last.fm error.
		/// </summary>
		public LastFmError LastFmError { get; private set; }
	}
}