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
	public class IndexDeleteIndexTemplateRequestParameters : RequestParameters<IndexDeleteIndexTemplateRequestParameters>
	{
	}

	public partial class IndexDeleteIndexTemplateRequest : PlainRequestBase<IndexDeleteIndexTemplateRequestParameters>
	{
		public IndexDeleteIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	[JsonConverter(typeof(IndexDeleteIndexTemplateRequestDescriptorConverter))]
	public sealed partial class IndexDeleteIndexTemplateRequestDescriptor : RequestDescriptorBase<IndexDeleteIndexTemplateRequestDescriptor, IndexDeleteIndexTemplateRequestParameters>
	{
		public IndexDeleteIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		public IndexDeleteIndexTemplateRequestDescriptor()
		{
		}

		internal IndexDeleteIndexTemplateRequestDescriptor(Action<IndexDeleteIndexTemplateRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	internal sealed class IndexDeleteIndexTemplateRequestDescriptorConverter : JsonConverter<IndexDeleteIndexTemplateRequestDescriptor>
	{
		public override IndexDeleteIndexTemplateRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexDeleteIndexTemplateRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}