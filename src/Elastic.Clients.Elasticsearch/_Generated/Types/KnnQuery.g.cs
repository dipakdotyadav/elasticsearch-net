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
public sealed partial class KnnQuery
{
	[JsonInclude]
	[JsonPropertyName("boost")]
	public float? Boost { get; set; }

	[JsonInclude]
	[JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	[JsonInclude]
	[JsonPropertyName("filter")]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filter { get; set; }

	[JsonInclude]
	[JsonPropertyName("k")]
	public long k { get; set; }

	[JsonInclude]
	[JsonPropertyName("num_candidates")]
	public long NumCandidates { get; set; }

	[JsonInclude]
	[JsonPropertyName("query_vector")]
	public ICollection<double> QueryVector { get; set; }
}

public sealed partial class KnnQueryDescriptor<TDocument> : SerializableDescriptor<KnnQueryDescriptor<TDocument>>
{
	internal KnnQueryDescriptor(Action<KnnQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
	public KnnQueryDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }

	private QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }

	private Action<QueryDsl.QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }

	private float? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private long kValue { get; set; }

	private long NumCandidatesValue { get; set; }

	private ICollection<double> QueryVectorValue { get; set; }

	public KnnQueryDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Filter(QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Filter(Action<QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Filter(params Action<QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> k(long k)
	{
		kValue = k;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> NumCandidates(long numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> QueryVector(ICollection<double> queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
			writer.WriteEndArray();
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("k");
		writer.WriteNumberValue(kValue);
		writer.WritePropertyName("num_candidates");
		writer.WriteNumberValue(NumCandidatesValue);
		writer.WritePropertyName("query_vector");
		JsonSerializer.Serialize(writer, QueryVectorValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class KnnQueryDescriptor : SerializableDescriptor<KnnQueryDescriptor>
{
	internal KnnQueryDescriptor(Action<KnnQueryDescriptor> configure) => configure.Invoke(this);
	public KnnQueryDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }

	private QueryDsl.QueryDescriptor FilterDescriptor { get; set; }

	private Action<QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }

	private Action<QueryDsl.QueryDescriptor>[] FilterDescriptorActions { get; set; }

	private float? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private long kValue { get; set; }

	private long NumCandidatesValue { get; set; }

	private ICollection<double> QueryVectorValue { get; set; }

	public KnnQueryDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnQueryDescriptor Filter(QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnQueryDescriptor Filter(Action<QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnQueryDescriptor Filter(params Action<QueryDsl.QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	public KnnQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public KnnQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public KnnQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public KnnQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public KnnQueryDescriptor k(long k)
	{
		kValue = k;
		return Self;
	}

	public KnnQueryDescriptor NumCandidates(long numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	public KnnQueryDescriptor QueryVector(ICollection<double> queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
			writer.WriteEndArray();
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new QueryDsl.QueryDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		writer.WritePropertyName("k");
		writer.WriteNumberValue(kValue);
		writer.WritePropertyName("num_candidates");
		writer.WriteNumberValue(NumCandidatesValue);
		writer.WritePropertyName("query_vector");
		JsonSerializer.Serialize(writer, QueryVectorValue, options);
		writer.WriteEndObject();
	}
}