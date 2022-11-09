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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Elastic.Transport;
using Elastic.Clients.Elasticsearch.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch;
[JsonConverter(typeof(ConflictsConverter))]
public enum Conflicts
{
	[EnumMember(Value = "proceed")]
	Proceed,
	[EnumMember(Value = "abort")]
	Abort
}

internal sealed class ConflictsConverter : JsonConverter<Conflicts>
{
	public override Conflicts Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "proceed":
				return Conflicts.Proceed;
			case "abort":
				return Conflicts.Abort;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, Conflicts value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case Conflicts.Proceed:
				writer.WriteStringValue("proceed");
				return;
			case Conflicts.Abort:
				writer.WriteStringValue("abort");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(DFIIndependenceMeasureConverter))]
public enum DFIIndependenceMeasure
{
	[EnumMember(Value = "standardized")]
	Standardized,
	[EnumMember(Value = "saturated")]
	Saturated,
	[EnumMember(Value = "chisquared")]
	Chisquared
}

internal sealed class DFIIndependenceMeasureConverter : JsonConverter<DFIIndependenceMeasure>
{
	public override DFIIndependenceMeasure Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "standardized":
				return DFIIndependenceMeasure.Standardized;
			case "saturated":
				return DFIIndependenceMeasure.Saturated;
			case "chisquared":
				return DFIIndependenceMeasure.Chisquared;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, DFIIndependenceMeasure value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case DFIIndependenceMeasure.Standardized:
				writer.WriteStringValue("standardized");
				return;
			case DFIIndependenceMeasure.Saturated:
				writer.WriteStringValue("saturated");
				return;
			case DFIIndependenceMeasure.Chisquared:
				writer.WriteStringValue("chisquared");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(DFRAfterEffectConverter))]
public enum DFRAfterEffect
{
	[EnumMember(Value = "no")]
	No,
	[EnumMember(Value = "l")]
	l,
	[EnumMember(Value = "b")]
	b
}

internal sealed class DFRAfterEffectConverter : JsonConverter<DFRAfterEffect>
{
	public override DFRAfterEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "no":
				return DFRAfterEffect.No;
			case "l":
				return DFRAfterEffect.l;
			case "b":
				return DFRAfterEffect.b;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, DFRAfterEffect value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case DFRAfterEffect.No:
				writer.WriteStringValue("no");
				return;
			case DFRAfterEffect.l:
				writer.WriteStringValue("l");
				return;
			case DFRAfterEffect.b:
				writer.WriteStringValue("b");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(DFRBasicModelConverter))]
public enum DFRBasicModel
{
	[EnumMember(Value = "p")]
	p,
	[EnumMember(Value = "ine")]
	Ine,
	[EnumMember(Value = "in")]
	In,
	[EnumMember(Value = "if")]
	If,
	[EnumMember(Value = "g")]
	g,
	[EnumMember(Value = "d")]
	d,
	[EnumMember(Value = "be")]
	Be
}

internal sealed class DFRBasicModelConverter : JsonConverter<DFRBasicModel>
{
	public override DFRBasicModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "p":
				return DFRBasicModel.p;
			case "ine":
				return DFRBasicModel.Ine;
			case "in":
				return DFRBasicModel.In;
			case "if":
				return DFRBasicModel.If;
			case "g":
				return DFRBasicModel.g;
			case "d":
				return DFRBasicModel.d;
			case "be":
				return DFRBasicModel.Be;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, DFRBasicModel value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case DFRBasicModel.p:
				writer.WriteStringValue("p");
				return;
			case DFRBasicModel.Ine:
				writer.WriteStringValue("ine");
				return;
			case DFRBasicModel.In:
				writer.WriteStringValue("in");
				return;
			case DFRBasicModel.If:
				writer.WriteStringValue("if");
				return;
			case DFRBasicModel.g:
				writer.WriteStringValue("g");
				return;
			case DFRBasicModel.d:
				writer.WriteStringValue("d");
				return;
			case DFRBasicModel.Be:
				writer.WriteStringValue("be");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(DistanceUnitConverter))]
