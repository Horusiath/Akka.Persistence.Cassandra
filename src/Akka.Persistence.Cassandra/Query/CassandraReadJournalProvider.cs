#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="CassandraReadJournalProvider.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Akka.Persistence.Query;

namespace Akka.Persistence.Cassandra.Query
{
    public class CassandraReadJournalProvider : IReadJournalProvider
    {
        public IReadJournal GetReadJournal()
        {
            throw new System.NotImplementedException();
        }
    }
}