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
namespace Elastic.Clients.Elasticsearch.Security
{
	public class SecurityInvalidateApiKeyRequestParameters : RequestParameters<SecurityInvalidateApiKeyRequestParameters>
	{
	}

	public partial class SecurityInvalidateApiKeyRequest : PlainRequestBase<SecurityInvalidateApiKeyRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityInvalidateApiKey;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("ids")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Id>? Ids { get; set; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name? Name { get; set; }

		[JsonInclude]
		[JsonPropertyName("owner")]
		public bool? Owner { get; set; }

		[JsonInclude]
		[JsonPropertyName("realm_name")]
		public string? RealmName { get; set; }

		[JsonInclude]
		[JsonPropertyName("username")]
		public Elastic.Clients.Elasticsearch.Username? Username { get; set; }
	}

	public sealed partial class SecurityInvalidateApiKeyRequestDescriptor : RequestDescriptorBase<SecurityInvalidateApiKeyRequestDescriptor, SecurityInvalidateApiKeyRequestParameters>
	{
		internal SecurityInvalidateApiKeyRequestDescriptor(Action<SecurityInvalidateApiKeyRequestDescriptor> configure) => configure.Invoke(this);
		public SecurityInvalidateApiKeyRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityInvalidateApiKey;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => true;
		private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Id>? IdsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Name? NameValue { get; set; }

		private bool? OwnerValue { get; set; }

		private string? RealmNameValue { get; set; }

		private Elastic.Clients.Elasticsearch.Username? UsernameValue { get; set; }

		public SecurityInvalidateApiKeyRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
		{
			IdValue = id;
			return Self;
		}

		public SecurityInvalidateApiKeyRequestDescriptor Ids(IEnumerable<Elastic.Clients.Elasticsearch.Id>? ids)
		{
			IdsValue = ids;
			return Self;
		}

		public SecurityInvalidateApiKeyRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name? name)
		{
			NameValue = name;
			return Self;
		}

		public SecurityInvalidateApiKeyRequestDescriptor Owner(bool? owner = true)
		{
			OwnerValue = owner;
			return Self;
		}

		public SecurityInvalidateApiKeyRequestDescriptor RealmName(string? realmName)
		{
			RealmNameValue = realmName;
			return Self;
		}

		public SecurityInvalidateApiKeyRequestDescriptor Username(Elastic.Clients.Elasticsearch.Username? username)
		{
			UsernameValue = username;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (IdValue is not null)
			{
				writer.WritePropertyName("id");
				JsonSerializer.Serialize(writer, IdValue, options);
			}

			if (IdsValue is not null)
			{
				writer.WritePropertyName("ids");
				JsonSerializer.Serialize(writer, IdsValue, options);
			}

			if (NameValue is not null)
			{
				writer.WritePropertyName("name");
				JsonSerializer.Serialize(writer, NameValue, options);
			}

			if (OwnerValue.HasValue)
			{
				writer.WritePropertyName("owner");
				writer.WriteBooleanValue(OwnerValue.Value);
			}

			if (!string.IsNullOrEmpty(RealmNameValue))
			{
				writer.WritePropertyName("realm_name");
				writer.WriteStringValue(RealmNameValue);
			}

			if (UsernameValue is not null)
			{
				writer.WritePropertyName("username");
				JsonSerializer.Serialize(writer, UsernameValue, options);
			}

			writer.WriteEndObject();
		}
	}
}