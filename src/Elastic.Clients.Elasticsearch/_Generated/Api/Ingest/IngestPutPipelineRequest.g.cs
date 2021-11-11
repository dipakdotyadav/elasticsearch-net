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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public class IngestPutPipelineRequestParameters : RequestParameters<IngestPutPipelineRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class IngestPutPipelineRequest : PlainRequestBase<IngestPutPipelineRequestParameters>
	{
		public IngestPutPipelineRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestPutPipeline;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonInclude]
		[JsonPropertyName("_meta")]
		public Dictionary<string, object>? Meta { get; set; }

		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("on_failure")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailure { get; set; }

		[JsonInclude]
		[JsonPropertyName("processors")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? Processors { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; set; }
	}

	[JsonConverter(typeof(IngestPutPipelineRequestDescriptorConverter))]
	public sealed partial class IngestPutPipelineRequestDescriptor : RequestDescriptorBase<IngestPutPipelineRequestDescriptor, IngestPutPipelineRequestParameters>
	{
		public IngestPutPipelineRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		public IngestPutPipelineRequestDescriptor()
		{
		}

		internal IngestPutPipelineRequestDescriptor(Action<IngestPutPipelineRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestPutPipeline;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public IngestPutPipelineRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IngestPutPipelineRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal string? DescriptionValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? ProcessorsValue { get; private set; }

		internal long? VersionValue { get; private set; }

		public IngestPutPipelineRequestDescriptor Meta(Dictionary<string, object>? meta) => Assign(meta, (a, v) => a.MetaValue = v);
		public IngestPutPipelineRequestDescriptor Description(string? description) => Assign(description, (a, v) => a.DescriptionValue = v);
		public IngestPutPipelineRequestDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public IngestPutPipelineRequestDescriptor Processors(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? processors) => Assign(processors, (a, v) => a.ProcessorsValue = v);
		public IngestPutPipelineRequestDescriptor Version(long? version) => Assign(version, (a, v) => a.VersionValue = v);
	}

	internal sealed class IngestPutPipelineRequestDescriptorConverter : JsonConverter<IngestPutPipelineRequestDescriptor>
	{
		public override IngestPutPipelineRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IngestPutPipelineRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.MetaValue is not null)
			{
				writer.WritePropertyName("_meta");
				JsonSerializer.Serialize(writer, value.MetaValue, options);
			}

			if (!string.IsNullOrEmpty(value.DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(value.DescriptionValue);
			}

			if (value.OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, value.OnFailureValue, options);
			}

			if (value.ProcessorsValue is not null)
			{
				writer.WritePropertyName("processors");
				JsonSerializer.Serialize(writer, value.ProcessorsValue, options);
			}

			if (value.VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, value.VersionValue, options);
			}

			writer.WriteEndObject();
		}
	}
}