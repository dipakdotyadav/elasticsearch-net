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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class DateIndexNameProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "date_index_name";
		[JsonInclude]
		[JsonPropertyName("date_formats")]
		public IEnumerable<string> DateFormats { get; set; }

		[JsonInclude]
		[JsonPropertyName("date_rounding")]
		public string DateRounding { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_name_format")]
		public string IndexNameFormat { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_name_prefix")]
		public string IndexNamePrefix { get; set; }

		[JsonInclude]
		[JsonPropertyName("locale")]
		public string Locale { get; set; }

		[JsonInclude]
		[JsonPropertyName("timezone")]
		public string Timezone { get; set; }
	}

	public sealed partial class DateIndexNameProcessorDescriptor<T> : DescriptorBase<DateIndexNameProcessorDescriptor<T>>
	{
		public DateIndexNameProcessorDescriptor()
		{
		}

		internal DateIndexNameProcessorDescriptor(Action<DateIndexNameProcessorDescriptor<T>> configure) => configure.Invoke(this);
		internal IEnumerable<string> DateFormatsValue { get; private set; }

		internal string DateRoundingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field FieldValue { get; private set; }

		internal string IndexNameFormatValue { get; private set; }

		internal string IndexNamePrefixValue { get; private set; }

		internal string LocaleValue { get; private set; }

		internal string TimezoneValue { get; private set; }

		internal string? IfValue { get; private set; }

		internal bool? IgnoreFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal string? TagValue { get; private set; }

		public DateIndexNameProcessorDescriptor<T> DateFormats(IEnumerable<string> dateFormats) => Assign(dateFormats, (a, v) => a.DateFormatsValue = v);
		public DateIndexNameProcessorDescriptor<T> DateRounding(string dateRounding) => Assign(dateRounding, (a, v) => a.DateRoundingValue = v);
		public DateIndexNameProcessorDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field field) => Assign(field, (a, v) => a.FieldValue = v);
		public DateIndexNameProcessorDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public DateIndexNameProcessorDescriptor<T> IndexNameFormat(string indexNameFormat) => Assign(indexNameFormat, (a, v) => a.IndexNameFormatValue = v);
		public DateIndexNameProcessorDescriptor<T> IndexNamePrefix(string indexNamePrefix) => Assign(indexNamePrefix, (a, v) => a.IndexNamePrefixValue = v);
		public DateIndexNameProcessorDescriptor<T> Locale(string locale) => Assign(locale, (a, v) => a.LocaleValue = v);
		public DateIndexNameProcessorDescriptor<T> Timezone(string timezone) => Assign(timezone, (a, v) => a.TimezoneValue = v);
		public DateIndexNameProcessorDescriptor<T> If(string? ifValue) => Assign(ifValue, (a, v) => a.IfValue = v);
		public DateIndexNameProcessorDescriptor<T> IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailureValue = v);
		public DateIndexNameProcessorDescriptor<T> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public DateIndexNameProcessorDescriptor<T> Tag(string? tag) => Assign(tag, (a, v) => a.TagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("date_formats");
			JsonSerializer.Serialize(writer, DateFormatsValue, options);
			writer.WritePropertyName("date_rounding");
			writer.WriteStringValue(DateRoundingValue);
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("index_name_format");
			writer.WriteStringValue(IndexNameFormatValue);
			writer.WritePropertyName("index_name_prefix");
			writer.WriteStringValue(IndexNamePrefixValue);
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
			writer.WritePropertyName("timezone");
			writer.WriteStringValue(TimezoneValue);
			writer.WriteEndObject();
		}
	}
}