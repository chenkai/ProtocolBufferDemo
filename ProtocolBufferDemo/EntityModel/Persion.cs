﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProtoBuf;
using ProtoBuf.ServiceModel;

namespace ProtocolBufferDemo.EntityModel
{
    [ProtoContract]
    public class Persion
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public Address Address { get; set; }
    }

    [ProtoContract]
    public class Address
    {
        [ProtoMember(1)]
        public string Line1 { get; set; }
        [ProtoMember(2)]
        public string Line2 { get; set; }
    }
}
