using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScean : MonoBehaviour
{
    public int  indice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changeScene(int n)
    {
        SceneManager.LoadScene(n, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