public enum DistanceUnit
{
	[EnumMember(Value = "yd")]
	Yards,
	[EnumMember(Value = "nmi")]
	NauticMiles,
	[EnumMember(Value = "mm")]
	Millimeters,
	[EnumMember(Value = "mi")]
	Miles,
	[EnumMember(Value = "m")]
	Meters,
	[EnumMember(Value = "km")]
	Kilometers,
	[EnumMember(Value = "in")]
	Inches,
	[EnumMember(Value = "ft")]
	Feet,
	[EnumMember(Value = "cm")]
	Centimeters
}

internal sealed class DistanceUnitConverter : JsonConverter<DistanceUnit>
{
	public override DistanceUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "yd":
				return DistanceUnit.Yards;
			case "nmi":
				return DistanceUnit.NauticMiles;
			case "mm":
				return DistanceUnit.Millimeters;
			case "mi":
				return DistanceUnit.Miles;
			case "m":
				return DistanceUnit.Meters;
			case "km":
				return DistanceUnit.Kilometers;
			case "in":
				return DistanceUnit.Inches;
			case "ft":
				return DistanceUnit.Feet;
			case "cm":
				return DistanceUnit.Centimeters;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, DistanceUnit value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case DistanceUnit.Yards:
				writer.WriteStringValue("yd");
				return;
			case DistanceUnit.NauticMiles:
				writer.WriteStringValue("nmi");
				return;
			case DistanceUnit.Millimeters:
				writer.WriteStringValue("mm");
				return;
			case DistanceUnit.Miles:
				writer.WriteStringValue("mi");
				return;
			case DistanceUnit.Meters:
				writer.WriteStringValue("m");
				return;
			case DistanceUnit.Kilometers:
				writer.WriteStringValue("km");
				return;
			case DistanceUnit.Inches:
				writer.WriteStringValue("in");
				return;
			case DistanceUnit.Feet:
				writer.WriteStringValue("ft");
				return;
			case DistanceUnit.Centimeters:
				writer.WriteStringValue("cm");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(ExpandWildcardConverter))]
public enum ExpandWildcard
{
	[EnumMember(Value = "open")]
	Open,
	[EnumMember(Value = "none")]
	None,
	[EnumMember(Value = "hidden")]
	Hidden,
	[EnumMember(Value = "closed")]
	Closed,
	[EnumMember(Value = "all")]
	All
}

internal sealed class ExpandWildcardConverter : JsonConverter<ExpandWildcard>
{
	public override ExpandWildcard Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "open":
				return ExpandWildcard.Open;
			case "none":
				return ExpandWildcard.None;
			case "hidden":
				return ExpandWildcard.Hidden;
			case "closed":
				return ExpandWildcard.Closed;
			case "all":
				return ExpandWildcard.All;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, ExpandWildcard value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ExpandWildcard.Open:
				writer.WriteStringValue("open");
				return;
			case ExpandWildcard.None:
				writer.WriteStringValue("none");
				return;
			case ExpandWildcard.Hidden:
				writer.WriteStringValue("hidden");
				return;
			case ExpandWildcard.Closed:
				writer.WriteStringValue("closed");
				return;
			case ExpandWildcard.All:
				writer.WriteStringValue("all");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(FieldSortNumericTypeConverter))]
public enum FieldSortNumericType
{
	[EnumMember(Value = "long")]
	Long,
	[EnumMember(Value = "double")]
	Double,
	[EnumMember(Value = "date_nanos")]
	DateNanos,
	[EnumMember(Value = "date")]
	Date
}

internal sealed class FieldSortNumericTypeConverter : JsonConverter<FieldSortNumericType>
{
	public override FieldSortNumericType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "long":
				return FieldSortNumericType.Long;
			case "double":
				return FieldSortNumericType.Double;
			case "date_nanos":
				return FieldSortNumericType.DateNanos;
			case "date":
				return FieldSortNumericType.Date;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, FieldSortNumericType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case FieldSortNumericType.Long:
				writer.WriteStringValue("long");
				return;
			case FieldSortNumericType.Double:
				writer.WriteStringValue("double");
				return;
			case FieldSortNumericType.DateNanos:
				writer.WriteStringValue("date_nanos");
				return;
			case FieldSortNumericType.Date:
				writer.WriteStringValue("date");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(HealthStatusConverter))]
public enum HealthStatus
{
	[EnumMember(Value = "yellow")]
	Yellow,
	[EnumMember(Value = "red")]
	Red,
	[EnumMember(Value = "green")]
	Green
}

