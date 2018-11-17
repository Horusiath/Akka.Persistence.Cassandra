#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="ExtensionMethods.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using Akka.Actor;
using Cassandra;

namespace Akka.Persistence.Cassandra
{
    /// <summary>
    /// Extension methods used by the Cassandra persistence plugin.
    /// </summary>
    internal static class ExtensionMethods
    {
       /// <summary>
        /// Gets the PersistenceExtension instance registered with the ActorSystem. Throws an InvalidOperationException if not found.
        /// </summary>
        internal static PersistenceExtension PersistenceExtension(this ActorSystem system)
        {
            var ext = system.GetExtension<PersistenceExtension>();
            if (ext == null)
                throw new InvalidOperationException("Persistence extension not found.");

            return ext;
        }

        /// <summary>
        /// Prepares a CQL string with format arguments using the session.
        /// </summary>
        internal static PreparedStatement PrepareFormat(this ISession session, string cqlFormatString, params object[] args)
        {
            return session.Prepare(string.Format(cqlFormatString, args));
        }
    }
}