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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public class IngestSimulateRequestParameters : RequestParameters<IngestSimulateRequestParameters>
	{
		[JsonIgnore]
		public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
	}

	public partial class IngestSimulateRequest : PlainRequestBase<IngestSimulateRequestParameters>
	{
		public IngestSimulateRequest()
		{
		}

		public IngestSimulateRequest(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestSimulate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }

		[JsonInclude]
		[JsonPropertyName("docs")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.Simulate.Document>? Docs { get; set; }

		[JsonInclude]
		[JsonPropertyName("pipeline")]
		public Elastic.Clients.Elasticsearch.Ingest.Pipeline? Pipeline { get; set; }
	}

	public sealed partial class IngestSimulateRequestDescriptor : RequestDescriptorBase<IngestSimulateRequestDescriptor, IngestSimulateRequestParameters>
	{
		public IngestSimulateRequestDescriptor()
		{
		}

		public IngestSimulateRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
		{
		}

		internal IngestSimulateRequestDescriptor(Action<IngestSimulateRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestSimulate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public IngestSimulateRequestDescriptor Verbose(bool? verbose) => Qs("verbose", verbose);
		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.Simulate.Document>? DocsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Ingest.Pipeline? PipelineValue { get; private set; }

		internal PipelineDescriptor PipelineDescriptor { get; private set; }

		internal Action<PipelineDescriptor> PipelineDescriptorAction { get; private set; }

		public IngestSimulateRequestDescriptor Docs(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.Simulate.Document>? docs) => Assign(docs, (a, v) => a.DocsValue = v);
		public IngestSimulateRequestDescriptor Pipeline(Elastic.Clients.Elasticsearch.Ingest.Pipeline? pipeline)
		{
			PipelineDescriptor = null;
			PipelineDescriptorAction = null;
			return Assign(pipeline, (a, v) => a.PipelineValue = v);
		}

		public IngestSimulateRequestDescriptor Pipeline(Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor descriptor)
		{
			PipelineValue = null;
			PipelineDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.PipelineDescriptor = v);
		}

		public IngestSimulateRequestDescriptor Pipeline(Action<Elastic.Clients.Elasticsearch.Ingest.PipelineDescriptor> configure)
		{
			PipelineValue = null;
			PipelineDescriptorAction = null;
			return Assign(configure, (a, v) => a.PipelineDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DocsValue is not null)
			{
				writer.WritePropertyName("docs");
				JsonSerializer.Serialize(writer, DocsValue, options);
			}

			if (PipelineDescriptor is not null)
			{
				writer.WritePropertyName("pipeline");
				JsonSerializer.Serialize(writer, PipelineDescriptor, options);
			}
			else if (PipelineDescriptorAction is not null)
			{
				writer.WritePropertyName("pipeline");
				JsonSerializer.Serialize(writer, new PipelineDescriptor(PipelineDescriptorAction), options);
			}
			else if (PipelineValue is not null)
			{
				writer.WritePropertyName("pipeline");
				JsonSerializer.Serialize(writer, PipelineValue, options);
			}

			writer.WriteEndObject();
		}
	}
}