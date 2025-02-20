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
namespace Elastic.Clients.Elasticsearch.Core.FieldCaps;
public sealed partial class FieldCapability
{
	[JsonInclude]
	[JsonPropertyName("aggregatable")]
	public bool Aggregatable { get; init; }

	[JsonInclude]
	[JsonPropertyName("indices")]
	public Elastic.Clients.Elasticsearch.Indices? Indices { get; init; }

	[JsonInclude]
	[JsonPropertyName("meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }

	[JsonInclude]
	[JsonPropertyName("metadata_field")]
	public bool? MetadataField { get; init; }

	[JsonInclude]
	[JsonPropertyName("metric_conflicts_indices")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexName>? MetricConflictsIndices { get; init; }

	[JsonInclude]
	[JsonPropertyName("non_aggregatable_indices")]
	public Elastic.Clients.Elasticsearch.Indices? NonAggregatableIndices { get; init; }

	[JsonInclude]
	[JsonPropertyName("non_dimension_indices")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexName>? NonDimensionIndices { get; init; }

	[JsonInclude]
	[JsonPropertyName("non_searchable_indices")]
	public Elastic.Clients.Elasticsearch.Indices? NonSearchableIndices { get; init; }

	[JsonInclude]
	[JsonPropertyName("searchable")]
	public bool Searchable { get; init; }

	[JsonInclude]
	[JsonPropertyName("time_series_dimension")]
	public bool? TimeSeriesDimension { get; init; }

	[JsonInclude]
	[JsonPropertyName("time_series_metric")]
	public Elastic.Clients.Elasticsearch.Mapping.TimeSeriesMetricType? TimeSeriesMetric { get; init; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type { get; init; }
}