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
namespace Elastic.Clients.Elasticsearch.QueryDsl;
public sealed partial class ScriptScoreQuery : SearchQuery
{
	[JsonInclude]
	[JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	[JsonInclude]
	[JsonPropertyName("boost")]
	public float? Boost { get; set; }

	[JsonInclude]
	[JsonPropertyName("min_score")]
	public float? MinScore { get; set; }

	[JsonInclude]
	[JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query Query { get; set; }

	[JsonInclude]
	[JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script Script { get; set; }

	public static implicit operator Query(ScriptScoreQuery scriptScoreQuery) => QueryDsl.Query.ScriptScore(scriptScoreQuery);
}

public sealed partial class ScriptScoreQueryDescriptor<TDocument> : SerializableDescriptor<ScriptScoreQueryDescriptor<TDocument>>
{
	internal ScriptScoreQueryDescriptor(Action<ScriptScoreQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
	public ScriptScoreQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query QueryValue { get; set; }

	private QueryDescriptor<TDocument> QueryDescriptor { get; set; }

	private Action<QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private float? MinScoreValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script ScriptValue { get; set; }

	public ScriptScoreQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public ScriptScoreQueryDescriptor<TDocument> Query(QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public ScriptScoreQueryDescriptor<TDocument> Query(Action<QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public ScriptScoreQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public ScriptScoreQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public ScriptScoreQueryDescriptor<TDocument> MinScore(float? minScore)
	{
		MinScoreValue = minScore;
		return Self;
	}

	public ScriptScoreQueryDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (MinScoreValue.HasValue)
		{
			writer.WritePropertyName("min_score");
			writer.WriteNumberValue(MinScoreValue.Value);
		}

		writer.WritePropertyName("script");
		JsonSerializer.Serialize(writer, ScriptValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class ScriptScoreQueryDescriptor : SerializableDescriptor<ScriptScoreQueryDescriptor>
{
	internal ScriptScoreQueryDescriptor(Action<ScriptScoreQueryDescriptor> configure) => configure.Invoke(this);
	public ScriptScoreQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.Query QueryValue { get; set; }

	private QueryDescriptor QueryDescriptor { get; set; }

	private Action<QueryDescriptor> QueryDescriptorAction { get; set; }

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private float? MinScoreValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script ScriptValue { get; set; }

	public ScriptScoreQueryDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public ScriptScoreQueryDescriptor Query(QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public ScriptScoreQueryDescriptor Query(Action<QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public ScriptScoreQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public ScriptScoreQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public ScriptScoreQueryDescriptor MinScore(float? minScore)
	{
		MinScoreValue = minScore;
		return Self;
	}

	public ScriptScoreQueryDescriptor Script(Elastic.Clients.Elasticsearch.Script script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryDescriptor(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (MinScoreValue.HasValue)
		{
			writer.WritePropertyName("min_score");
			writer.WriteNumberValue(MinScoreValue.Value);
		}

		writer.WritePropertyName("script");
		JsonSerializer.Serialize(writer, ScriptValue, options);
		writer.WriteEndObject();
	}
}