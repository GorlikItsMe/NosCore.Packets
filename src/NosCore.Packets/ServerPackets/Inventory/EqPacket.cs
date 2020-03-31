﻿using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Visibility;

namespace NosCore.Packets.ServerPackets.Inventory
{
    [PacketHeader("eq")]
    public class EqPacket : PacketBase
    {
        [PacketIndex(0)]
        public long VisualId { get; set; }

        [PacketIndex(1)]
        public byte Visibility { get; set; }

        [PacketIndex(2)]
        public GenderType Gender { get; set; }

        [PacketIndex(3)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(4)]
        public HairColorType Haircolor { get; set; }

        [PacketIndex(5)]
        public CharacterClassType ClassType { get; set; }

        [PacketIndex(6)]
        public InEquipmentSubPacket? EqSubPacket { get; set; }

        [PacketIndex(7, SpecialSeparator = "")]
        public UpgradeRareSubPacket? WeaponUpgradeRarePacket { get; set; }

        [PacketIndex(8, SpecialSeparator = "")]
        public UpgradeRareSubPacket? ArmorUpgradeRarePacket { get; set; }
    }
}