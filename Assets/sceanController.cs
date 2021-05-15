using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    public GameObject[] Object;
    public GameObject[] OnPut;
    public Transform[] positions;
    public int Indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<Object.Length ; i++)
        {
            Object[i].SetActive(false);
        }
        Object[Indice].SetActive(true);
        int t = Random.Range(0, 3);
        Instantiate(OnPut[Indice] , positions[t].position, Quaternion.identity) ;
        int k = Random.Range(0,OnPut.Length);
        while (k==Indice)
        {
            k = Random.Range(0, OnPut.Length);
        }
        int j = Random.Range(0, OnPut.Length);
        while (j == Indice ||  j==k)
        {
            j = Random.Range(0, OnPut.Length);
        }
        if (t == 0)
        {
            Instantiate(OnPut[k], positions[1].position, Quaternion.identity);
            Instantiate(OnPut[j], positions[2].position, Quaternion.identity);

        }
        else if (t==1)
        {
            Instantiate(OnPut[k], positions[2].position, Quaternion.identity);
            Instantiate(OnPut[j], positions[0].position, Quaternion.identity);
        }
        else
        {
            Instantiate(OnPut[k], positions[0].position, Quaternion.identity);
            Instantiate(OnPut[j], positions[1].position, Quaternion.identity);
        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
