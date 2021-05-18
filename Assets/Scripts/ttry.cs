using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttry : MonoBehaviour
{
    public GameObject gameObject;
    public Color color;
    public SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        gameObject = Instantiate(gameObject, new Vector2(0, 0), Quaternion.identity);
        sp = gameObject.transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>();

        color = sp.color;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
