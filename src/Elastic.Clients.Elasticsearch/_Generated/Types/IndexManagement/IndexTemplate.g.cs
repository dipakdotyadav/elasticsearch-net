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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed partial class IndexTemplate
{
	[JsonInclude]
	[JsonPropertyName("_meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }

	[JsonInclude]
	[JsonPropertyName("allow_auto_create")]
	public bool? AllowAutoCreate { get; init; }

	[JsonInclude]
	[JsonPropertyName("composed_of")]
	public IReadOnlyCollection<string> ComposedOf { get; init; }

	[JsonInclude]
	[JsonPropertyName("data_stream")]
	public Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateDataStreamConfiguration? DataStream { get; init; }

	[JsonInclude]
	[JsonPropertyName("index_patterns")]
	public IReadOnlyCollection<string> IndexPatterns { get; init; }

	[JsonInclude]
	[JsonPropertyName("priority")]
	public long? Priority { get; init; }

	[JsonInclude]
	[JsonPropertyName("template")]
	public Elastic.Clients.Elasticsearch.IndexManagement.IndexTemplateSummary? Template { get; init; }

	[JsonInclude]
	[JsonPropertyName("version")]
	public long? Version { get; init; }
}