internal sealed class HealthStatusConverter : JsonConverter<HealthStatus>
{
	public override HealthStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "yellow":
				return HealthStatus.Yellow;
			case "red":
				return HealthStatus.Red;
			case "green":
				return HealthStatus.Green;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, HealthStatus value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case HealthStatus.Yellow:
				writer.WriteStringValue("yellow");
				return;
			case HealthStatus.Red:
				writer.WriteStringValue("red");
				return;
			case HealthStatus.Green:
				writer.WriteStringValue("green");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(IBDistributionConverter))]
public enum IBDistribution
{
	[EnumMember(Value = "spl")]
	Spl,
	[EnumMember(Value = "ll")]
	Ll
}

internal sealed class IBDistributionConverter : JsonConverter<IBDistribution>
{
	public override IBDistribution Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "spl":
				return IBDistribution.Spl;
			case "ll":
				return IBDistribution.Ll;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, IBDistribution value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case IBDistribution.Spl:
				writer.WriteStringValue("spl");
				return;
			case IBDistribution.Ll:
				writer.WriteStringValue("ll");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(IBLambdaConverter))]
public enum IBLambda
{
	[EnumMember(Value = "ttf")]
	Ttf,
	[EnumMember(Value = "df")]
	Df
}

internal sealed class IBLambdaConverter : JsonConverter<IBLambda>
{
	public override IBLambda Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "ttf":
				return IBLambda.Ttf;
			case "df":
				return IBLambda.Df;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, IBLambda value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case IBLambda.Ttf:
				writer.WriteStringValue("ttf");
				return;
			case IBLambda.Df:
				writer.WriteStringValue("df");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(LevelConverter))]
public enum Level
{
	[EnumMember(Value = "shards")]
	Shards,
	[EnumMember(Value = "indices")]
	Indices,
	[EnumMember(Value = "cluster")]
	Cluster
}

internal sealed class LevelConverter : JsonConverter<Level>
{
	public override Level Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "shards":
				return Level.Shards;
			case "indices":
				return Level.Indices;
			case "cluster":
				return Level.Cluster;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, Level value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case Level.Shards:
				writer.WriteStringValue("shards");
				return;
			case Level.Indices:
				writer.WriteStringValue("indices");
				return;
			case Level.Cluster:
				writer.WriteStringValue("cluster");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(NodeRoleConverter))]
public enum NodeRole
{
	[EnumMember(Value = "voting_only")]
	VotingOnly,
	[EnumMember(Value = "transform")]
	Transform,
	[EnumMember(Value = "remote_cluster_client")]
	RemoteClusterClient,
	[EnumMember(Value = "ml")]
	Ml,
	[EnumMember(Value = "master")]
	Master,
	[EnumMember(Value = "ingest")]
	Ingest,
	[EnumMember(Value = "data_warm")]
	DataWarm,
	[EnumMember(Value = "data_hot")]
	DataHot,
	[EnumMember(Value = "data_frozen")]
	DataFrozen,
	[EnumMember(Value = "data_content")]
	DataContent,
	[EnumMember(Value = "data_cold")]
	DataCold,
	[EnumMember(Value = "data")]
	Data,
	[EnumMember(Value = "coordinating_only")]
	CoordinatingOnly,
	[EnumMember(Value = "client")]
	Client
}

