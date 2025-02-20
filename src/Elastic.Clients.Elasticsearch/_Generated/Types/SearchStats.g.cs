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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
public sealed partial class SearchStats
{
	[JsonInclude]
	[JsonPropertyName("fetch_current")]
	public long FetchCurrent { get; init; }

	[JsonInclude]
	[JsonPropertyName("fetch_time")]
	public Elastic.Clients.Elasticsearch.Duration? FetchTime { get; init; }

	[JsonInclude]
	[JsonPropertyName("fetch_time_in_millis")]
	public long FetchTimeInMillis { get; init; }

	[JsonInclude]
	[JsonPropertyName("fetch_total")]
	public long FetchTotal { get; init; }

	[JsonInclude]
	[JsonPropertyName("groups")]
	public IReadOnlyDictionary<string, Elastic.Clients.Elasticsearch.SearchStats>? Groups { get; init; }

	[JsonInclude]
	[JsonPropertyName("open_contexts")]
	public long? OpenContexts { get; init; }

	[JsonInclude]
	[JsonPropertyName("query_current")]
	public long QueryCurrent { get; init; }

	[JsonInclude]
	[JsonPropertyName("query_time")]
	public Elastic.Clients.Elasticsearch.Duration? QueryTime { get; init; }

	[JsonInclude]
	[JsonPropertyName("query_time_in_millis")]
	public long QueryTimeInMillis { get; init; }

	[JsonInclude]
	[JsonPropertyName("query_total")]
	public long QueryTotal { get; init; }

	[JsonInclude]
	[JsonPropertyName("scroll_current")]
	public long ScrollCurrent { get; init; }

	[JsonInclude]
	[JsonPropertyName("scroll_time")]
	public Elastic.Clients.Elasticsearch.Duration? ScrollTime { get; init; }

	[JsonInclude]
	[JsonPropertyName("scroll_time_in_millis")]
	public long ScrollTimeInMillis { get; init; }

	[JsonInclude]
	[JsonPropertyName("scroll_total")]
	public long ScrollTotal { get; init; }

	[JsonInclude]
	[JsonPropertyName("suggest_current")]
	public long SuggestCurrent { get; init; }

	[JsonInclude]
	[JsonPropertyName("suggest_time")]
	public Elastic.Clients.Elasticsearch.Duration? SuggestTime { get; init; }

	[JsonInclude]
	[JsonPropertyName("suggest_time_in_millis")]
	public long SuggestTimeInMillis { get; init; }

	[JsonInclude]
	[JsonPropertyName("suggest_total")]
	public long SuggestTotal { get; init; }
}