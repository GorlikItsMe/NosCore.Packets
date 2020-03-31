﻿using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Battle
{
    [PacketHeader("u_s")]
    public class UseSkillPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CastId { get; set; }

        [PacketIndex(1)]
        public VisualType TargetVisualType { get; set; }

        [PacketIndex(2)]
        public long TargetId { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? MapX { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? MapY { get; set; }
    }
}