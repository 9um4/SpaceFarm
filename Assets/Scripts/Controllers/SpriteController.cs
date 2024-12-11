using System.Collections.Generic;
using UnityEngine;
using System;
using Data;
using Unity.VisualScripting;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController: MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] protected List<SpritesWrapper> SpriteList = new();
    [SerializeField] protected int index;
    [SerializeField] protected int status;

    [SerializeField] protected SpriteRenderer SpriteRenderer;

    public int Index
    {
        get
        {
            return index;
        }

        set
        {
            if (SpriteList[Status].Count == 0)
            {
                throw new InvalidOperationException("SpriteList is empty and cannot be accessed.");
            }
            if (value >= SpriteList[Status].Count)
            {
                throw new ArgumentOutOfRangeException($"Index must be between 0 and {SpriteList[Status].Count - 1}");
            }

            index = value;
        }
    }

    public virtual int Status
    {
        get
        {
            return status;
        }

        set
        {
            if (SpriteList.Count == 0)
            {
                throw new InvalidOperationException("SpriteList is empty and cannot be accessed.");
            }
            if (value < 0 || value >= SpriteList.Count)
            {
                throw new ArgumentOutOfRangeException($"Status must be between 0 and {SpriteList.Count - 1}");
            }

            status = value;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        if (SpriteRenderer.IsUnityNull()) SpriteRenderer = GetComponent<SpriteRenderer>();

        if (SpriteList.Count == 0)
        {
            throw new Exception("SpriteList가 Initialize되지 않았습니다!");
        }

        foreach(var sprites in SpriteList)
        {
            if (sprites.Count == 0)
            {
                throw new Exception("Sprites가 Initialized되지 않았습니다!");
            }
        }

        Index = 0;
        Status = 0;
        SpriteRenderer.sprite = SpriteList[Status].Get(index);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
