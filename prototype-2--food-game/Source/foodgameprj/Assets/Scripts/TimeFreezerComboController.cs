﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFreezerComboController : ComboInstanceController
{
    // when player eats the combo item
    public override void OnConsume()
    {
        //Debug.Log("TIME FREEZER ON CONSUME");
        GameObject.Find("Player").GetComponent<PlayerController>().timeRemaining += 2;
    }
}
