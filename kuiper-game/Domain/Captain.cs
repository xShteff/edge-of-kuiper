using System;
using Kuiper.Systems;
using Newtonsoft.Json;

namespace Kuiper.Domain
{
    public class Captain
    {
        [JsonConstructor]
        public Captain(string name)
        {
            Name = name;
        }

        public Captain(string name, DateTime startTime)
        {
            Name = name;
            StartTime = startTime;
        }

        public string Name { get; }
        public DateTime StartTime { get; set; }
        public DateTime LastLoggedIn { get; set;}

        public Ship Ship { get; set;}
    }
}