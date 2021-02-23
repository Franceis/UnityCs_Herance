using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterTwo : Player
{
    public override void Start()
    {
        base.Start();

        base.maxLife = 120;
        base.maxSpBar = 120;
        base.damage = 10.3f;
        base.defense = 0.8f;
    }
}
