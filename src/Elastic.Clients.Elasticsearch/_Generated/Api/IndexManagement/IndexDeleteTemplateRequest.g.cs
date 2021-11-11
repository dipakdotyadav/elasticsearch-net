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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexDeleteTemplateRequestParameters : RequestParameters<IndexDeleteTemplateRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class IndexDeleteTemplateRequest : PlainRequestBase<IndexDeleteTemplateRequestParameters>
	{
		public IndexDeleteTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	[JsonConverter(typeof(IndexDeleteTemplateRequestDescriptorConverter))]
	public sealed partial class IndexDeleteTemplateRequestDescriptor : RequestDescriptorBase<IndexDeleteTemplateRequestDescriptor, IndexDeleteTemplateRequestParameters>
	{
		public IndexDeleteTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		public IndexDeleteTemplateRequestDescriptor()
		{
		}

		internal IndexDeleteTemplateRequestDescriptor(Action<IndexDeleteTemplateRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public IndexDeleteTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IndexDeleteTemplateRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
	}

	internal sealed class IndexDeleteTemplateRequestDescriptorConverter : JsonConverter<IndexDeleteTemplateRequestDescriptor>
	{
		public override IndexDeleteTemplateRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexDeleteTemplateRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}