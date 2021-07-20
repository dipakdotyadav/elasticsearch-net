using System;
using System.Collections.Generic;
using Elastic.Transport;

namespace Tests.Core.Client.Settings
{
	/// <summary>
	///     ConnectionSettings sub class that is always in memory no matter if we are running in integration or unit test mode.
	///     Only use this if you expect a test to run in integration mode and you want to forcefully still use an in memory
	///     connection
	/// </summary>
	public class AlwaysInMemoryElasticsearchClientSettings : TestElasticsearchClientSettings
	{
		public AlwaysInMemoryElasticsearchClientSettings() : base(forceInMemory: true) { }

		public AlwaysInMemoryElasticsearchClientSettings(byte[] bytes) : base(forceInMemory: true, response: bytes) { }

		public AlwaysInMemoryElasticsearchClientSettings(
			Func<ICollection<Uri>, IConnectionPool> createPool = null,
			SourceSerializerFactory sourceSerializerFactory = null,
			int port = 9200
		)
			: base(
				createPool,
				sourceSerializerFactory,
				true,
				port
			)
		{
		}
	}
}
