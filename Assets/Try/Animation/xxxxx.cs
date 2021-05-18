using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xxxxx : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        anim.SetBool("xxx", true);
    }

    private void OnMouseUp()
    {
        anim.SetBool("xxx", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
