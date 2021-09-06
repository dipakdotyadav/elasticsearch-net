// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement.Segments
{
	public partial class IndexSegment
	{
		[JsonPropertyName("shards")]
		public Dictionary<string, Union<Elastic.Clients.Elasticsearch.IndexManagement.Segments.ShardsSegment, IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.Segments.ShardsSegment>>> Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Segment
	{
		[JsonPropertyName("attributes")]
		public Dictionary<string, string> Attributes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("committed")]
		public bool Committed
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("compound")]
		public bool Compound
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("deleted_docs")]
		public long DeletedDocs
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("generation")]
		public int Generation
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("memory_in_bytes")]
		public double MemoryInBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("num_docs")]
		public long NumDocs
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("search")]
		public bool Search
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("size_in_bytes")]
		public double SizeInBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionString Version
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ShardSegmentRouting
	{
		[JsonPropertyName("node")]
		public string Node
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary")]
		public bool Primary
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("state")]
		public string State
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ShardsSegment
	{
		[JsonPropertyName("num_committed_segments")]
		public int NumCommittedSegments
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("num_search_segments")]
		public int NumSearchSegments
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Segments.ShardSegmentRouting Routing
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("segments")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.Segments.Segment> Segments
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}