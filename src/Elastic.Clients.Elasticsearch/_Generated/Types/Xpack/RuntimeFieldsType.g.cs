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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Xpack
{
	public partial class RuntimeFieldsType
	{
		[JsonInclude]
		[JsonPropertyName("chars_max")]
		public long CharsMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("chars_total")]
		public long CharsTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public long Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("doc_max")]
		public long DocMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("doc_total")]
		public long DocTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("index_count")]
		public long IndexCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("lang")]
		public IReadOnlyCollection<string> Lang { get; init; }

		[JsonInclude]
		[JsonPropertyName("lines_max")]
		public long LinesMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("lines_total")]
		public long LinesTotal { get; init; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public string Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("scriptless_count")]
		public long ScriptlessCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("shadowed_count")]
		public long ShadowedCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("source_max")]
		public long SourceMax { get; init; }

		[JsonInclude]
		[JsonPropertyName("source_total")]
		public long SourceTotal { get; init; }
	}
}