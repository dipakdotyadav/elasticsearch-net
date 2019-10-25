﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;
using Tests.Framework;
using System.Threading;
using Elastic.Xunit.XunitPlumbing;
using Elasticsearch.Net.Extensions;
using Tests.Domain.Extensions;

// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable SuggestVarOrType_SimpleTypes

namespace Tests.ClientConcepts.LowLevel
{
	public class LowLevelResponseTypes
	{
		/**[[low-level-response-types]]
		 * === Low Level Client Response Types
		 *
		 */

		public static string Response()
		{
			return @"{
			""boolean"" : true,	
			""string"" : ""v"",
			""array"" : [1, 2, 3, 4],
			""object"" : {
				""first"" : ""value1"",
				""second"" : ""value2"",
				""nested"" : { ""x"" : ""value3"" }
			},
			""array_of_objects"" : [
				{
					""first"" : ""value11"",
					""second"" : ""value12"",
					""nested"" : { ""x"" : ""value4"" }
				},
				{
					""first"" : ""value21"",
					""second"" : ""value22"",
					""nested"" : { ""x"" : ""value5"" },
					""complex.nested"" : { ""x"" : ""value6"" }
				}
			]
		}";
		}

		public LowLevelResponseTypes()
		{
			var connection = new InMemoryConnection(Response().Utf8Bytes());
			this.Client = new ElasticClient(new ConnectionSettings(connection).ApplyDomainSettings());
		}

		private ElasticClient Client { get;  }


		[U] public void DynamicResponse()
		{
			/**[float]
			* === DynamicResponse
			*
			*/

			var response = Client.LowLevel.Search<DynamicResponse>(PostData.Empty);

			response.Get<string>("object.first").Should()
				.NotBeEmpty()
				.And.Be("value1");

			response.Get<string>("object._arbitrary_key_").Should()
				.NotBeEmpty()
				.And.Be("first");

			response.Get<int>("array.1").Should().Be(2);
			response.Get<long>("array.1").Should().Be(2);

			response.Get<string>("array_of_objects.1.second").Should()
				.NotBeEmpty()
				.And.Be("value22");

			response.Get<string>("array_of_objects.1.complex\\.nested.x").Should()
				.NotBeEmpty()
				.And.Be("value6");

		}

	}
}