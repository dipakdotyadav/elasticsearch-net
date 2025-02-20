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
namespace Elastic.Clients.Elasticsearch.Ml;
public sealed partial class PassThroughInferenceOptions
{
	[JsonInclude]
	[JsonPropertyName("results_field")]
	public string? ResultsField { get; set; }

	[JsonInclude]
	[JsonPropertyName("tokenization")]
	public Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? Tokenization { get; set; }

	public static implicit operator InferenceConfigCreate(PassThroughInferenceOptions passThroughInferenceOptions) => Ml.InferenceConfigCreate.PassThrough(passThroughInferenceOptions);
}

public sealed partial class PassThroughInferenceOptionsDescriptor : SerializableDescriptor<PassThroughInferenceOptionsDescriptor>
{
	internal PassThroughInferenceOptionsDescriptor(Action<PassThroughInferenceOptionsDescriptor> configure) => configure.Invoke(this);
	public PassThroughInferenceOptionsDescriptor() : base()
	{
	}

	private string? ResultsFieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? TokenizationValue { get; set; }

	private TokenizationConfigDescriptor TokenizationDescriptor { get; set; }

	private Action<TokenizationConfigDescriptor> TokenizationDescriptorAction { get; set; }

	public PassThroughInferenceOptionsDescriptor ResultsField(string? resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	public PassThroughInferenceOptionsDescriptor Tokenization(Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? tokenization)
	{
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = null;
		TokenizationValue = tokenization;
		return Self;
	}

	public PassThroughInferenceOptionsDescriptor Tokenization(TokenizationConfigDescriptor descriptor)
	{
		TokenizationValue = null;
		TokenizationDescriptorAction = null;
		TokenizationDescriptor = descriptor;
		return Self;
	}

	public PassThroughInferenceOptionsDescriptor Tokenization(Action<TokenizationConfigDescriptor> configure)
	{
		TokenizationValue = null;
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ResultsFieldValue))
		{
			writer.WritePropertyName("results_field");
			writer.WriteStringValue(ResultsFieldValue);
		}

		if (TokenizationDescriptor is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationDescriptor, options);
		}
		else if (TokenizationDescriptorAction is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, new TokenizationConfigDescriptor(TokenizationDescriptorAction), options);
		}
		else if (TokenizationValue is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationValue, options);
		}

		writer.WriteEndObject();
	}
}