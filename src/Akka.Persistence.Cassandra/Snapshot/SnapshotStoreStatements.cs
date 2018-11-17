#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="SnapshotStoreStatements.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using Cassandra;

namespace Akka.Persistence.Cassandra.Snapshot
{
    /// <summary>
    /// CQL strings used by the CassandraSnapshotStore.
    /// </summary>
    internal static class SnapshotStoreStatements
    {
        public const string CreateKeyspace = @"
            CREATE KEYSPACE IF NOT EXISTS {0}
            WITH {1}";

        public const string CreateTable = @"
            CREATE TABLE IF NOT EXISTS {0} (
                persistence_id text,
                sequence_number bigint,
                timestamp_ticks bigint,
                snapshot blob,
                PRIMARY KEY (persistence_id, sequence_number)
            ) WITH CLUSTERING ORDER BY (sequence_number DESC){1}{2}";

        public const string WriteSnapshot = @"
            INSERT INTO {0} (persistence_id, sequence_number, timestamp_ticks, snapshot)
            VALUES (?, ?, ?, ?)";

        public const string DeleteSnapshot = @"
            DELETE FROM {0} WHERE persistence_id = ? AND sequence_number = ?";

        public const string SelectSnapshot = @"
            SELECT snapshot FROM {0} WHERE persistence_id = ? AND sequence_number = ?";

        public const string SelectSnapshotMetadata = @"
            SELECT persistence_id, sequence_number, timestamp_ticks FROM {0}
            WHERE persistence_id = ? AND sequence_number <= ?";
    }
}
