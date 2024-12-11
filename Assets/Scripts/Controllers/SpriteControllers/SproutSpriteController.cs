using System.Collections.Generic;
using UnityEngine;
using Data;
using Unity.VisualScripting;

public class SproutSpriteController : SpriteController
{

    public void SetSproutStatus(SproutStatus sproutStatus)
    {
        Status = (int)sproutStatus;
    }

    protected override void Start()
    {
        base.Start();
    }
}
