﻿using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Shops
{
    public class MShopItemSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType Type { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        [Range(0, short.MaxValue)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        [Range(0, long.MaxValue)]
        public long Price { get; set; }
    }
}