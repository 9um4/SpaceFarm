using System.Collections.Generic;
using UnityEngine;
using Data;

public class SproutSpriteController : SpriteController
{

    public void SetSproutStatus(SproutStatus sproutStatus)
    {
        Status = (int)sproutStatus;
    }
}
