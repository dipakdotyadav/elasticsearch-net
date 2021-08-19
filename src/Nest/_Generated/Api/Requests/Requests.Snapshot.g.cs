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
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Snapshot
{
	[ConvertAs(typeof(CleanupRepositoryRequest))]
	public partial interface ICleanupRepositoryRequest : IRequest<CleanupRepositoryRequestParameters>
	{
	}

	public partial class CleanupRepositoryRequest : PlainRequestBase<CleanupRepositoryRequestParameters>, ICleanupRepositoryRequest
	{
		protected ICleanupRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCleanupRepository;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}/_cleanup</summary>
        public CleanupRepositoryRequest(Nest.Name repository) : base(r => r.Required("repository", repository))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	[ConvertAs(typeof(CloneRequest))]
	public partial interface ICloneRequest : IRequest<CloneRequestParameters>
	{
	}

	public partial class CloneRequest : PlainRequestBase<CloneRequestParameters>, ICloneRequest
	{
		protected ICloneRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotClone;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}/{snapshot}/_clone/{target_snapshot}</summary>
        public CloneRequest(Nest.Name repository, Nest.Name snapshot, Nest.Name target_snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot).Required("target_snapshot", target_snapshot))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	[ConvertAs(typeof(CreateRequest))]
	public partial interface ICreateRequest : IRequest<CreateRequestParameters>
	{
	}

	public partial class CreateRequest : PlainRequestBase<CreateRequestParameters>, ICreateRequest
	{
		protected ICreateRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}/{snapshot}</summary>
        public CreateRequest(Nest.Name repository, Nest.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }

		[JsonPropertyName("ignore_unavailable")]
		public bool? IgnoreUnavailable
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("include_global_state")]
		public bool? IncludeGlobalState
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("feature_states")]
		public IReadOnlyCollection<string>? FeatureStates
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("partial")]
		public bool? Partial
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(CreateRepositoryRequest))]
	public partial interface ICreateRepositoryRequest : IRequest<CreateRepositoryRequestParameters>
	{
	}

	public partial class CreateRepositoryRequest : PlainRequestBase<CreateRepositoryRequestParameters>, ICreateRepositoryRequest
	{
		protected ICreateRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreateRepository;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}</summary>
        public CreateRepositoryRequest(Nest.Name repository) : base(r => r.Required("repository", repository))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? Verify { get => Q<bool?>("verify"); set => Q("verify", value); }

		[JsonPropertyName("settings")]
		public Nest.Snapshot.RepositorySettings Settings
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(DeleteRequest))]
	public partial interface IDeleteRequest : IRequest<DeleteRequestParameters>
	{
	}

	public partial class DeleteRequest : PlainRequestBase<DeleteRequestParameters>, IDeleteRequest
	{
		protected IDeleteRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}/{snapshot}</summary>
        public DeleteRequest(Nest.Name repository, Nest.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	[ConvertAs(typeof(DeleteRepositoryRequest))]
	public partial interface IDeleteRepositoryRequest : IRequest<DeleteRepositoryRequestParameters>
	{
	}

	public partial class DeleteRepositoryRequest : PlainRequestBase<DeleteRepositoryRequestParameters>, IDeleteRepositoryRequest
	{
		protected IDeleteRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDeleteRepository;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}</summary>
        public DeleteRepositoryRequest(Nest.Names repository) : base(r => r.Required("repository", repository))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	[ConvertAs(typeof(GetRequest))]
	public partial interface IGetRequest : IRequest<GetRequestParameters>
	{
	}

	public partial class GetRequest : PlainRequestBase<GetRequestParameters>, IGetRequest
	{
		protected IGetRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}/{snapshot}</summary>
        public GetRequest(Nest.Name repository, Nest.Names snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }

		[JsonIgnore]
		public bool? IndexDetails { get => Q<bool?>("index_details"); set => Q("index_details", value); }
	}

	[ConvertAs(typeof(GetRepositoryRequest))]
	public partial interface IGetRepositoryRequest : IRequest<GetRepositoryRequestParameters>
	{
	}

	public partial class GetRepositoryRequest : PlainRequestBase<GetRepositoryRequestParameters>, IGetRepositoryRequest
	{
		protected IGetRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGetRepository;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_snapshot</summary>
        public GetRepositoryRequest() : base()
		{
		}

		///<summary>/_snapshot/{repository}</summary>
        public GetRepositoryRequest(Nest.Names? repository) : base(r => r.Optional("repository", repository))
		{
		}

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	[ConvertAs(typeof(RestoreRequest))]
	public partial interface IRestoreRequest : IRequest<RestoreRequestParameters>
	{
	}

	public partial class RestoreRequest : PlainRequestBase<RestoreRequestParameters>, IRestoreRequest
	{
		protected IRestoreRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotRestore;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}/{snapshot}/_restore</summary>
        public RestoreRequest(Nest.Name repository, Nest.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }

		[JsonPropertyName("ignore_index_settings")]
		public IReadOnlyCollection<string>? IgnoreIndexSettings
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ignore_unavailable")]
		public bool? IgnoreUnavailable
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("include_aliases")]
		public bool? IncludeAliases
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("include_global_state")]
		public bool? IncludeGlobalState
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_settings")]
		public Nest.IndexManagement.PutSettingsRequest? IndexSettings
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("partial")]
		public bool? Partial
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("rename_pattern")]
		public string? RenamePattern
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("rename_replacement")]
		public string? RenameReplacement
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(StatusRequest))]
	public partial interface IStatusRequest : IRequest<StatusRequestParameters>
	{
	}

	public partial class StatusRequest : PlainRequestBase<StatusRequestParameters>, IStatusRequest
	{
		protected IStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_snapshot/_status</summary>
        public StatusRequest() : base()
		{
		}

		///<summary>/_snapshot/{repository}/_status</summary>
        public StatusRequest(Nest.Name? repository) : base(r => r.Optional("repository", repository))
		{
		}

		///<summary>/_snapshot/{repository}/{snapshot}/_status</summary>
        public StatusRequest(Nest.Name? repository, Nest.Names? snapshot) : base(r => r.Optional("repository", repository).Optional("snapshot", snapshot))
		{
		}

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	[ConvertAs(typeof(VerifyRepositoryRequest))]
	public partial interface IVerifyRepositoryRequest : IRequest<VerifyRepositoryRequestParameters>
	{
	}

	public partial class VerifyRepositoryRequest : PlainRequestBase<VerifyRepositoryRequestParameters>, IVerifyRepositoryRequest
	{
		protected IVerifyRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotVerifyRepository;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_snapshot/{repository}/_verify</summary>
        public VerifyRepositoryRequest(Nest.Name repository) : base(r => r.Required("repository", repository))
		{
		}

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}
}