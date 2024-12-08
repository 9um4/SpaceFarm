using System.Collections.Generic;
using UnityEngine;
using Collections;
using Unity.Collections;
using System.Collections;

public class SpriteController: MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] protected SerializableDictionary<int, Sprite[]> SpriteMap = new SerializableDictionary<int, Sprite[]>();
    [SerializeField] protected int index;

    [SerializeField] protected SpriteRenderer Renderer;

    public int Index
    {
        get
        {
            return index;
        }

        set
        {
            int tempIndex = Mathf.Clamp(value, 0, 10);
            if (tempIndex != index)
            {
                index = tempIndex;
                Renderer.sprite = null;
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Renderer == null) Renderer = gameObject.GetComponent<SpriteRenderer>();
        if (Renderer == null) Renderer = gameObject.AddComponent<SpriteRenderer>();
        Index = index;
        Renderer.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
