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
public sealed partial class ZeroShotClassificationInferenceOptions
{
	[JsonInclude]
	[JsonPropertyName("classification_labels")]
	public ICollection<string> ClassificationLabels { get; set; }

	[JsonInclude]
	[JsonPropertyName("hypothesis_template")]
	public string? HypothesisTemplate { get; set; }

	[JsonInclude]
	[JsonPropertyName("labels")]
	public ICollection<string>? Labels { get; set; }

	[JsonInclude]
	[JsonPropertyName("multi_label")]
	public bool? MultiLabel { get; set; }

	[JsonInclude]
	[JsonPropertyName("results_field")]
	public string? ResultsField { get; set; }

	[JsonInclude]
	[JsonPropertyName("tokenization")]
	public Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? Tokenization { get; set; }

	public static implicit operator InferenceConfigCreate(ZeroShotClassificationInferenceOptions zeroShotClassificationInferenceOptions) => Ml.InferenceConfigCreate.ZeroShotClassification(zeroShotClassificationInferenceOptions);
}

public sealed partial class ZeroShotClassificationInferenceOptionsDescriptor : SerializableDescriptor<ZeroShotClassificationInferenceOptionsDescriptor>
{
	internal ZeroShotClassificationInferenceOptionsDescriptor(Action<ZeroShotClassificationInferenceOptionsDescriptor> configure) => configure.Invoke(this);
	public ZeroShotClassificationInferenceOptionsDescriptor() : base()
	{
	}

	private ICollection<string> ClassificationLabelsValue { get; set; }

	private string? HypothesisTemplateValue { get; set; }

	private ICollection<string>? LabelsValue { get; set; }

	private bool? MultiLabelValue { get; set; }

	private string? ResultsFieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? TokenizationValue { get; set; }

	private TokenizationConfigDescriptor TokenizationDescriptor { get; set; }

	private Action<TokenizationConfigDescriptor> TokenizationDescriptorAction { get; set; }

	public ZeroShotClassificationInferenceOptionsDescriptor ClassificationLabels(ICollection<string> classificationLabels)
	{
		ClassificationLabelsValue = classificationLabels;
		return Self;
	}

	public ZeroShotClassificationInferenceOptionsDescriptor HypothesisTemplate(string? hypothesisTemplate)
	{
		HypothesisTemplateValue = hypothesisTemplate;
		return Self;
	}

	public ZeroShotClassificationInferenceOptionsDescriptor Labels(ICollection<string>? labels)
	{
		LabelsValue = labels;
		return Self;
	}

	public ZeroShotClassificationInferenceOptionsDescriptor MultiLabel(bool? multiLabel = true)
	{
		MultiLabelValue = multiLabel;
		return Self;
	}

	public ZeroShotClassificationInferenceOptionsDescriptor ResultsField(string? resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	public ZeroShotClassificationInferenceOptionsDescriptor Tokenization(Elastic.Clients.Elasticsearch.Ml.TokenizationConfig? tokenization)
	{
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = null;
		TokenizationValue = tokenization;
		return Self;
	}

	public ZeroShotClassificationInferenceOptionsDescriptor Tokenization(TokenizationConfigDescriptor descriptor)
	{
		TokenizationValue = null;
		TokenizationDescriptorAction = null;
		TokenizationDescriptor = descriptor;
		return Self;
	}

	public ZeroShotClassificationInferenceOptionsDescriptor Tokenization(Action<TokenizationConfigDescriptor> configure)
	{
		TokenizationValue = null;
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("classification_labels");
		JsonSerializer.Serialize(writer, ClassificationLabelsValue, options);
		if (!string.IsNullOrEmpty(HypothesisTemplateValue))
		{
			writer.WritePropertyName("hypothesis_template");
			writer.WriteStringValue(HypothesisTemplateValue);
		}

		if (LabelsValue is not null)
		{
			writer.WritePropertyName("labels");
			JsonSerializer.Serialize(writer, LabelsValue, options);
		}

		if (MultiLabelValue.HasValue)
		{
			writer.WritePropertyName("multi_label");
			writer.WriteBooleanValue(MultiLabelValue.Value);
		}

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