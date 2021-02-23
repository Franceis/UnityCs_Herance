﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterOne : Player
{
    public override void Start()
    {
        base.Start();

        base.maxLife = 150;
        base.maxSpBar = 100;
        base.damage = 8.5f;
        base.defense = 1.2f;
    }
}
