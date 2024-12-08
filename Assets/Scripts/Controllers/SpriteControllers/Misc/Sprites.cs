using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    [System.Serializable]
    public class Sprites
    {
        [SerializeField] protected Sprite[] NormalSprites;

        public virtual int GetSpritesCount(SproutStatus? sproutStatus = null)
        {
            return NormalSprites.Length;
        }

        public virtual Sprite GetCurrentSprite(int index, SproutStatus? sproutStatus = null)
        {
            if (NormalSprites.Length < index)
            {
                return NormalSprites[index];
            }
            return null;
        }
    }

    [System.Serializable]
    public class SproutSprites: Sprites
    {
        [SerializeField] protected Sprite[] NormalWetSprites;
        [SerializeField] protected Sprite[] WinterSprites;
        [SerializeField] protected Sprite[] WinterWetSprites;

        public override Sprite GetCurrentSprite(int index, SproutStatus? sproutStatus = null)
        {
            switch (sproutStatus)
            {
                case SproutStatus.NORMAL:
                    return NormalSprites[index];
                case SproutStatus.NORMAL_WET:
                    return NormalWetSprites[index];
                case SproutStatus.WINTER:
                    return WinterSprites[index];
                case SproutStatus.WINTER_WET:
                    return WinterWetSprites[index];
                default:
                    return null;
            }
        }

        public override int GetSpritesCount(SproutStatus? sproutStatus = null)
        {
            switch (sproutStatus)
            {
                case SproutStatus.NORMAL:
                    return NormalSprites.Length;
                case SproutStatus.NORMAL_WET:
                    return NormalWetSprites.Length;
                case SproutStatus.WINTER:
                    return WinterSprites.Length;
                case SproutStatus.WINTER_WET:
                    return WinterWetSprites.Length;
                default:
                    return -1;
            }
        }

    }
}