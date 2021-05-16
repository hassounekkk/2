using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsController : MonoBehaviour
{
    public Color curColer;
    public GameObject chosenColor;
    SpriteRenderer SpriteRenderers;
    public Color[] colors;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderers = chosenColor.GetComponent<SpriteRenderer>();
        SpriteRenderers.color = curColer;
    }

     public void ChooseColer(int nbr)
    {
        curColer = colors[nbr];
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderers.color = curColer;
    }
}
