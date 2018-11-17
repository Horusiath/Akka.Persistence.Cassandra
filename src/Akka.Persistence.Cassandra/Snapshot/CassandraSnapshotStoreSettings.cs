#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="CassandraSnapshotStoreSettings.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Akka.Configuration;

namespace Akka.Persistence.Cassandra.Snapshot
{
    /// <summary>
    /// Settings for the Cassandra snapshot store implementation, parsed from HOCON configuration.
    /// </summary>
    public class CassandraSnapshotStoreSettings : CassandraSettings
    {
        /// <summary>
        /// The maximum number of snapshot metadata records to retrieve in a single request when trying to find
        /// snapshots that meet criteria.
        /// </summary>
        public int MaxMetadataResultSize { get; private set; }

        public CassandraSnapshotStoreSettings(Config config) 
            : base(config)
        {
            MaxMetadataResultSize = config.GetInt("max-metadata-result-size");
        }
    }
}
