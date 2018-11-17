#region copyrigth
//-----------------------------------------------------------------------
// <copyright file="CassandraPluginConfig.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------
#endregion

using Akka.Actor;
using Akka.Configuration;

namespace Akka.Persistence.Cassandra
{
    public sealed class StorePathPasswordConfig
    {
        public string Path { get; }
        public string Password { get; }

        public StorePathPasswordConfig(string path, string password)
        {
            Path = path;
            Password = password;
        }
    }

    public class CassandraPluginConfig
    {
        private readonly ActorSystem system;
        private readonly Config config;

        public CassandraPluginConfig(ActorSystem system, Config config)
        {
            this.system = system;
            this.config = config;
        }


    }
}