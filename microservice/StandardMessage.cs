using System;
using System.Collections.Generic;

namespace DustCatMicroService
{
    /// <summary>
    /// Standard message class
    /// basic implementation of IMessage
    /// </summary>
    public class StandardMessage : IMessage
    {
        public string header { get; set; }
        public string content { get; set; }
        public string TargetName { get; set; }
        public short TargetId { get; set; }
        public Dictionary<string, object> objects { get; set; }

        public StandardMessage(string header, string content, string targetName, short targetId)
        {
            this.header = header;
            this.content = content;
            this.TargetName = targetName;
            this.TargetId = targetId;
            this.objects = null;
        }

        public StandardMessage(string header, string content, string targetName, short targetId, Dictionary<string, object> objects)
        {
            this.header = header;
            this.content = content;
            this.TargetName = targetName;
            this.TargetId = targetId;
            this.objects = objects;
        }


    }
}

