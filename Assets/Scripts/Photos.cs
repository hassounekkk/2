using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photos : MonoBehaviour
{

    public GameObject[] photo;
    public GameObject all;
    public GameObject fin;
    public AudioSource winningSound;
    
    public ObjectController[] objectController;
    int indice = 0;
    // Start is called before the first frame update
    public void Start()
    {
        for(int i = 0; i < objectController.Length; i++)
        {
            objectController[i].rondomObjects();
        }

        indice = 0;
        fin.SetActive(false);
        all.SetActive(true);

        for(int i =0; i<photo.Length; i++)
        {
            photo[i].SetActive(false);
        }

        photo[indice].SetActive(true);
    }

    public void change()
    {
        /*   if (indice != photo.Length)
           {
               photo[indice].SetActive(false);
           }
           if (indice < photo.Length-1)
           {
               indice++;
               photo[indice].SetActive(true);
           }
           if (indice == photo.Length )
           {
               all.SetActive(false);
               fin.SetActive(true);
           }
           else
           {
               all.SetActive(true);
               fin.SetActive(false);
           }*/
        photo[indice].SetActive(false);
        if (indice <= photo.Length)
        {
            indice++;
        }
        if (indice < photo.Length )
        {
            
            photo[indice].SetActive(true);
           

        }
        if (indice == photo.Length)
        {
            all.SetActive(false);
            fin.SetActive(true);
            winningSound.Play();
        }
        else
        {
            all.SetActive(true);
            fin.SetActive(false);
        }

    }

    void Update()
    {
        
    }
}
