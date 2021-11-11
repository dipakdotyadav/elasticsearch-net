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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public class SearchRequestParameters : RequestParameters<SearchRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllowPartialSearchResults { get => Q<bool?>("allow_partial_search_results"); set => Q("allow_partial_search_results", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public long? BatchedReduceSize { get => Q<long?>("batched_reduce_size"); set => Q("batched_reduce_size", value); }

		[JsonIgnore]
		public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.DefaultOperator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? DocvalueFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("docvalue_fields"); set => Q("docvalue_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public long? MaxConcurrentShardRequests { get => Q<long?>("max_concurrent_shard_requests"); set => Q("max_concurrent_shard_requests", value); }

		[JsonIgnore]
		public string? MinCompatibleShardNode { get => Q<string?>("min_compatible_shard_node"); set => Q("min_compatible_shard_node", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public long? PreFilterShardSize { get => Q<long?>("pre_filter_shard_size"); set => Q("pre_filter_shard_size", value); }

		[JsonIgnore]
		public bool? RequestCache { get => Q<bool?>("request_cache"); set => Q("request_cache", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Scroll { get => Q<Elastic.Clients.Elasticsearch.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public IEnumerable<string>? Stats { get => Q<IEnumerable<string>?>("stats"); set => Q("stats", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public string? SuggestField { get => Q<string?>("suggest_field"); set => Q("suggest_field", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SuggestMode? SuggestMode { get => Q<Elastic.Clients.Elasticsearch.SuggestMode?>("suggest_mode"); set => Q("suggest_mode", value); }

		[JsonIgnore]
		public long? SuggestSize { get => Q<long?>("suggest_size"); set => Q("suggest_size", value); }

		[JsonIgnore]
		public string? SuggestText { get => Q<string?>("suggest_text"); set => Q("suggest_text", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Union<bool?, int?>? TrackTotalHits { get => Q<Union<bool?, int?>?>("track_total_hits"); set => Q("track_total_hits", value); }

		[JsonIgnore]
		public bool? TrackScores { get => Q<bool?>("track_scores"); set => Q("track_scores", value); }

		[JsonIgnore]
		public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

		[JsonIgnore]
		public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

		[JsonIgnore]
		public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Union<bool?, Elastic.Clients.Elasticsearch.Fields?>? Source { get => Q<Union<bool?, Elastic.Clients.Elasticsearch.Fields?>?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public bool? SeqNoPrimaryTerm { get => Q<bool?>("seq_no_primary_term"); set => Q("seq_no_primary_term", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public string? Sort { get => Q<string?>("sort"); set => Q("sort", value); }
	}

	public partial class SearchRequest : PlainRequestBase<SearchRequestParameters>
	{
		public SearchRequest()
		{
		}

		public SearchRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public bool? AllowPartialSearchResults { get => Q<bool?>("allow_partial_search_results"); set => Q("allow_partial_search_results", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public long? BatchedReduceSize { get => Q<long?>("batched_reduce_size"); set => Q("batched_reduce_size", value); }

		[JsonIgnore]
		public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.DefaultOperator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.DefaultOperator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? DocvalueFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("docvalue_fields"); set => Q("docvalue_fields", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Explain { get => Q<bool?>("explain"); set => Q("explain", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public long? MaxConcurrentShardRequests { get => Q<long?>("max_concurrent_shard_requests"); set => Q("max_concurrent_shard_requests", value); }

		[JsonIgnore]
		public string? MinCompatibleShardNode { get => Q<string?>("min_compatible_shard_node"); set => Q("min_compatible_shard_node", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public long? PreFilterShardSize { get => Q<long?>("pre_filter_shard_size"); set => Q("pre_filter_shard_size", value); }

		[JsonIgnore]
		public bool? RequestCache { get => Q<bool?>("request_cache"); set => Q("request_cache", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Scroll { get => Q<Elastic.Clients.Elasticsearch.Time?>("scroll"); set => Q("scroll", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.SearchType?>("search_type"); set => Q("search_type", value); }

		[JsonIgnore]
		public IEnumerable<string>? Stats { get => Q<IEnumerable<string>?>("stats"); set => Q("stats", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public string? SuggestField { get => Q<string?>("suggest_field"); set => Q("suggest_field", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SuggestMode? SuggestMode { get => Q<Elastic.Clients.Elasticsearch.SuggestMode?>("suggest_mode"); set => Q("suggest_mode", value); }

		[JsonIgnore]
		public long? SuggestSize { get => Q<long?>("suggest_size"); set => Q("suggest_size", value); }

		[JsonIgnore]
		public string? SuggestText { get => Q<string?>("suggest_text"); set => Q("suggest_text", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Union<bool?, int?>? TrackTotalHits { get => Q<Union<bool?, int?>?>("track_total_hits"); set => Q("track_total_hits", value); }

		[JsonIgnore]
		public bool? TrackScores { get => Q<bool?>("track_scores"); set => Q("track_scores", value); }

		[JsonIgnore]
		public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }

		[JsonIgnore]
		public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

		[JsonIgnore]
		public bool? Version { get => Q<bool?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Union<bool?, Elastic.Clients.Elasticsearch.Fields?>? Source { get => Q<Union<bool?, Elastic.Clients.Elasticsearch.Fields?>?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public bool? SeqNoPrimaryTerm { get => Q<bool?>("seq_no_primary_term"); set => Q("seq_no_primary_term", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public string? Sort { get => Q<string?>("sort"); set => Q("sort", value); }

		[JsonInclude]
		[JsonPropertyName("aggregations")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationContainer>? Aggregations { get; set; }

		[JsonInclude]
		[JsonPropertyName("collapse")]
		public Elastic.Clients.Elasticsearch.FieldCollapse? Collapse { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight")]
		public Elastic.Clients.Elasticsearch.Highlight? Highlight { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices_boost")]
		public IEnumerable<Dictionary<Elastic.Clients.Elasticsearch.IndexName, double>>? IndicesBoost { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_score")]
		public double? MinScore { get; set; }

		[JsonInclude]
		[JsonPropertyName("post_filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? PostFilter { get; set; }

		[JsonInclude]
		[JsonPropertyName("profile")]
		public bool? Profile { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("rescore")]
		public Elastic.Clients.Elasticsearch.Rescore? Rescore { get; set; }

		[JsonInclude]
		[JsonPropertyName("script_fields")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("search_after")]
		public IEnumerable<object>? SearchAfter { get; set; }

		[JsonInclude]
		[JsonPropertyName("slice")]
		public Elastic.Clients.Elasticsearch.SlicedScroll? Slice { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public IEnumerable<Union<string?, Elastic.Clients.Elasticsearch.DateField?>>? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("suggest")]
		public Union<Elastic.Clients.Elasticsearch.SuggestContainer?, Dictionary<string, Elastic.Clients.Elasticsearch.SuggestContainer>?>? Suggest { get; set; }

		[JsonInclude]
		[JsonPropertyName("pit")]
		public Elastic.Clients.Elasticsearch.PointInTimeReference? Pit { get; set; }

		[JsonInclude]
		[JsonPropertyName("runtime_mappings")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappings { get; set; }
	}

	[JsonConverter(typeof(SearchRequestDescriptorConverter))]
	public sealed partial class SearchRequestDescriptor : RequestDescriptorBase<SearchRequestDescriptor, SearchRequestParameters>
	{
		public SearchRequestDescriptor()
		{
		}

		public SearchRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal SearchRequestDescriptor(Action<SearchRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public SearchRequestDescriptor AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public SearchRequestDescriptor AllowPartialSearchResults(bool? allowPartialSearchResults) => Qs("allow_partial_search_results", allowPartialSearchResults);
		public SearchRequestDescriptor Analyzer(string? analyzer) => Qs("analyzer", analyzer);
		public SearchRequestDescriptor AnalyzeWildcard(bool? analyzeWildcard) => Qs("analyze_wildcard", analyzeWildcard);
		public SearchRequestDescriptor BatchedReduceSize(long? batchedReduceSize) => Qs("batched_reduce_size", batchedReduceSize);
		public SearchRequestDescriptor CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
		public SearchRequestDescriptor DefaultOperator(Elastic.Clients.Elasticsearch.DefaultOperator? defaultOperator) => Qs("default_operator", defaultOperator);
		public SearchRequestDescriptor Df(string? df) => Qs("df", df);
		public SearchRequestDescriptor DocvalueFields(Elastic.Clients.Elasticsearch.Fields? docvalueFields) => Qs("docvalue_fields", docvalueFields);
		public SearchRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public SearchRequestDescriptor Explain(bool? explain) => Qs("explain", explain);
		public SearchRequestDescriptor IgnoreThrottled(bool? ignoreThrottled) => Qs("ignore_throttled", ignoreThrottled);
		public SearchRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public SearchRequestDescriptor Lenient(bool? lenient) => Qs("lenient", lenient);
		public SearchRequestDescriptor MaxConcurrentShardRequests(long? maxConcurrentShardRequests) => Qs("max_concurrent_shard_requests", maxConcurrentShardRequests);
		public SearchRequestDescriptor MinCompatibleShardNode(string? minCompatibleShardNode) => Qs("min_compatible_shard_node", minCompatibleShardNode);
		public SearchRequestDescriptor Preference(string? preference) => Qs("preference", preference);
		public SearchRequestDescriptor PreFilterShardSize(long? preFilterShardSize) => Qs("pre_filter_shard_size", preFilterShardSize);
		public SearchRequestDescriptor RequestCache(bool? requestCache) => Qs("request_cache", requestCache);
		public SearchRequestDescriptor Routing(string? routing) => Qs("routing", routing);
		public SearchRequestDescriptor Scroll(Elastic.Clients.Elasticsearch.Time? scroll) => Qs("scroll", scroll);
		public SearchRequestDescriptor SearchType(Elastic.Clients.Elasticsearch.SearchType? searchType) => Qs("search_type", searchType);
		public SearchRequestDescriptor Stats(IEnumerable<string>? stats) => Qs("stats", stats);
		public SearchRequestDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Qs("stored_fields", storedFields);
		public SearchRequestDescriptor SuggestField(string? suggestField) => Qs("suggest_field", suggestField);
		public SearchRequestDescriptor SuggestMode(Elastic.Clients.Elasticsearch.SuggestMode? suggestMode) => Qs("suggest_mode", suggestMode);
		public SearchRequestDescriptor SuggestSize(long? suggestSize) => Qs("suggest_size", suggestSize);
		public SearchRequestDescriptor SuggestText(string? suggestText) => Qs("suggest_text", suggestText);
		public SearchRequestDescriptor TerminateAfter(long? terminateAfter) => Qs("terminate_after", terminateAfter);
		public SearchRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public SearchRequestDescriptor TrackTotalHits(Union<bool?, int?>? trackTotalHits) => Qs("track_total_hits", trackTotalHits);
		public SearchRequestDescriptor TrackScores(bool? trackScores) => Qs("track_scores", trackScores);
		public SearchRequestDescriptor TypedKeys(bool? typedKeys) => Qs("typed_keys", typedKeys);
		public SearchRequestDescriptor RestTotalHitsAsInt(bool? restTotalHitsAsInt) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
		public SearchRequestDescriptor Version(bool? version) => Qs("version", version);
		public SearchRequestDescriptor Source(Union<bool?, Elastic.Clients.Elasticsearch.Fields?>? source) => Qs("_source", source);
		public SearchRequestDescriptor SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
		public SearchRequestDescriptor SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
		public SearchRequestDescriptor SeqNoPrimaryTerm(bool? seqNoPrimaryTerm) => Qs("seq_no_primary_term", seqNoPrimaryTerm);
		public SearchRequestDescriptor QueryLuceneSyntax(string? q) => Qs("q", q);
		public SearchRequestDescriptor Size(int? size) => Qs("size", size);
		public SearchRequestDescriptor From(int? from) => Qs("from", from);
		public SearchRequestDescriptor Sort(string? sort) => Qs("sort", sort);
		internal Dictionary<string, Elastic.Clients.Elasticsearch.Aggregations.AggregationContainer>? AggregationsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.FieldCollapse? CollapseValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Highlight? HighlightValue { get; private set; }

		internal IEnumerable<Dictionary<Elastic.Clients.Elasticsearch.IndexName, double>>? IndicesBoostValue { get; private set; }

		internal double? MinScoreValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? PostFilterValue { get; private set; }

		internal bool? ProfileValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Rescore? RescoreValue { get; private set; }

		internal Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFieldsValue { get; private set; }

		internal IEnumerable<object>? SearchAfterValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SlicedScroll? SliceValue { get; private set; }

		internal IEnumerable<Union<string?, Elastic.Clients.Elasticsearch.DateField?>>? FieldsValue { get; private set; }

		internal Union<Elastic.Clients.Elasticsearch.SuggestContainer?, Dictionary<string, Elastic.Clients.Elasticsearch.SuggestContainer>?>? SuggestValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.PointInTimeReference? PitValue { get; private set; }

		internal Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeMappingsValue { get; private set; }

		internal FieldCollapseDescriptor CollapseDescriptor { get; private set; }

		internal HighlightDescriptor HighlightDescriptor { get; private set; }

		internal QueryDsl.QueryContainerDescriptor PostFilterDescriptor { get; private set; }

		internal QueryDsl.QueryContainerDescriptor QueryDescriptor { get; private set; }

		internal RescoreDescriptor RescoreDescriptor { get; private set; }

		internal SlicedScrollDescriptor SliceDescriptor { get; private set; }

		internal PointInTimeReferenceDescriptor PitDescriptor { get; private set; }

		internal Action<FieldCollapseDescriptor> CollapseDescriptorAction { get; private set; }

		internal Action<HighlightDescriptor> HighlightDescriptorAction { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor> PostFilterDescriptorAction { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor> QueryDescriptorAction { get; private set; }

		internal Action<RescoreDescriptor> RescoreDescriptorAction { get; private set; }

		internal Action<SlicedScrollDescriptor> SliceDescriptorAction { get; private set; }

		internal Action<PointInTimeReferenceDescriptor> PitDescriptorAction { get; private set; }

		public SearchRequestDescriptor Aggregations(Func<FluentDictionary<string?, Elastic.Clients.Elasticsearch.Aggregations.AggregationContainer?>, FluentDictionary<string?, Elastic.Clients.Elasticsearch.Aggregations.AggregationContainer?>> selector) => Assign(selector, (a, v) => a.AggregationsValue = v?.Invoke(new FluentDictionary<string?, Elastic.Clients.Elasticsearch.Aggregations.AggregationContainer?>()));
		public SearchRequestDescriptor Collapse(Elastic.Clients.Elasticsearch.FieldCollapse? collapse)
		{
			CollapseDescriptor = null;
			CollapseDescriptorAction = null;
			return Assign(collapse, (a, v) => a.CollapseValue = v);
		}

		public SearchRequestDescriptor Collapse(Elastic.Clients.Elasticsearch.FieldCollapseDescriptor descriptor)
		{
			CollapseValue = null;
			CollapseDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.CollapseDescriptor = v);
		}

		public SearchRequestDescriptor Collapse(Action<Elastic.Clients.Elasticsearch.FieldCollapseDescriptor> configure)
		{
			CollapseValue = null;
			CollapseDescriptorAction = null;
			return Assign(configure, (a, v) => a.CollapseDescriptorAction = v);
		}

		public SearchRequestDescriptor Highlight(Elastic.Clients.Elasticsearch.Highlight? highlight)
		{
			HighlightDescriptor = null;
			HighlightDescriptorAction = null;
			return Assign(highlight, (a, v) => a.HighlightValue = v);
		}

		public SearchRequestDescriptor Highlight(Elastic.Clients.Elasticsearch.HighlightDescriptor descriptor)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.HighlightDescriptor = v);
		}

		public SearchRequestDescriptor Highlight(Action<Elastic.Clients.Elasticsearch.HighlightDescriptor> configure)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			return Assign(configure, (a, v) => a.HighlightDescriptorAction = v);
		}

		public SearchRequestDescriptor IndicesBoost(IEnumerable<Dictionary<Elastic.Clients.Elasticsearch.IndexName, double>>? indicesBoost) => Assign(indicesBoost, (a, v) => a.IndicesBoostValue = v);
		public SearchRequestDescriptor MinScore(double? minScore) => Assign(minScore, (a, v) => a.MinScoreValue = v);
		public SearchRequestDescriptor PostFilter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? postFilter)
		{
			PostFilterDescriptor = null;
			PostFilterDescriptorAction = null;
			return Assign(postFilter, (a, v) => a.PostFilterValue = v);
		}

		public SearchRequestDescriptor PostFilter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainerDescriptor descriptor)
		{
			PostFilterValue = null;
			PostFilterDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.PostFilterDescriptor = v);
		}

		public SearchRequestDescriptor PostFilter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainerDescriptor> configure)
		{
			PostFilterValue = null;
			PostFilterDescriptorAction = null;
			return Assign(configure, (a, v) => a.PostFilterDescriptorAction = v);
		}

		public SearchRequestDescriptor Profile(bool? profile = true) => Assign(profile, (a, v) => a.ProfileValue = v);
		public SearchRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			return Assign(query, (a, v) => a.QueryValue = v);
		}

		public SearchRequestDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainerDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.QueryDescriptor = v);
		}

		public SearchRequestDescriptor Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainerDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(configure, (a, v) => a.QueryDescriptorAction = v);
		}

		public SearchRequestDescriptor Rescore(Elastic.Clients.Elasticsearch.Rescore? rescore)
		{
			RescoreDescriptor = null;
			RescoreDescriptorAction = null;
			return Assign(rescore, (a, v) => a.RescoreValue = v);
		}

		public SearchRequestDescriptor Rescore(Elastic.Clients.Elasticsearch.RescoreDescriptor descriptor)
		{
			RescoreValue = null;
			RescoreDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.RescoreDescriptor = v);
		}

		public SearchRequestDescriptor Rescore(Action<Elastic.Clients.Elasticsearch.RescoreDescriptor> configure)
		{
			RescoreValue = null;
			RescoreDescriptorAction = null;
			return Assign(configure, (a, v) => a.RescoreDescriptorAction = v);
		}

		public SearchRequestDescriptor ScriptFields(Func<FluentDictionary<string?, Elastic.Clients.Elasticsearch.ScriptField?>, FluentDictionary<string?, Elastic.Clients.Elasticsearch.ScriptField?>> selector) => Assign(selector, (a, v) => a.ScriptFieldsValue = v?.Invoke(new FluentDictionary<string?, Elastic.Clients.Elasticsearch.ScriptField?>()));
		public SearchRequestDescriptor SearchAfter(IEnumerable<object>? searchAfter) => Assign(searchAfter, (a, v) => a.SearchAfterValue = v);
		public SearchRequestDescriptor Slice(Elastic.Clients.Elasticsearch.SlicedScroll? slice)
		{
			SliceDescriptor = null;
			SliceDescriptorAction = null;
			return Assign(slice, (a, v) => a.SliceValue = v);
		}

		public SearchRequestDescriptor Slice(Elastic.Clients.Elasticsearch.SlicedScrollDescriptor descriptor)
		{
			SliceValue = null;
			SliceDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.SliceDescriptor = v);
		}

		public SearchRequestDescriptor Slice(Action<Elastic.Clients.Elasticsearch.SlicedScrollDescriptor> configure)
		{
			SliceValue = null;
			SliceDescriptorAction = null;
			return Assign(configure, (a, v) => a.SliceDescriptorAction = v);
		}

		public SearchRequestDescriptor Fields(IEnumerable<Union<string?, Elastic.Clients.Elasticsearch.DateField?>>? fields) => Assign(fields, (a, v) => a.FieldsValue = v);
		public SearchRequestDescriptor Suggest(Union<Elastic.Clients.Elasticsearch.SuggestContainer?, Dictionary<string, Elastic.Clients.Elasticsearch.SuggestContainer>?>? suggest) => Assign(suggest, (a, v) => a.SuggestValue = v);
		public SearchRequestDescriptor Pit(Elastic.Clients.Elasticsearch.PointInTimeReference? pit)
		{
			PitDescriptor = null;
			PitDescriptorAction = null;
			return Assign(pit, (a, v) => a.PitValue = v);
		}

		public SearchRequestDescriptor Pit(Elastic.Clients.Elasticsearch.PointInTimeReferenceDescriptor descriptor)
		{
			PitValue = null;
			PitDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.PitDescriptor = v);
		}

		public SearchRequestDescriptor Pit(Action<Elastic.Clients.Elasticsearch.PointInTimeReferenceDescriptor> configure)
		{
			PitValue = null;
			PitDescriptorAction = null;
			return Assign(configure, (a, v) => a.PitDescriptorAction = v);
		}

		public SearchRequestDescriptor RuntimeMappings(Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? runtimeMappings) => Assign(runtimeMappings, (a, v) => a.RuntimeMappingsValue = v);
	}

	internal sealed class SearchRequestDescriptorConverter : JsonConverter<SearchRequestDescriptor>
	{
		public override SearchRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, SearchRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, value.AggregationsValue, options);
			}

			if (value.CollapseDescriptor is not null)
			{
				writer.WritePropertyName("collapse");
				JsonSerializer.Serialize(writer, value.CollapseDescriptor, options);
			}
			else if (value.CollapseDescriptorAction is not null)
			{
				writer.WritePropertyName("collapse");
				JsonSerializer.Serialize(writer, new FieldCollapseDescriptor(value.CollapseDescriptorAction), options);
			}
			else if (value.CollapseValue is not null)
			{
				writer.WritePropertyName("collapse");
				JsonSerializer.Serialize(writer, value.CollapseValue, options);
			}

			if (value.HighlightDescriptor is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, value.HighlightDescriptor, options);
			}
			else if (value.HighlightDescriptorAction is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, new HighlightDescriptor(value.HighlightDescriptorAction), options);
			}
			else if (value.HighlightValue is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, value.HighlightValue, options);
			}

			if (value.IndicesBoostValue is not null)
			{
				writer.WritePropertyName("indices_boost");
				JsonSerializer.Serialize(writer, value.IndicesBoostValue, options);
			}

			if (value.MinScoreValue.HasValue)
			{
				writer.WritePropertyName("min_score");
				writer.WriteNumberValue(value.MinScoreValue.Value);
			}

			if (value.PostFilterDescriptor is not null)
			{
				writer.WritePropertyName("post_filter");
				JsonSerializer.Serialize(writer, value.PostFilterDescriptor, options);
			}
			else if (value.PostFilterDescriptorAction is not null)
			{
				writer.WritePropertyName("post_filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(value.PostFilterDescriptorAction), options);
			}
			else if (value.PostFilterValue is not null)
			{
				writer.WritePropertyName("post_filter");
				JsonSerializer.Serialize(writer, value.PostFilterValue, options);
			}

			if (value.ProfileValue.HasValue)
			{
				writer.WritePropertyName("profile");
				writer.WriteBooleanValue(value.ProfileValue.Value);
			}

			if (value.QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, value.QueryDescriptor, options);
			}
			else if (value.QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(value.QueryDescriptorAction), options);
			}
			else if (value.QueryValue is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, value.QueryValue, options);
			}

			if (value.RescoreDescriptor is not null)
			{
				writer.WritePropertyName("rescore");
				JsonSerializer.Serialize(writer, value.RescoreDescriptor, options);
			}
			else if (value.RescoreDescriptorAction is not null)
			{
				writer.WritePropertyName("rescore");
				JsonSerializer.Serialize(writer, new RescoreDescriptor(value.RescoreDescriptorAction), options);
			}
			else if (value.RescoreValue is not null)
			{
				writer.WritePropertyName("rescore");
				JsonSerializer.Serialize(writer, value.RescoreValue, options);
			}

			if (value.ScriptFieldsValue is not null)
			{
				writer.WritePropertyName("script_fields");
				JsonSerializer.Serialize(writer, value.ScriptFieldsValue, options);
			}

			if (value.SearchAfterValue is not null)
			{
				writer.WritePropertyName("search_after");
				JsonSerializer.Serialize(writer, value.SearchAfterValue, options);
			}

			if (value.SliceDescriptor is not null)
			{
				writer.WritePropertyName("slice");
				JsonSerializer.Serialize(writer, value.SliceDescriptor, options);
			}
			else if (value.SliceDescriptorAction is not null)
			{
				writer.WritePropertyName("slice");
				JsonSerializer.Serialize(writer, new SlicedScrollDescriptor(value.SliceDescriptorAction), options);
			}
			else if (value.SliceValue is not null)
			{
				writer.WritePropertyName("slice");
				JsonSerializer.Serialize(writer, value.SliceValue, options);
			}

			if (value.FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, value.FieldsValue, options);
			}

			if (value.SuggestValue is not null)
			{
				writer.WritePropertyName("suggest");
				JsonSerializer.Serialize(writer, value.SuggestValue, options);
			}

			if (value.PitDescriptor is not null)
			{
				writer.WritePropertyName("pit");
				JsonSerializer.Serialize(writer, value.PitDescriptor, options);
			}
			else if (value.PitDescriptorAction is not null)
			{
				writer.WritePropertyName("pit");
				JsonSerializer.Serialize(writer, new PointInTimeReferenceDescriptor(value.PitDescriptorAction), options);
			}
			else if (value.PitValue is not null)
			{
				writer.WritePropertyName("pit");
				JsonSerializer.Serialize(writer, value.PitValue, options);
			}

			if (value.RuntimeMappingsValue is not null)
			{
				writer.WritePropertyName("runtime_mappings");
				JsonSerializer.Serialize(writer, value.RuntimeMappingsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}