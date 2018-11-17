#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="CassandraJournalSettings.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Akka.Configuration;

namespace Akka.Persistence.Cassandra.Journal
{
    /// <summary>
    /// Settings for the Cassandra journal implementation, parsed from HOCON configuration.
    /// </summary>
    public class CassandraJournalSettings : CassandraSettings
    {
        /// <summary>
        /// The approximate number of rows per partition to use. Cannot be changed after table creation.
        /// </summary>
        public long PartitionSize { get; private set; }

        /// <summary>
        /// The maximum number of messages to retrieve in one request when replaying messages.
        /// </summary>
        public int MaxResultSize { get; private set; }

        public CassandraJournalSettings(Config config)
            : base(config)
        {
            PartitionSize = config.GetLong("partition-size");
            MaxResultSize = config.GetInt("max-result-size");
        }
    }
}