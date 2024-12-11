using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;

namespace Data
{
    [System.Serializable]
    public class SpritesWrapper
    {
        [SerializeField] protected List<Sprite> Sprites;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public virtual Sprite Get(int index)
        {
            if (index < 0 || index >= Sprites.Count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range. Valid range is 0 to {Sprites.Count - 1}.");
            }

            return Sprites[index];
        }

        public virtual void Set(int index, Sprite sprite)
        {
            if (index < 0 || index >= Sprites.Count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range. Valid range is 0 to {Sprites.Count - 1}.");
            }

            Sprites[index] = sprite;
        }

        public virtual void Remove(int index)
        {
            Sprites.RemoveAt(index);
        }

        public bool IsEmpty
        {
            get { return Sprites.Count == 0; }
        }

        public int Count
        {
            get { return Sprites.Count; }
        }
    }
}