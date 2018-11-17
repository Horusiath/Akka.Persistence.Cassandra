#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="IManageSessions.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Akka.Actor;
using Cassandra;

namespace Akka.Persistence.Cassandra.SessionManagement
{
    /// <summary>
    /// Contract for extension responsible for resolving/releasing Cassandra ISession instances used by the
    /// Cassandra Persistence plugin.
    /// </summary>
    public interface IManageSessions : IExtension
    {
        /// <summary>
        /// Resolves the session with the key specified.
        /// </summary>
        ISession ResolveSession(string key);

        /// <summary>
        /// Releases the session instance.
        /// </summary>
        void ReleaseSession(ISession session);
    }
}