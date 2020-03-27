﻿using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Families
{
    [PacketHeader("gidx")]
    public class GidxPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long FamilyId { get; set; }

        [PacketIndex(3)]
        public string? FamilyName { get; set; }

        [PacketIndex(4)]
        public string? FamilyCustomRank { get; set; }

        [PacketIndex(5)]
        public byte FamilyLevel { get; set; }

        [PacketIndex(6, SpecialSeparator = "|")]
        public List<bool>? FamilyIcons { get; set; }
    }
}