internal sealed class NodeRoleConverter : JsonConverter<NodeRole>
{
	public override NodeRole Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "voting_only":
				return NodeRole.VotingOnly;
			case "transform":
				return NodeRole.Transform;
			case "remote_cluster_client":
				return NodeRole.RemoteClusterClient;
			case "ml":
				return NodeRole.Ml;
			case "master":
				return NodeRole.Master;
			case "ingest":
				return NodeRole.Ingest;
			case "data_warm":
				return NodeRole.DataWarm;
			case "data_hot":
				return NodeRole.DataHot;
			case "data_frozen":
				return NodeRole.DataFrozen;
			case "data_content":
				return NodeRole.DataContent;
			case "data_cold":
				return NodeRole.DataCold;
			case "data":
				return NodeRole.Data;
			case "coordinating_only":
				return NodeRole.CoordinatingOnly;
			case "client":
				return NodeRole.Client;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, NodeRole value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case NodeRole.VotingOnly:
				writer.WriteStringValue("voting_only");
				return;
			case NodeRole.Transform:
				writer.WriteStringValue("transform");
				return;
			case NodeRole.RemoteClusterClient:
				writer.WriteStringValue("remote_cluster_client");
				return;
			case NodeRole.Ml:
				writer.WriteStringValue("ml");
				return;
			case NodeRole.Master:
				writer.WriteStringValue("master");
				return;
			case NodeRole.Ingest:
				writer.WriteStringValue("ingest");
				return;
			case NodeRole.DataWarm:
				writer.WriteStringValue("data_warm");
				return;
			case NodeRole.DataHot:
				writer.WriteStringValue("data_hot");
				return;
			case NodeRole.DataFrozen:
				writer.WriteStringValue("data_frozen");
				return;
			case NodeRole.DataContent:
				writer.WriteStringValue("data_content");
				return;
			case NodeRole.DataCold:
				writer.WriteStringValue("data_cold");
				return;
			case NodeRole.Data:
				writer.WriteStringValue("data");
				return;
			case NodeRole.CoordinatingOnly:
				writer.WriteStringValue("coordinating_only");
				return;
			case NodeRole.Client:
				writer.WriteStringValue("client");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(NormalizationConverter))]
public enum Normalization
{
	[EnumMember(Value = "z")]
	z,
	[EnumMember(Value = "no")]
	No,
	[EnumMember(Value = "h3")]
	H3,
	[EnumMember(Value = "h2")]
	H2,
	[EnumMember(Value = "h1")]
	H1
}

internal sealed class NormalizationConverter : JsonConverter<Normalization>
{
	public override Normalization Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "z":
				return Normalization.z;
			case "no":
				return Normalization.No;
			case "h3":
				return Normalization.H3;
			case "h2":
				return Normalization.H2;
			case "h1":
				return Normalization.H1;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, Normalization value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case Normalization.z:
				writer.WriteStringValue("z");
				return;
			case Normalization.No:
				writer.WriteStringValue("no");
				return;
			case Normalization.H3:
				writer.WriteStringValue("h3");
				return;
			case Normalization.H2:
				writer.WriteStringValue("h2");
				return;
			case Normalization.H1:
				writer.WriteStringValue("h1");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(ResultConverter))]
public enum Result
{
	[EnumMember(Value = "updated")]
	Updated,
	[EnumMember(Value = "not_found")]
	NotFound,
	[EnumMember(Value = "noop")]
	NoOp,
	[EnumMember(Value = "deleted")]
	Deleted,
	[EnumMember(Value = "created")]
	Created
}

internal sealed class ResultConverter : JsonConverter<Result>
{
	public override Result Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "updated":
				return Result.Updated;
			case "not_found":
				return Result.NotFound;
			case "noop":
				return Result.NoOp;
			case "deleted":
				return Result.Deleted;
			case "created":
				return Result.Created;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, Result value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case Result.Updated:
				writer.WriteStringValue("updated");
				return;
			case Result.NotFound:
				writer.WriteStringValue("not_found");
				return;
			case Result.NoOp:
				writer.WriteStringValue("noop");
				return;
			case Result.Deleted:
				writer.WriteStringValue("deleted");
				return;
			case Result.Created:
				writer.WriteStringValue("created");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(EnumStructConverter<ScriptLanguage>))]
public readonly partial struct ScriptLanguage
{
	public ScriptLanguage(string value) => Value = value;
	public readonly string Value { get; }

	public static ScriptLanguage Painless { get; } = new ScriptLanguage("painless");
	public static ScriptLanguage Mustache { get; } = new ScriptLanguage("mustache");
	public static ScriptLanguage Java { get; } = new ScriptLanguage("java");
	public static ScriptLanguage Expression { get; } = new ScriptLanguage("expression");
	public override string ToString() => Value ?? string.Empty;
	public static implicit operator string(ScriptLanguage scriptLanguage) => scriptLanguage.Value;
	public static implicit operator ScriptLanguage(string value) => new(value);
	public override int GetHashCode() => Value.GetHashCode();
	public override bool Equals(object obj) => obj is ScriptLanguage other && this.Equals(other);
	public bool Equals(ScriptLanguage other) => Value == other.Value;
	public static bool operator ==(ScriptLanguage a, ScriptLanguage b) => a.Equals(b);
	public static bool operator !=(ScriptLanguage a, ScriptLanguage b) => !(a == b);
}

