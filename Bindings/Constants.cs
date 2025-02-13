﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bindings
{
    // Bindings are shared between Client and Server projects
    internal class Constants
    {
        // Server
        public const int MAX_PLAYERS = 50; // Max Players
        public const int MAX_ROOMS = 50; // Max Rooms
        public const int MAX_ITEMS = 255; // Max Items
        public const int MAX_SHOPS = 255; // Max Shops
        public const int MAX_SPELLS = 255; // Max Spells
        public const int MAX_NPCS = 255; // Max NPCs

        // Account
        public const int MAX_CHARS = 5; // Max Characters
    }
}
