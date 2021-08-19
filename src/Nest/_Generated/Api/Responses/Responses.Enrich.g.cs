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
namespace Nest.Enrich
{
	public partial class DeletePolicyResponse : AcknowledgedResponseBase
	{
	}

	public partial class ExecutePolicyResponse : ResponseBase
	{
		[JsonPropertyName("status")]
		public Nest.Enrich.ExecutePolicy.ExecuteEnrichPolicyStatus Status
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("task_id")]
		public Nest.TaskId? TaskId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetPolicyResponse : ResponseBase
	{
		[JsonPropertyName("policies")]
		public IReadOnlyCollection<Nest.Enrich.Summary> Policies
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PutPolicyResponse : AcknowledgedResponseBase
	{
	}

	public partial class StatsResponse : ResponseBase
	{
		[JsonPropertyName("coordinator_stats")]
		public IReadOnlyCollection<Nest.Enrich.Stats.CoordinatorStats> CoordinatorStats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("executing_policies")]
		public IReadOnlyCollection<Nest.Enrich.Stats.ExecutingPolicy> ExecutingPolicies
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