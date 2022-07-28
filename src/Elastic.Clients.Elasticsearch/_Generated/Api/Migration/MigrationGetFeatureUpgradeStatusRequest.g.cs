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
namespace Elastic.Clients.Elasticsearch.Migration
{
	public sealed class MigrationGetFeatureUpgradeStatusRequestParameters : RequestParameters<MigrationGetFeatureUpgradeStatusRequestParameters>
	{
	}

	public sealed partial class MigrationGetFeatureUpgradeStatusRequest : PlainRequestBase<MigrationGetFeatureUpgradeStatusRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.MigrationGetFeatureUpgradeStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public sealed partial class MigrationGetFeatureUpgradeStatusRequestDescriptor : RequestDescriptorBase<MigrationGetFeatureUpgradeStatusRequestDescriptor, MigrationGetFeatureUpgradeStatusRequestParameters>
	{
		internal MigrationGetFeatureUpgradeStatusRequestDescriptor(Action<MigrationGetFeatureUpgradeStatusRequestDescriptor> configure) => configure.Invoke(this);
		public MigrationGetFeatureUpgradeStatusRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MigrationGetFeatureUpgradeStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}