using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGame : MonoBehaviour
{
    public GameObject[] Object;
    public GameObject[] OnPut;
    public Transform[] positions;
    public int Indice =0 ;
    public int t;
    public int k, j;
    // Start is called before the first frame update
    void Start()
    {
        reIanisialise();
    }

    void reIanisialise()
    {
        for (int i = 0; i < Object.Length; i++)
        {
            Object[i].SetActive(false);
        }
        Object[Indice].SetActive(true);
        t = Random.Range(0, 3);
        OnPut[Indice] =  Instantiate(OnPut[Indice], positions[t].position, Quaternion.identity);
        
         k = Random.Range(0, OnPut.Length);
        while (k == Indice)
        {
            k = Random.Range(0, OnPut.Length);
        }
         j = Random.Range(0, OnPut.Length);
        while (j == Indice || j == k)
        {
            j = Random.Range(0, OnPut.Length);
        }
        if (t == 0)
        {
            OnPut[k] = Instantiate(OnPut[k], positions[1].position, Quaternion.identity);
            OnPut[j] = Instantiate(OnPut[j], positions[2].position, Quaternion.identity);

        }
        else if (t == 1)
        {
            OnPut[k] =Instantiate(OnPut[k], positions[2].position, Quaternion.identity);
            OnPut[j] = Instantiate(OnPut[j], positions[0].position, Quaternion.identity);
        }
        else
        {
            OnPut[k] = Instantiate(OnPut[k], positions[0].position, Quaternion.identity);
            OnPut[j] = Instantiate(OnPut[j], positions[1].position, Quaternion.identity);
        }
    }

    public void LoadNextOne()
    {

        
        Destroy(OnPut[Indice]);
        Destroy(OnPut[k]);
        Destroy(OnPut[j]);
        
        Indice++;
        reIanisialise();
        for (int i = 0; i < Object.Length; i++)
        {
            Object[i].SetActive(false );
        }
        Object[Indice].SetActive(true);
    }

    public Vector3 Goal()
    {
        return positions[t].transform.position;
    }
    
    // Update is called once per frame
   
}
