#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="PreparedStatementEnvelope.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Cassandra;

namespace Akka.Persistence.Cassandra
{
    public sealed class PreparedStatementEnvelope
    {
        public ISession Session { get; }
        public PreparedStatement PreparedStatement { get; }

        public PreparedStatementEnvelope(ISession session, PreparedStatement preparedStatement)
        {
            Session = session;
            PreparedStatement = preparedStatement;
        }
    }
}