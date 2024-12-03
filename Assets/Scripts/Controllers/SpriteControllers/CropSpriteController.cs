using System.Collections.Generic;
using UnityEngine;

public class SproutSpriteController : SpriteController
{
    [SerializeField] protected SproutStatus sproutStatus;
    [SerializeField] protected List<Sprite> NormalWetSprites = new List<Sprite>();
    [SerializeField] protected List<Sprite> WinterSprites = new List<Sprite>();
    [SerializeField] protected List<Sprite> WinterWetSprites = new List<Sprite>();

    public SproutStatus SproutStatus
    {
        get => sproutStatus;
        set
        {
            if (sproutStatus != value)
            {
                sproutStatus = value;
                switch (sproutStatus){
                    case SproutStatus.NORMAL:
                        Renderer.sprite = NormalSprites[index];
                        break;
                    case SproutStatus.NORMAL_WET:
                        Renderer.sprite = NormalWetSprites[index];
                        break;
                    case SproutStatus.WINTER:
                        Renderer.sprite = WinterSprites[index];
                        break;
                    case SproutStatus.WINTER_WET:
                        Renderer.sprite = WinterWetSprites[index];
                        break;
                }
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
