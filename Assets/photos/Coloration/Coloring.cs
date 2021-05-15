using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloring : MonoBehaviour
{
    public Color[] colorList;
    public Color curColer;
    public int colorCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curColer = colorList[colorCount];
        var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, -Vector2.up);
        if (Input.GetButton("Fire1"))
        {
            if (hit.collider != null)
            {
                SpriteRenderer sp = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                sp.color = curColer;
            }
        }
        

    }
    public void paint(int colorcode)
    {
        colorCount = colorcode;
    }

}
