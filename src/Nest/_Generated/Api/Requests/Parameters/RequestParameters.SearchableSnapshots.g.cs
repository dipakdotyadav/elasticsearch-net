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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.SearchableSnapshots
{
	public class ClearCacheRequestParameters : RequestParameters<ClearCacheRequestParameters>
	{
		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Pretty { get => Q<bool?>("pretty"); set => Q("pretty", value); }

		[JsonIgnore]
		public bool? Human { get => Q<bool?>("human"); set => Q("human", value); }
	}

	public class MountRequestParameters : RequestParameters<MountRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }

		[JsonIgnore]
		public string? Storage { get => Q<string?>("storage"); set => Q("storage", value); }
	}
}