[JsonConverter(typeof(ScriptSortTypeConverter))]
public enum ScriptSortType
{
	[EnumMember(Value = "version")]
	Version,
	[EnumMember(Value = "string")]
	String,
	[EnumMember(Value = "number")]
	Number
}

internal sealed class ScriptSortTypeConverter : JsonConverter<ScriptSortType>
{
	public override ScriptSortType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "version":
				return ScriptSortType.Version;
			case "string":
				return ScriptSortType.String;
			case "number":
				return ScriptSortType.Number;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, ScriptSortType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case ScriptSortType.Version:
				writer.WriteStringValue("version");
				return;
			case ScriptSortType.String:
				writer.WriteStringValue("string");
				return;
			case ScriptSortType.Number:
				writer.WriteStringValue("number");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SearchTypeConverter))]
public enum SearchType
{
	[EnumMember(Value = "query_then_fetch")]
	QueryThenFetch,
	[EnumMember(Value = "dfs_query_then_fetch")]
	DfsQueryThenFetch
}

internal sealed class SearchTypeConverter : JsonConverter<SearchType>
{
	public override SearchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "query_then_fetch":
				return SearchType.QueryThenFetch;
			case "dfs_query_then_fetch":
				return SearchType.DfsQueryThenFetch;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, SearchType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SearchType.QueryThenFetch:
				writer.WriteStringValue("query_then_fetch");
				return;
			case SearchType.DfsQueryThenFetch:
				writer.WriteStringValue("dfs_query_then_fetch");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SlicesCalculationConverter))]
public enum SlicesCalculation
{
	[EnumMember(Value = "auto")]
	Auto
}

internal sealed class SlicesCalculationConverter : JsonConverter<SlicesCalculation>
{
	public override SlicesCalculation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "auto":
				return SlicesCalculation.Auto;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, SlicesCalculation value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SlicesCalculation.Auto:
				writer.WriteStringValue("auto");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SortModeConverter))]
public enum SortMode
{
	[EnumMember(Value = "sum")]
	Sum,
	[EnumMember(Value = "min")]
	Min,
	[EnumMember(Value = "median")]
	Median,
	[EnumMember(Value = "max")]
	Max,
	[EnumMember(Value = "avg")]
	Avg
}

internal sealed class SortModeConverter : JsonConverter<SortMode>
{
	public override SortMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "sum":
				return SortMode.Sum;
			case "min":
				return SortMode.Min;
			case "median":
				return SortMode.Median;
			case "max":
				return SortMode.Max;
			case "avg":
				return SortMode.Avg;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, SortMode value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SortMode.Sum:
				writer.WriteStringValue("sum");
				return;
			case SortMode.Min:
				writer.WriteStringValue("min");
				return;
			case SortMode.Median:
				writer.WriteStringValue("median");
				return;
			case SortMode.Max:
				writer.WriteStringValue("max");
				return;
			case SortMode.Avg:
				writer.WriteStringValue("avg");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SortOrderConverter))]
public enum SortOrder
{
	[EnumMember(Value = "desc")]
	Desc,
	[EnumMember(Value = "asc")]
	Asc
}

internal sealed class SortOrderConverter : JsonConverter<SortOrder>
{
	public override SortOrder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "desc":
				return SortOrder.Desc;
			case "asc":
				return SortOrder.Asc;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, SortOrder value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SortOrder.Desc:
				writer.WriteStringValue("desc");
				return;
			case SortOrder.Asc:
				writer.WriteStringValue("asc");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(SuggestModeConverter))]
public enum SuggestMode
{
	[EnumMember(Value = "popular")]
	Popular,
	[EnumMember(Value = "missing")]
	Missing,
	[EnumMember(Value = "always")]
	Always
}

internal sealed class SuggestModeConverter : JsonConverter<SuggestMode>
{
	public override SuggestMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "popular":
				return SuggestMode.Popular;
			case "missing":
				return SuggestMode.Missing;
			case "always":
				return SuggestMode.Always;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, SuggestMode value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case SuggestMode.Popular:
				writer.WriteStringValue("popular");
				return;
			case SuggestMode.Missing:
				writer.WriteStringValue("missing");
				return;
			case SuggestMode.Always:
				writer.WriteStringValue("always");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(TimeUnitConverter))]
