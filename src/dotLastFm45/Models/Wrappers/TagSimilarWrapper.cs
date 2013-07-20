//-----------------------------------------------------------------------
// <copyright file="TagSimilarWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using RestSharp.Deserializers;

namespace DotLastFm45.Models.Wrappers
{
	/// <summary>
	///     Tag similar wrapper
	/// </summary>
	public class TagSimilarWrapper
	{
		/// <summary>
		///     Gets or sets the similar tags.
		/// </summary>
		/// <value>
		///     The similar tags.
		/// </value>
		[DeserializeAs(Name = "similartags")]
		public List<Tag> SimilarTags { get; set; }
	}
}