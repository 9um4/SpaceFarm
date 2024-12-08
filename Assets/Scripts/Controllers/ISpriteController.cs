using UnityEngine;

public interface ISpriteController
{
    public Sprite GetCurrentSprite(int index, SproutStatus? sproutStatus = null);
}
