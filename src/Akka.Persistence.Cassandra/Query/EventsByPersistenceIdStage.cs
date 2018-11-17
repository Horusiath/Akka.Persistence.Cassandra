#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="EventsByPersistenceIdStage.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Threading.Tasks;
using Akka.Streams;
using Akka.Streams.Stage;

namespace Akka.Persistence.Cassandra.Query
{
    public class EventsByPersistenceIdStage<T> : GraphStageWithMaterializedValue<SourceShape<T>, IEventsByPersistenceIdController>
    {
        public override ILogicAndMaterializedValue<IEventsByPersistenceIdController> CreateLogicAndMaterializedValue(Attributes inheritedAttributes)
        {
            throw new System.NotImplementedException();
        }

        public override SourceShape<T> Shape { get; }
    }

    public interface IEventsByPersistenceIdController : IDisposable
    {
        void Poll(long knownSequenceNr);
        void FastForward(long nextSequenceNr);
        Task CompletionTask { get; }
    }
}