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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System.Runtime.Serialization;

#nullable restore
namespace Nest.Ml
{
	public readonly partial struct AppliesTo
	{
		public AppliesTo(string value) => Value = value;
		public string Value { get; }

		public static AppliesTo Typical { get; } = new AppliesTo("typical");
		public static AppliesTo Time { get; } = new AppliesTo("time");
		public static AppliesTo DiffFromTypical { get; } = new AppliesTo("diff_from_typical");
		public static AppliesTo Actual { get; } = new AppliesTo("actual");
	}

	public readonly partial struct CategorizationStatus
	{
		public CategorizationStatus(string value) => Value = value;
		public string Value { get; }

		public static CategorizationStatus Warn { get; } = new CategorizationStatus("warn");
		public static CategorizationStatus Ok { get; } = new CategorizationStatus("ok");
	}

	public readonly partial struct ChunkingMode
	{
		public ChunkingMode(string value) => Value = value;
		public string Value { get; }

		public static ChunkingMode Off { get; } = new ChunkingMode("off");
		public static ChunkingMode Manual { get; } = new ChunkingMode("manual");
		public static ChunkingMode Auto { get; } = new ChunkingMode("auto");
	}

	public readonly partial struct ConditionOperator
	{
		public ConditionOperator(string value) => Value = value;
		public string Value { get; }

		public static ConditionOperator Lte { get; } = new ConditionOperator("lte");
		public static ConditionOperator Lt { get; } = new ConditionOperator("lt");
		public static ConditionOperator Gte { get; } = new ConditionOperator("gte");
		public static ConditionOperator Gt { get; } = new ConditionOperator("gt");
	}

	public readonly partial struct DatafeedState
	{
		public DatafeedState(string value) => Value = value;
		public string Value { get; }

		public static DatafeedState Stopping { get; } = new DatafeedState("stopping");
		public static DatafeedState Stopped { get; } = new DatafeedState("stopped");
		public static DatafeedState Starting { get; } = new DatafeedState("starting");
		public static DatafeedState Started { get; } = new DatafeedState("started");
	}

	public readonly partial struct DataframeState
	{
		public DataframeState(string value) => Value = value;
		public string Value { get; }

		public static DataframeState Stopping { get; } = new DataframeState("stopping");
		public static DataframeState Stopped { get; } = new DataframeState("stopped");
		public static DataframeState Starting { get; } = new DataframeState("starting");
		public static DataframeState Started { get; } = new DataframeState("started");
		public static DataframeState Failed { get; } = new DataframeState("failed");
	}

	public readonly partial struct ExcludeFrequent
	{
		public ExcludeFrequent(string value) => Value = value;
		public string Value { get; }

		public static ExcludeFrequent Over { get; } = new ExcludeFrequent("over");
		public static ExcludeFrequent None { get; } = new ExcludeFrequent("none");
		public static ExcludeFrequent By { get; } = new ExcludeFrequent("by");
		public static ExcludeFrequent All { get; } = new ExcludeFrequent("all");
	}

	public readonly partial struct FilterType
	{
		public FilterType(string value) => Value = value;
		public string Value { get; }

		public static FilterType Include { get; } = new FilterType("include");
		public static FilterType Exclude { get; } = new FilterType("exclude");
	}

	public readonly partial struct JobBlockedReason
	{
		public JobBlockedReason(string value) => Value = value;
		public string Value { get; }

		public static JobBlockedReason Revert { get; } = new JobBlockedReason("revert");
		public static JobBlockedReason Reset { get; } = new JobBlockedReason("reset");
		public static JobBlockedReason Delete { get; } = new JobBlockedReason("delete");
	}

	public readonly partial struct JobState
	{
		public JobState(string value) => Value = value;
		public string Value { get; }

		public static JobState Opening { get; } = new JobState("opening");
		public static JobState Opened { get; } = new JobState("opened");
		public static JobState Failed { get; } = new JobState("failed");
		public static JobState Closing { get; } = new JobState("closing");
		public static JobState Closed { get; } = new JobState("closed");
	}

	public readonly partial struct MemoryStatus
	{
		public MemoryStatus(string value) => Value = value;
		public string Value { get; }

		public static MemoryStatus SoftLimit { get; } = new MemoryStatus("soft_limit");
		public static MemoryStatus Ok { get; } = new MemoryStatus("ok");
		public static MemoryStatus HardLimit { get; } = new MemoryStatus("hard_limit");
	}

	public readonly partial struct RuleAction
	{
		public RuleAction(string value) => Value = value;
		public string Value { get; }

		public static RuleAction SkipResult { get; } = new RuleAction("skip_result");
		public static RuleAction SkipModelUpdate { get; } = new RuleAction("skip_model_update");
	}
}