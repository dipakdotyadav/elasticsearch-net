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
namespace Elastic.Clients.Elasticsearch.Analysis;
public sealed partial class LengthTokenFilter : ITokenFilter
{
	[JsonInclude]
	[JsonPropertyName("max")]
	public int? Max { get; set; }

	[JsonInclude]
	[JsonPropertyName("min")]
	public int? Min { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "length";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class LengthTokenFilterDescriptor : SerializableDescriptor<LengthTokenFilterDescriptor>, IBuildableDescriptor<LengthTokenFilter>
{
	internal LengthTokenFilterDescriptor(Action<LengthTokenFilterDescriptor> configure) => configure.Invoke(this);
	public LengthTokenFilterDescriptor() : base()
	{
	}

	private int? MaxValue { get; set; }

	private int? MinValue { get; set; }

	private string? VersionValue { get; set; }

	public LengthTokenFilterDescriptor Max(int? max)
	{
		MaxValue = max;
		return Self;
	}

	public LengthTokenFilterDescriptor Min(int? min)
	{
		MinValue = min;
		return Self;
	}

	public LengthTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MaxValue.HasValue)
		{
			writer.WritePropertyName("max");
			writer.WriteNumberValue(MaxValue.Value);
		}

		if (MinValue.HasValue)
		{
			writer.WritePropertyName("min");
			writer.WriteNumberValue(MinValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("length");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	LengthTokenFilter IBuildableDescriptor<LengthTokenFilter>.Build() => new()
	{ Max = MaxValue, Min = MinValue, Version = VersionValue };
}