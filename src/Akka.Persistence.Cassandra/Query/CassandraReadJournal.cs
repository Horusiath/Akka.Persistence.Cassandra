#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="CassandraReadJournal.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Akka.Persistence.Cassandra.Journal;
using Akka.Persistence.Query;
using Akka.Streams.Dsl;

namespace Akka.Persistence.Cassandra.Query
{
    public class CassandraReadJournal : IReadJournal, IPersistenceIdsQuery, IEventsByPersistenceIdQuery, ICurrentEventsByPersistenceIdQuery, IEventsByTagQuery, ICurrentEventsByTagQuery, ICassandraStatements
    {
        public Source<string, NotUsed> PersistenceIds()
        {
            throw new System.NotImplementedException();
        }

        public Source<EventEnvelope, NotUsed> EventsByPersistenceId(string persistenceId, long fromSequenceNr, long toSequenceNr)
        {
            throw new System.NotImplementedException();
        }

        public Source<EventEnvelope, NotUsed> CurrentEventsByPersistenceId(string persistenceId, long fromSequenceNr, long toSequenceNr)
        {
            throw new System.NotImplementedException();
        }

        public Source<EventEnvelope, NotUsed> EventsByTag(string tag, Offset offset)
        {
            throw new System.NotImplementedException();
        }

        public Source<EventEnvelope, NotUsed> CurrentEventsByTag(string tag, Offset offset)
        {
            throw new System.NotImplementedException();
        }
    }
}