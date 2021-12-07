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
namespace Elastic.Clients.Elasticsearch
{
	public partial class InnerHits
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name? Name { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("from")]
		public int? From { get; set; }

		[JsonInclude]
		[JsonPropertyName("collapse")]
		public Elastic.Clients.Elasticsearch.FieldCollapse? Collapse { get; set; }

		[JsonInclude]
		[JsonPropertyName("docvalue_fields")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? DocvalueFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("explain")]
		public bool? Explain { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight")]
		public Elastic.Clients.Elasticsearch.Highlight? Highlight { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("script_fields")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("seq_no_primary_term")]
		public bool? SeqNoPrimaryTerm { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.SortCollection? Sort { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.SourceConfig? Source { get; set; }

		[JsonInclude]
		[JsonPropertyName("stored_field")]
		public Elastic.Clients.Elasticsearch.Fields? StoredField { get; set; }

		[JsonInclude]
		[JsonPropertyName("track_scores")]
		public bool? TrackScores { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public bool? Version { get; set; }
	}

	public sealed partial class InnerHitsDescriptor<T> : DescriptorBase<InnerHitsDescriptor<T>>
	{
		public InnerHitsDescriptor()
		{
		}

		internal InnerHitsDescriptor(Action<InnerHitsDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Name? NameValue { get; private set; }

		internal int? SizeValue { get; private set; }

		internal int? FromValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.FieldCollapse? CollapseValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? DocvalueFieldsValue { get; private set; }

		internal bool? ExplainValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Highlight? HighlightValue { get; private set; }

		internal bool? IgnoreUnmappedValue { get; private set; }

		internal Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFieldsValue { get; private set; }

		internal bool? SeqNoPrimaryTermValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SortCollection? SortValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SourceConfig? SourceValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fields? StoredFieldValue { get; private set; }

		internal bool? TrackScoresValue { get; private set; }

		internal bool? VersionValue { get; private set; }

		internal FieldCollapseDescriptor<T> CollapseDescriptor { get; private set; }

		internal HighlightDescriptor<T> HighlightDescriptor { get; private set; }

		internal Elastic.Clients.Elasticsearch.SortDescriptor<T> SortDescriptor { get; private set; }

		internal Action<FieldCollapseDescriptor<T>> CollapseDescriptorAction { get; private set; }

		internal Action<HighlightDescriptor<T>> HighlightDescriptorAction { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.SortDescriptor<T>> SortDescriptorAction { get; private set; }

		public InnerHitsDescriptor<T> Name(Elastic.Clients.Elasticsearch.Name? name) => Assign(name, (a, v) => a.NameValue = v);
		public InnerHitsDescriptor<T> Size(int? size) => Assign(size, (a, v) => a.SizeValue = v);
		public InnerHitsDescriptor<T> From(int? from) => Assign(from, (a, v) => a.FromValue = v);
		public InnerHitsDescriptor<T> Collapse(Elastic.Clients.Elasticsearch.FieldCollapse? collapse)
		{
			CollapseDescriptor = null;
			CollapseDescriptorAction = null;
			return Assign(collapse, (a, v) => a.CollapseValue = v);
		}

		public InnerHitsDescriptor<T> Collapse(FieldCollapseDescriptor<T> descriptor)
		{
			CollapseValue = null;
			CollapseDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.CollapseDescriptor = v);
		}

		public InnerHitsDescriptor<T> Collapse(Action<FieldCollapseDescriptor<T>> configure)
		{
			CollapseValue = null;
			CollapseDescriptorAction = null;
			return Assign(configure, (a, v) => a.CollapseDescriptorAction = v);
		}

		public InnerHitsDescriptor<T> DocvalueFields(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FieldAndFormat>? docvalueFields) => Assign(docvalueFields, (a, v) => a.DocvalueFieldsValue = v);
		public InnerHitsDescriptor<T> Explain(bool? explain = true) => Assign(explain, (a, v) => a.ExplainValue = v);
		public InnerHitsDescriptor<T> Highlight(Elastic.Clients.Elasticsearch.Highlight? highlight)
		{
			HighlightDescriptor = null;
			HighlightDescriptorAction = null;
			return Assign(highlight, (a, v) => a.HighlightValue = v);
		}

		public InnerHitsDescriptor<T> Highlight(HighlightDescriptor<T> descriptor)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.HighlightDescriptor = v);
		}

		public InnerHitsDescriptor<T> Highlight(Action<HighlightDescriptor<T>> configure)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			return Assign(configure, (a, v) => a.HighlightDescriptorAction = v);
		}

		public InnerHitsDescriptor<T> IgnoreUnmapped(bool? ignoreUnmapped = true) => Assign(ignoreUnmapped, (a, v) => a.IgnoreUnmappedValue = v);
		public InnerHitsDescriptor<T> ScriptFields(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptField>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptField>> selector) => Assign(selector, (a, v) => a.ScriptFieldsValue = v?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.ScriptField>()));
		public InnerHitsDescriptor<T> SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true) => Assign(seqNoPrimaryTerm, (a, v) => a.SeqNoPrimaryTermValue = v);
		public InnerHitsDescriptor<T> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Assign(fields, (a, v) => a.FieldsValue = v);
		public InnerHitsDescriptor<T> Fields<TValue>(Expression<Func<T, TValue>> fields) => Assign(fields, (a, v) => a.FieldsValue = v);
		public InnerHitsDescriptor<T> Sort(Elastic.Clients.Elasticsearch.SortCollection? sort)
		{
			SortDescriptor = null;
			SortDescriptorAction = null;
			return Assign(sort, (a, v) => a.SortValue = v);
		}

