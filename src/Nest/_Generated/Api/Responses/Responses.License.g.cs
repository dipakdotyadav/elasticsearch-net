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
namespace Nest.License
{
	public partial class DeleteResponse : AcknowledgedResponseBase
	{
	}

	public partial class GetResponse : ResponseBase
	{
		[JsonPropertyName("license")]
		public Nest.License.Get.LicenseInformation License
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetBasicStatusResponse : ResponseBase
	{
		[JsonPropertyName("eligible_to_start_basic")]
		public bool EligibleToStartBasic
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GetTrialStatusResponse : ResponseBase
	{
		[JsonPropertyName("eligible_to_start_trial")]
		public bool EligibleToStartTrial
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PostResponse : ResponseBase
	{
		[JsonPropertyName("acknowledge")]
		public Nest.License.Post.Acknowledgement? Acknowledge
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("acknowledged")]
		public bool Acknowledged
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("license_status")]
		public Nest.License.LicenseStatus LicenseStatus
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PostStartBasicResponse : AcknowledgedResponseBase
	{
		[JsonPropertyName("acknowledge")]
		public Dictionary<string, Union<string, IReadOnlyCollection<string>>> Acknowledge
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("basic_was_started")]
		public bool BasicWasStarted
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("error_message")]
		public string ErrorMessage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PostStartTrialResponse : AcknowledgedResponseBase
	{
		[JsonPropertyName("error_message")]
		public string? ErrorMessage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("trial_was_started")]
		public bool TrialWasStarted
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public Nest.License.LicenseType Type
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