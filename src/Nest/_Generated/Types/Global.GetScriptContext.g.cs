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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Global.GetScriptContext
{
	public partial class Context
	{
		[JsonPropertyName("methods")]
		public IReadOnlyCollection<Nest.Global.GetScriptContext.ContextMethod> Methods
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("name")]
		public Nest.Name Name
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ContextMethod
	{
		[JsonPropertyName("name")]
		public Nest.Name Name
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("params")]
		public IReadOnlyCollection<Nest.Global.GetScriptContext.ContextMethodParam> Params
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("return_type")]
		public string ReturnType
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ContextMethodParam
	{
		[JsonPropertyName("name")]
		public Nest.Name Name
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}