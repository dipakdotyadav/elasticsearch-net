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
namespace Elastic.Clients.Elasticsearch.Xpack.Usage
{
	public partial class Analytics : Xpack.Usage.Base
	{
		[JsonPropertyName("stats")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.AnalyticsStatistics Stats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Base
	{
		[JsonPropertyName("available")]
		public bool Available
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("enabled")]
		public bool Enabled
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class BaseUrlConfig
	{
		[JsonPropertyName("url_name")]
		public string UrlName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("url_value")]
		public string UrlValue
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Ccr : Xpack.Usage.Base
	{
		[JsonPropertyName("auto_follow_patterns_count")]
		public int AutoFollowPatternsCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("follower_indices_count")]
		public int FollowerIndicesCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DataStreams : Xpack.Usage.Base
	{
		[JsonPropertyName("indices_count")]
		public long IndicesCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DataTiers : Xpack.Usage.Base
	{
		[JsonPropertyName("data_cold")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.DataTierPhaseStatistics DataCold
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_content")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.DataTierPhaseStatistics DataContent
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_frozen")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.DataTierPhaseStatistics? DataFrozen
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_hot")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.DataTierPhaseStatistics DataHot
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_warm")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.DataTierPhaseStatistics DataWarm
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Eql : Xpack.Usage.Base
	{
		[JsonPropertyName("features")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.EqlFeatures Features
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("queries")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Xpack.Usage.Query> Queries
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Flattened : Xpack.Usage.Base
	{
		[JsonPropertyName("field_count")]
		public int FieldCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class FrozenIndices : Xpack.Usage.Base
	{
		[JsonPropertyName("indices_count")]
		public long IndicesCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Ilm
	{
		[JsonPropertyName("policy_count")]
		public int PolicyCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("policy_stats")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Xpack.Usage.IlmPolicyStatistics> PolicyStats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class IlmPolicyStatistics
	{
		[JsonPropertyName("indices_managed")]
		public int IndicesManaged
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("phases")]
		public Elastic.Clients.Elasticsearch.Ilm.Phases Phases
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class KibanaUrlConfig : Xpack.Usage.BaseUrlConfig
	{
		[JsonPropertyName("time_range")]
		public string? TimeRange
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MachineLearning : Xpack.Usage.Base
	{
		[JsonPropertyName("datafeeds")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Xpack.Usage.Datafeed> Datafeeds
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_frame_analytics_jobs")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.MlDataFrameAnalyticsJobs DataFrameAnalyticsJobs
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("inference")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.MlInference Inference
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("jobs")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Ml.Job> Jobs
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node_count")]
		public int NodeCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Monitoring : Xpack.Usage.Base
	{
		[JsonPropertyName("collection_enabled")]
		public bool CollectionEnabled
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("enabled_exporters")]
		public Dictionary<string, long> EnabledExporters
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Realm : Xpack.Usage.Base
	{
		[JsonPropertyName("cache")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Xpack.Usage.RealmCache>? Cache
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("has_authorization_realms")]
		public IReadOnlyCollection<bool>? HasAuthorizationRealms
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("has_default_username_pattern")]
		public IReadOnlyCollection<bool>? HasDefaultUsernamePattern
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("has_truststore")]
		public IReadOnlyCollection<bool>? HasTruststore
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("is_authentication_delegated")]
		public IReadOnlyCollection<bool>? IsAuthenticationDelegated
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public IReadOnlyCollection<string>? Name
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("order")]
		public IReadOnlyCollection<long>? Order
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("size")]
		public IReadOnlyCollection<long>? Size
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RuntimeFieldTypes : Xpack.Usage.Base
	{
		[JsonPropertyName("field_types")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Xpack.Usage.RuntimeFieldsType> FieldTypes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SearchableSnapshots : Xpack.Usage.Base
	{
		[JsonPropertyName("full_copy_indices_count")]
		public int? FullCopyIndicesCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices_count")]
		public int IndicesCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shared_cache_indices_count")]
		public int? SharedCacheIndicesCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Security : Xpack.Usage.Base
	{
		[JsonPropertyName("anonymous")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.FeatureToggle Anonymous
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("api_key_service")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.FeatureToggle ApiKeyService
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("audit")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Audit Audit
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fips_140")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.FeatureToggle Fips140
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ipfilter")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.IpFilter Ipfilter
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("operator_privileges")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base OperatorPrivileges
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("realms")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Xpack.Usage.Realm> Realms
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("role_mapping")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Xpack.Usage.RoleMapping> RoleMapping
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("roles")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.SecurityRoles Roles
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ssl")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Ssl Ssl
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("system_key")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.FeatureToggle? SystemKey
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("token_service")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.FeatureToggle TokenService
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Slm : Xpack.Usage.Base
	{
		[JsonPropertyName("policy_count")]
		public int? PolicyCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("policy_stats")]
		public Elastic.Clients.Elasticsearch.Slm.Statistics? PolicyStats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Sql : Xpack.Usage.Base
	{
		[JsonPropertyName("features")]
		public Dictionary<string, int> Features
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("queries")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Xpack.Usage.Query> Queries
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Vector : Xpack.Usage.Base
	{
		[JsonPropertyName("dense_vector_dims_avg_count")]
		public int DenseVectorDimsAvgCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("dense_vector_fields_count")]
		public int DenseVectorFieldsCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sparse_vector_fields_count")]
		public int? SparseVectorFieldsCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Watcher : Xpack.Usage.Base
	{
		[JsonPropertyName("count")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Counter Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("execution")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.WatcherActions Execution
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("watch")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.WatcherWatch Watch
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