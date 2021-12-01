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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexSimulateIndexTemplateRequestParameters : RequestParameters<IndexSimulateIndexTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public partial class IndexSimulateIndexTemplateRequest : PlainRequestBase<IndexSimulateIndexTemplateRequestParameters>
	{
		public IndexSimulateIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? Create { get => Q<bool?>("create"); set => Q("create", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonInclude]
		[JsonPropertyName("allow_auto_create")]
		public bool? AllowAutoCreate { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_patterns")]
		public Elastic.Clients.Elasticsearch.Indices? IndexPatterns { get; set; }

		[JsonInclude]
		[JsonPropertyName("composed_of")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Name>? ComposedOf { get; set; }

		[JsonInclude]
		[JsonPropertyName("template")]
		public Elastic.Clients.Elasticsearch.IndexManagement.PutIndexTemplate.IndexTemplateMapping? Template { get; set; }

		[JsonInclude]
		[JsonPropertyName("data_stream")]
		public Elastic.Clients.Elasticsearch.IndexManagement.DataStream? DataStream { get; set; }

		[JsonInclude]
		[JsonPropertyName("priority")]
		public int? Priority { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; set; }

		[JsonInclude]
		[JsonPropertyName("_meta")]
		public Dictionary<string, object>? Meta { get; set; }
	}

	public sealed partial class IndexSimulateIndexTemplateRequestDescriptor<T> : RequestDescriptorBase<IndexSimulateIndexTemplateRequestDescriptor<T>, IndexSimulateIndexTemplateRequestParameters>
	{
		public IndexSimulateIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		public IndexSimulateIndexTemplateRequestDescriptor()
		{
		}

		internal IndexSimulateIndexTemplateRequestDescriptor(Action<IndexSimulateIndexTemplateRequestDescriptor<T>> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public IndexSimulateIndexTemplateRequestDescriptor<T> Create(bool? create) => Qs("create", create);
		public IndexSimulateIndexTemplateRequestDescriptor<T> MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		internal bool? AllowAutoCreateValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Indices? IndexPatternsValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Name>? ComposedOfValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexManagement.PutIndexTemplate.IndexTemplateMapping? TemplateValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexManagement.DataStream? DataStreamValue { get; private set; }

		internal int? PriorityValue { get; private set; }

		internal long? VersionValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal IndexManagement.PutIndexTemplate.IndexTemplateMappingDescriptor<T> TemplateDescriptor { get; private set; }

		internal DataStreamDescriptor DataStreamDescriptor { get; private set; }

		internal Action<IndexManagement.PutIndexTemplate.IndexTemplateMappingDescriptor<T>> TemplateDescriptorAction { get; private set; }

		internal Action<DataStreamDescriptor> DataStreamDescriptorAction { get; private set; }

		public IndexSimulateIndexTemplateRequestDescriptor<T> AllowAutoCreate(bool? allowAutoCreate = true) => Assign(allowAutoCreate, (a, v) => a.AllowAutoCreateValue = v);
		public IndexSimulateIndexTemplateRequestDescriptor<T> IndexPatterns(Elastic.Clients.Elasticsearch.Indices? indexPatterns) => Assign(indexPatterns, (a, v) => a.IndexPatternsValue = v);
		public IndexSimulateIndexTemplateRequestDescriptor<T> ComposedOf(IEnumerable<Elastic.Clients.Elasticsearch.Name>? composedOf) => Assign(composedOf, (a, v) => a.ComposedOfValue = v);
		public IndexSimulateIndexTemplateRequestDescriptor<T> Template(Elastic.Clients.Elasticsearch.IndexManagement.PutIndexTemplate.IndexTemplateMapping? template)
		{
			TemplateDescriptor = null;
			TemplateDescriptorAction = null;
			return Assign(template, (a, v) => a.TemplateValue = v);
		}

		public IndexSimulateIndexTemplateRequestDescriptor<T> Template(Elastic.Clients.Elasticsearch.IndexManagement.PutIndexTemplate.IndexTemplateMappingDescriptor<T> descriptor)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.TemplateDescriptor = v);
		}

		public IndexSimulateIndexTemplateRequestDescriptor<T> Template(Action<Elastic.Clients.Elasticsearch.IndexManagement.PutIndexTemplate.IndexTemplateMappingDescriptor<T>> configure)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			return Assign(configure, (a, v) => a.TemplateDescriptorAction = v);
		}

		public IndexSimulateIndexTemplateRequestDescriptor<T> DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStream? dataStream)
		{
			DataStreamDescriptor = null;
			DataStreamDescriptorAction = null;
			return Assign(dataStream, (a, v) => a.DataStreamValue = v);
		}

		public IndexSimulateIndexTemplateRequestDescriptor<T> DataStream(Elastic.Clients.Elasticsearch.IndexManagement.DataStreamDescriptor descriptor)
		{
			DataStreamValue = null;
			DataStreamDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.DataStreamDescriptor = v);
		}

		public IndexSimulateIndexTemplateRequestDescriptor<T> DataStream(Action<Elastic.Clients.Elasticsearch.IndexManagement.DataStreamDescriptor> configure)
		{
			DataStreamValue = null;
			DataStreamDescriptorAction = null;
			return Assign(configure, (a, v) => a.DataStreamDescriptorAction = v);
		}

		public IndexSimulateIndexTemplateRequestDescriptor<T> Priority(int? priority) => Assign(priority, (a, v) => a.PriorityValue = v);
		public IndexSimulateIndexTemplateRequestDescriptor<T> Version(long? version) => Assign(version, (a, v) => a.VersionValue = v);
		public IndexSimulateIndexTemplateRequestDescriptor<T> Meta(Dictionary<string, object>? meta) => Assign(meta, (a, v) => a.MetaValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AllowAutoCreateValue.HasValue)
			{
				writer.WritePropertyName("allow_auto_create");
				writer.WriteBooleanValue(AllowAutoCreateValue.Value);
			}

			if (IndexPatternsValue is not null)
			{
				writer.WritePropertyName("index_patterns");
				JsonSerializer.Serialize(writer, IndexPatternsValue, options);
			}

			if (ComposedOfValue is not null)
			{
				writer.WritePropertyName("composed_of");
				JsonSerializer.Serialize(writer, ComposedOfValue, options);
			}

			if (TemplateDescriptor is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateDescriptor, options);
			}
			else if (TemplateDescriptorAction is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, new IndexManagement.PutIndexTemplate.IndexTemplateMappingDescriptor<T>(TemplateDescriptorAction), options);
			}
			else if (TemplateValue is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, TemplateValue, options);
			}

			if (DataStreamDescriptor is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, DataStreamDescriptor, options);
			}
			else if (DataStreamDescriptorAction is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, new DataStreamDescriptor(DataStreamDescriptorAction), options);
			}
			else if (DataStreamValue is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, DataStreamValue, options);
			}

			if (PriorityValue.HasValue)
			{
				writer.WritePropertyName("priority");
				writer.WriteNumberValue(PriorityValue.Value);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("_meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}