using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorsci : MonoBehaviour
{
    public Color[] color;
    SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        spriteRenderer.color = color[0];
    }
}