#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="CassandraSession.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Akka.Actor;

namespace Akka.Persistence.Cassandra.SessionManagement
{
    /// <summary>
    /// Extension Id provider for Cassandra Session management extension.
    /// </summary>
    public class CassandraSession : ExtensionIdProvider<IManageSessions>
    {
        public static CassandraSession Instance = new CassandraSession();

        public override IManageSessions CreateExtension(ExtendedActorSystem system)
        {
            return new DefaultSessionManager(system);
        }
    }
}