		public InnerHitsDescriptor<T> Sort(Elastic.Clients.Elasticsearch.SortDescriptor<T> descriptor)
		{
			SortValue = null;
			SortDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.SortDescriptor = v);
		}

		public InnerHitsDescriptor<T> Sort(Action<Elastic.Clients.Elasticsearch.SortDescriptor<T>> configure)
		{
			SortValue = null;
			SortDescriptorAction = null;
			return Assign(configure, (a, v) => a.SortDescriptorAction = v);
		}

		public InnerHitsDescriptor<T> Source(Elastic.Clients.Elasticsearch.SourceConfig? source) => Assign(source, (a, v) => a.SourceValue = v);
		public InnerHitsDescriptor<T> StoredField(Elastic.Clients.Elasticsearch.Fields? storedField) => Assign(storedField, (a, v) => a.StoredFieldValue = v);
		public InnerHitsDescriptor<T> StoredField<TValue>(Expression<Func<T, TValue>> storedField) => Assign(storedField, (a, v) => a.StoredFieldValue = v);
		public InnerHitsDescriptor<T> TrackScores(bool? trackScores = true) => Assign(trackScores, (a, v) => a.TrackScoresValue = v);
		public InnerHitsDescriptor<T> Version(bool? version = true) => Assign(version, (a, v) => a.VersionValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NameValue is not null)
			{
				writer.WritePropertyName("name");
				JsonSerializer.Serialize(writer, NameValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (FromValue.HasValue)
			{
				writer.WritePropertyName("from");
				writer.WriteNumberValue(FromValue.Value);
			}

			if (CollapseDescriptor is not null)
			{
				writer.WritePropertyName("collapse");
				JsonSerializer.Serialize(writer, CollapseDescriptor, options);
			}
			else if (CollapseDescriptorAction is not null)
			{
				writer.WritePropertyName("collapse");
				JsonSerializer.Serialize(writer, new FieldCollapseDescriptor<T>(CollapseDescriptorAction), options);
			}
			else if (CollapseValue is not null)
			{
				writer.WritePropertyName("collapse");
				JsonSerializer.Serialize(writer, CollapseValue, options);
			}

			if (DocvalueFieldsValue is not null)
			{
				writer.WritePropertyName("docvalue_fields");
				JsonSerializer.Serialize(writer, DocvalueFieldsValue, options);
			}

			if (ExplainValue.HasValue)
			{
				writer.WritePropertyName("explain");
				writer.WriteBooleanValue(ExplainValue.Value);
			}

			if (HighlightDescriptor is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightDescriptor, options);
			}
			else if (HighlightDescriptorAction is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, new HighlightDescriptor<T>(HighlightDescriptorAction), options);
			}
			else if (HighlightValue is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightValue, options);
			}

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			if (ScriptFieldsValue is not null)
			{
				writer.WritePropertyName("script_fields");
				JsonSerializer.Serialize(writer, ScriptFieldsValue, options);
			}

			if (SeqNoPrimaryTermValue.HasValue)
			{
				writer.WritePropertyName("seq_no_primary_term");
				writer.WriteBooleanValue(SeqNoPrimaryTermValue.Value);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (SortDescriptor is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, SortDescriptor, options);
			}
			else if (SortDescriptorAction is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortDescriptor<T>(SortDescriptorAction), options);
			}
			else if (SortValue is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, SortValue, options);
			}

			if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			if (StoredFieldValue is not null)
			{
				writer.WritePropertyName("stored_field");
				JsonSerializer.Serialize(writer, StoredFieldValue, options);
			}

			if (TrackScoresValue.HasValue)
			{
				writer.WritePropertyName("track_scores");
				writer.WriteBooleanValue(TrackScoresValue.Value);
			}

			if (VersionValue.HasValue)
			{
				writer.WritePropertyName("version");
				writer.WriteBooleanValue(VersionValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}