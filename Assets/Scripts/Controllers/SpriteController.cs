using System.Collections.Generic;
using UnityEngine;

public class SpriteController: MonoBehaviour
{
    [SerializeField] protected List<Sprite> NormalSprites = new List<Sprite>();
    [SerializeField] protected SpriteRenderer Renderer;
    [SerializeField] protected int index = 0;

    public int Index
    {
        get => index;
        set
        {
            int tempIndex = Mathf.Clamp(value, 0, NormalSprites.Count - 1);
            if (tempIndex != index)
            {
                index = tempIndex;
                Renderer.sprite = NormalSprites[index];
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Renderer == null) Renderer = gameObject.GetComponent<SpriteRenderer>();
        if (Renderer == null) Renderer = gameObject.AddComponent<SpriteRenderer>();
        Index = index;
        Renderer.sprite = NormalSprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
