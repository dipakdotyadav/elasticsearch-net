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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Ccr
{
	public partial class DeleteAutoFollowPatternResponse : AcknowledgedResponseBase
	{
	}

	public partial class FollowResponse : ResponseBase
	{
		[JsonPropertyName("follow_index_created")]
		public bool FollowIndexCreated
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("follow_index_shards_acked")]
		public bool FollowIndexShardsAcked
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_following_started")]
		public bool IndexFollowingStarted
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class FollowInfoResponse : ResponseBase
	{
		[JsonPropertyName("follower_indices")]
		public IReadOnlyCollection<Nest.Ccr.FollowInfo.FollowerIndex> FollowerIndices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class FollowStatsResponse : ResponseBase
	{
		[JsonPropertyName("indices")]
		public IReadOnlyCollection<Nest.Ccr.FollowIndexStats> Indices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ForgetFollowerResponse : ResponseBase
	{
		[JsonPropertyName("_shards")]
		public Nest.ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetAutoFollowPatternResponse : ResponseBase
	{
		[JsonPropertyName("patterns")]
		public IReadOnlyCollection<Nest.Ccr.GetAutoFollowPattern.AutoFollowPattern> Patterns
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PauseAutoFollowPatternResponse : AcknowledgedResponseBase
	{
	}

	public partial class PauseFollowResponse : AcknowledgedResponseBase
	{
	}

	public partial class PutAutoFollowPatternResponse : AcknowledgedResponseBase
	{
	}

	public partial class ResumeAutoFollowPatternResponse : AcknowledgedResponseBase
	{
	}

	public partial class ResumeFollowResponse : AcknowledgedResponseBase
	{
	}

	public partial class StatsResponse : ResponseBase
	{
		[JsonPropertyName("auto_follow_stats")]
		public Nest.Ccr.Stats.AutoFollowStats AutoFollowStats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("follow_stats")]
		public Nest.Ccr.Stats.FollowStats FollowStats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class UnfollowResponse : AcknowledgedResponseBase
	{
	}
}