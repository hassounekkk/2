using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloring : MonoBehaviour
{
    
    public Color curColer;
    public ColorsController colorsController;
    public AudioSource draw;
    // Start is called before the first frame update
    void Start()
    {
        colorsController = GameObject.FindObjectOfType<ColorsController>();
    }

    // Update is called once per frame
    void Update()
    {
        curColer = colorsController.curColer;

    }

    private void OnMouseDown()
    {
        draw.Play();
        SpriteRenderer sp = this.GetComponent<SpriteRenderer>();
        sp.color = curColer;
    }
    

}