public enum TimeUnit
{
	[EnumMember(Value = "s")]
	Seconds,
	[EnumMember(Value = "nanos")]
	Nanoseconds,
	[EnumMember(Value = "ms")]
	Milliseconds,
	[EnumMember(Value = "micros")]
	Microseconds,
	[EnumMember(Value = "m")]
	Minutes,
	[EnumMember(Value = "h")]
	Hours,
	[EnumMember(Value = "d")]
	Days
}

internal sealed class TimeUnitConverter : JsonConverter<TimeUnit>
{
	public override TimeUnit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "s":
				return TimeUnit.Seconds;
			case "nanos":
				return TimeUnit.Nanoseconds;
			case "ms":
				return TimeUnit.Milliseconds;
			case "micros":
				return TimeUnit.Microseconds;
			case "m":
				return TimeUnit.Minutes;
			case "h":
				return TimeUnit.Hours;
			case "d":
				return TimeUnit.Days;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, TimeUnit value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case TimeUnit.Seconds:
				writer.WriteStringValue("s");
				return;
			case TimeUnit.Nanoseconds:
				writer.WriteStringValue("nanos");
				return;
			case TimeUnit.Milliseconds:
				writer.WriteStringValue("ms");
				return;
			case TimeUnit.Microseconds:
				writer.WriteStringValue("micros");
				return;
			case TimeUnit.Minutes:
				writer.WriteStringValue("m");
				return;
			case TimeUnit.Hours:
				writer.WriteStringValue("h");
				return;
			case TimeUnit.Days:
				writer.WriteStringValue("d");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(VersionTypeConverter))]
public enum VersionType
{
	[EnumMember(Value = "internal")]
	Internal,
	[EnumMember(Value = "force")]
	Force,
	[EnumMember(Value = "external_gte")]
	ExternalGte,
	[EnumMember(Value = "external")]
	External
}

internal sealed class VersionTypeConverter : JsonConverter<VersionType>
{
	public override VersionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "internal":
				return VersionType.Internal;
			case "force":
				return VersionType.Force;
			case "external_gte":
				return VersionType.ExternalGte;
			case "external":
				return VersionType.External;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, VersionType value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case VersionType.Internal:
				writer.WriteStringValue("internal");
				return;
			case VersionType.Force:
				writer.WriteStringValue("force");
				return;
			case VersionType.ExternalGte:
				writer.WriteStringValue("external_gte");
				return;
			case VersionType.External:
				writer.WriteStringValue("external");
				return;
		}

		writer.WriteNullValue();
	}
}

[JsonConverter(typeof(WaitForEventsConverter))]
public enum WaitForEvents
{
	[EnumMember(Value = "urgent")]
	Urgent,
	[EnumMember(Value = "normal")]
	Normal,
	[EnumMember(Value = "low")]
	Low,
	[EnumMember(Value = "languid")]
	Languid,
	[EnumMember(Value = "immediate")]
	Immediate,
	[EnumMember(Value = "high")]
	High
}

internal sealed class WaitForEventsConverter : JsonConverter<WaitForEvents>
{
	public override WaitForEvents Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var enumString = reader.GetString();
		switch (enumString)
		{
			case "urgent":
				return WaitForEvents.Urgent;
			case "normal":
				return WaitForEvents.Normal;
			case "low":
				return WaitForEvents.Low;
			case "languid":
				return WaitForEvents.Languid;
			case "immediate":
				return WaitForEvents.Immediate;
			case "high":
				return WaitForEvents.High;
		}

		ThrowHelper.ThrowJsonException();
		return default;
	}

	public override void Write(Utf8JsonWriter writer, WaitForEvents value, JsonSerializerOptions options)
	{
		switch (value)
		{
			case WaitForEvents.Urgent:
				writer.WriteStringValue("urgent");
				return;
			case WaitForEvents.Normal:
				writer.WriteStringValue("normal");
				return;
			case WaitForEvents.Low:
				writer.WriteStringValue("low");
				return;
			case WaitForEvents.Languid:
				writer.WriteStringValue("languid");
				return;
			case WaitForEvents.Immediate:
				writer.WriteStringValue("immediate");
				return;
			case WaitForEvents.High:
				writer.WriteStringValue("high");
				return;
		}

		writer.WriteNullValue();
	}
}