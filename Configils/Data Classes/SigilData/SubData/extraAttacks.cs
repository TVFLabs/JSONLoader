﻿using System.Collections.Generic;

namespace JLPlugin.Data
{
    [System.Serializable]
    public class extraAttacks
    {
        public slotData attackingSlot;
        public List<slotData> slotsToAttack;
    }
}