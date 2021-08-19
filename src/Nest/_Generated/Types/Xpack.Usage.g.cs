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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Xpack.Usage
{
	public partial class Analytics : Xpack.Usage.Base
	{
		[JsonPropertyName("stats")]
		public Nest.Xpack.Usage.AnalyticsStatistics Stats
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class AnalyticsStatistics
	{
		[JsonPropertyName("boxplot_usage")]
		public long BoxplotUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cumulative_cardinality_usage")]
		public long CumulativeCardinalityUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("moving_percentiles_usage")]
		public long MovingPercentilesUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("multi_terms_usage")]
		public long? MultiTermsUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("normalize_usage")]
		public long NormalizeUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("rate_usage")]
		public long RateUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("string_stats_usage")]
		public long StringStatsUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("top_metrics_usage")]
		public long TopMetricsUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("t_test_usage")]
		public long TTestUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Audit : Xpack.Usage.FeatureToggle
	{
		[JsonPropertyName("outputs")]
		public IReadOnlyCollection<string>? Outputs
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

	public partial class Counter
	{
		[JsonPropertyName("active")]
		public long Active
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public long Total
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

	public partial class DataTierPhaseStatistics
	{
		[JsonPropertyName("doc_count")]
		public long DocCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_count")]
		public long IndexCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node_count")]
		public long NodeCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary_shard_count")]
		public long PrimaryShardCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary_shard_size_avg_bytes")]
		public long PrimaryShardSizeAvgBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary_shard_size_mad_bytes")]
		public long PrimaryShardSizeMadBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary_shard_size_median_bytes")]
		public long PrimaryShardSizeMedianBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary_size_bytes")]
		public long PrimarySizeBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_shard_count")]
		public long TotalShardCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_size_bytes")]
		public long TotalSizeBytes
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
		public Nest.Xpack.Usage.DataTierPhaseStatistics DataCold
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_content")]
		public Nest.Xpack.Usage.DataTierPhaseStatistics DataContent
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_frozen")]
		public Nest.Xpack.Usage.DataTierPhaseStatistics? DataFrozen
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_hot")]
		public Nest.Xpack.Usage.DataTierPhaseStatistics DataHot
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_warm")]
		public Nest.Xpack.Usage.DataTierPhaseStatistics DataWarm
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Datafeed
	{
		[JsonPropertyName("count")]
		public long Count
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
		public Nest.Xpack.Usage.EqlFeatures Features
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("queries")]
		public Dictionary<string, Nest.Xpack.Usage.Query> Queries
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class EqlFeatures
	{
		[JsonPropertyName("event")]
		public uint Event
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join")]
		public uint Join
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("joins")]
		public Nest.Xpack.Usage.EqlFeaturesJoin Joins
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("keys")]
		public Nest.Xpack.Usage.EqlFeaturesKeys Keys
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pipes")]
		public Nest.Xpack.Usage.EqlFeaturesPipes Pipes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sequence")]
		public uint Sequence
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sequences")]
		public Nest.Xpack.Usage.EqlFeaturesSequences Sequences
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class EqlFeaturesJoin
	{
		[JsonPropertyName("join_queries_five_or_more")]
		public uint JoinQueriesFiveOrMore
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join_queries_four")]
		public uint JoinQueriesFour
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join_queries_three")]
		public uint JoinQueriesThree
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join_queries_two")]
		public uint JoinQueriesTwo
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join_until")]
		public uint JoinUntil
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class EqlFeaturesKeys
	{
		[JsonPropertyName("join_keys_five_or_more")]
		public uint JoinKeysFiveOrMore
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join_keys_four")]
		public uint JoinKeysFour
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join_keys_one")]
		public uint JoinKeysOne
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join_keys_three")]
		public uint JoinKeysThree
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("join_keys_two")]
		public uint JoinKeysTwo
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class EqlFeaturesPipes
	{
		[JsonPropertyName("pipe_head")]
		public uint PipeHead
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pipe_tail")]
		public uint PipeTail
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class EqlFeaturesSequences
	{
		[JsonPropertyName("sequence_maxspan")]
		public uint SequenceMaxspan
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sequence_queries_five_or_more")]
		public uint SequenceQueriesFiveOrMore
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sequence_queries_four")]
		public uint SequenceQueriesFour
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sequence_queries_three")]
		public uint SequenceQueriesThree
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sequence_queries_two")]
		public uint SequenceQueriesTwo
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sequence_until")]
		public uint SequenceUntil
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class FeatureToggle
	{
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
		public IReadOnlyCollection<Nest.Xpack.Usage.IlmPolicyStatistics> PolicyStats
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
		public Nest.Ilm.Phases Phases
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class IpFilter
	{
		[JsonPropertyName("http")]
		public bool Http
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport")]
		public bool Transport
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
		public Dictionary<string, Nest.Xpack.Usage.Datafeed> Datafeeds
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_frame_analytics_jobs")]
		public Nest.Xpack.Usage.MlDataFrameAnalyticsJobs DataFrameAnalyticsJobs
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("inference")]
		public Nest.Xpack.Usage.MlInference Inference
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("jobs")]
		public Dictionary<string, Nest.Ml.Job> Jobs
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

	public partial class MlCounter
	{
		[JsonPropertyName("count")]
		public long Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MlDataFrameAnalyticsJobs
	{
		[JsonPropertyName("_all")]
		public Nest.Xpack.Usage.MlDataFrameAnalyticsJobsCount All
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("analysis_counts")]
		public Nest.EmptyObject? AnalysisCounts
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("memory_usage")]
		public Nest.Xpack.Usage.MlDataFrameAnalyticsJobsMemory? MemoryUsage
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MlDataFrameAnalyticsJobsCount
	{
		[JsonPropertyName("count")]
		public long Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MlDataFrameAnalyticsJobsMemory
	{
		[JsonPropertyName("peak_usage_bytes")]
		public Nest.Ml.JobStatistics PeakUsageBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MlInference
	{
		[JsonPropertyName("ingest_processors")]
		public Dictionary<string, Nest.Xpack.Usage.MlInferenceIngestProcessor> IngestProcessors
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("trained_models")]
		public Nest.Xpack.Usage.MlInferenceTrainedModels TrainedModels
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MlInferenceIngestProcessor
	{
		[JsonPropertyName("num_docs_processed")]
		public Nest.Xpack.Usage.MlInferenceIngestProcessorCount NumDocsProcessed
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("num_failures")]
		public Nest.Xpack.Usage.MlInferenceIngestProcessorCount NumFailures
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pipelines")]
		public Nest.Xpack.Usage.MlCounter Pipelines
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("time_ms")]
		public Nest.Xpack.Usage.MlInferenceIngestProcessorCount TimeMs
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MlInferenceIngestProcessorCount
	{
		[JsonPropertyName("max")]
		public long Max
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("min")]
		public long Min
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sum")]
		public long Sum
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MlInferenceTrainedModels
	{
		[JsonPropertyName("_all")]
		public Nest.Xpack.Usage.MlCounter All
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("count")]
		public Nest.Xpack.Usage.MlInferenceTrainedModelsCount? Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("estimated_heap_memory_usage_bytes")]
		public Nest.Ml.JobStatistics? EstimatedHeapMemoryUsageBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("estimated_operations")]
		public Nest.Ml.JobStatistics? EstimatedOperations
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class MlInferenceTrainedModelsCount
	{
		[JsonPropertyName("classification")]
		public long Classification
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("other")]
		public long Other
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("prepackaged")]
		public long Prepackaged
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("regression")]
		public long Regression
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public long Total
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

	public partial class Query
	{
		[JsonPropertyName("count")]
		public int? Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("failed")]
		public int? Failed
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("paging")]
		public int? Paging
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public int? Total
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
		public IReadOnlyCollection<Nest.Xpack.Usage.RealmCache>? Cache
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

	public partial class RealmCache
	{
		[JsonPropertyName("size")]
		public long Size
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RoleMapping
	{
		[JsonPropertyName("enabled")]
		public int Enabled
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("size")]
		public int Size
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
		public IReadOnlyCollection<Nest.Xpack.Usage.RuntimeFieldsType> FieldTypes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RuntimeFieldsType
	{
		[JsonPropertyName("chars_max")]
		public long CharsMax
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("chars_total")]
		public long CharsTotal
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("count")]
		public long Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("doc_max")]
		public long DocMax
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("doc_total")]
		public long DocTotal
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index_count")]
		public long IndexCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("lang")]
		public IReadOnlyCollection<string> Lang
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("lines_max")]
		public long LinesMax
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("lines_total")]
		public long LinesTotal
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Nest.Field Name
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("scriptless_count")]
		public long ScriptlessCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shadowed_count")]
		public long ShadowedCount
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("source_max")]
		public long SourceMax
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("source_total")]
		public long SourceTotal
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
		public Nest.Xpack.Usage.FeatureToggle Anonymous
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("api_key_service")]
		public Nest.Xpack.Usage.FeatureToggle ApiKeyService
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("audit")]
		public Nest.Xpack.Usage.Audit Audit
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fips_140")]
		public Nest.Xpack.Usage.FeatureToggle Fips140
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ipfilter")]
		public Nest.Xpack.Usage.IpFilter Ipfilter
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("operator_privileges")]
		public Nest.Xpack.Usage.Base OperatorPrivileges
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("realms")]
		public Dictionary<string, Nest.Xpack.Usage.Realm> Realms
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("role_mapping")]
		public Dictionary<string, Nest.Xpack.Usage.RoleMapping> RoleMapping
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("roles")]
		public Nest.Xpack.Usage.SecurityRoles Roles
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ssl")]
		public Nest.Xpack.Usage.Ssl Ssl
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("system_key")]
		public Nest.Xpack.Usage.FeatureToggle? SystemKey
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("token_service")]
		public Nest.Xpack.Usage.FeatureToggle TokenService
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SecurityRoles
	{
		[JsonPropertyName("dls")]
		public Nest.Xpack.Usage.SecurityRolesDls Dls
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("file")]
		public Nest.Xpack.Usage.SecurityRolesFile File
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("native")]
		public Nest.Xpack.Usage.SecurityRolesNative Native
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SecurityRolesDls
	{
		[JsonPropertyName("bit_set_cache")]
		public Nest.Xpack.Usage.SecurityRolesDlsBitSetCache BitSetCache
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SecurityRolesDlsBitSetCache
	{
		[JsonPropertyName("count")]
		public int Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("memory")]
		public Nest.ByteSize? Memory
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("memory_in_bytes")]
		public ulong MemoryInBytes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SecurityRolesFile
	{
		[JsonPropertyName("dls")]
		public bool Dls
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fls")]
		public bool Fls
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("size")]
		public long Size
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SecurityRolesNative
	{
		[JsonPropertyName("dls")]
		public bool Dls
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fls")]
		public bool Fls
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("size")]
		public long Size
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
		public Nest.Slm.Statistics? PolicyStats
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
		public Dictionary<string, Nest.Xpack.Usage.Query> Queries
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Ssl
	{
		[JsonPropertyName("http")]
		public Nest.Xpack.Usage.FeatureToggle Http
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transport")]
		public Nest.Xpack.Usage.FeatureToggle Transport
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
		public Nest.Xpack.Usage.Counter Count
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("execution")]
		public Nest.Xpack.Usage.WatcherActions Execution
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("watch")]
		public Nest.Xpack.Usage.WatcherWatch Watch
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class WatcherActionTotals
	{
		[JsonPropertyName("total")]
		public long Total
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total_time_in_ms")]
		public long TotalTimeInMs
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class WatcherActions
	{
		[JsonPropertyName("actions")]
		public Dictionary<Nest.Name, Nest.Xpack.Usage.WatcherActionTotals> Actions
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class WatcherWatch
	{
		[JsonPropertyName("action")]
		public Dictionary<Nest.Name, Nest.Xpack.Usage.Counter>? Action
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("condition")]
		public Dictionary<Nest.Name, Nest.Xpack.Usage.Counter>? Condition
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("input")]
		public Dictionary<Nest.Name, Nest.Xpack.Usage.Counter> Input
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("trigger")]
		public Nest.Xpack.Usage.WatcherWatchTrigger Trigger
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class WatcherWatchTrigger
	{
		[JsonPropertyName("_all")]
		public Nest.Xpack.Usage.Counter All
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("schedule")]
		public Nest.Xpack.Usage.WatcherWatchTriggerSchedule? Schedule
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class WatcherWatchTriggerSchedule : Xpack.Usage.Counter
	{
		[JsonPropertyName("_all")]
		public Nest.Xpack.Usage.Counter All
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cron")]
		public Nest.Xpack.Usage.Counter Cron
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