﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using ColourPicker;

namespace RenameEverything
{

    public class Command_RecolourLabel : Command_Renamable
    {

        public override void ProcessInput(Event ev)
        {
            base.ProcessInput(ev);
            Find.WindowStack.Add(new Dialog_ColourPicker(renamables[0].labelColour, c => renamables.ForEach(r => r.labelColour = c)));
        }

    }

}
