using System.Collections.Generic;
using UnityEngine;
using Data;

public class SproutSpriteController : SpriteController
{
    [SerializeField] protected List<Sprites> spr;

    [SerializeField] protected SproutStatus sproutStatus;
    

    public SproutStatus SproutStatus
    {
        get => sproutStatus;
        set
        {
            sproutStatus = value;
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
