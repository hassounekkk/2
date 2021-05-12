using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject[] photos;
    public MoveUpAndDown[] M;
    Vector2[] place_Initial = new Vector2[6];
    private Vector2[] winingPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        updatePosition();
        winingPosition = place_Initial;
        rondomObjects();
    }

    public void rondomObjects()
    {
        updatePosition();
        int t = Random.Range(0, 5);
        int k = Random.Range(0, 5);
        while (t == k)
        {
            k = Random.Range(0, 5);
        }
        photos[t].transform.position = place_Initial[k];
        photos[k].transform.position = place_Initial[t];
        GameObject T;
        T = photos[t];
        photos[t] = photos[k];
        photos[k] = T;
        updatePosition();
        for (int j = 0; j < M.Length; j++)
        {
            M[j].UpdatePosition();
        }
    }

    public void updatePosition()
    {
        for (int i = 0; i < photos.Length; i++)
        {
            place_Initial[i] = photos[i].transform.position;
        }
    }

    public void change(int i, bool A)
    {
        if (A)
        {

            photos[i + 1].transform.position = place_Initial[i];
            photos[i].transform.position = place_Initial[i + 1];
        }
        else
        {
            photos[i - 1].transform.position = place_Initial[i];
            photos[i].transform.position = place_Initial[i - 1];

        }
        changeGameO(i, A);
        updatePosition();
        for(int j =0; j<M.Length; j++)
        {
            M[j].UpdatePosition();
        }
    }
    void changeGameO(int i, bool A)
    {
        GameObject T;
        if (A)
        {
            T = photos[i + 1];
            photos[i + 1] = photos[i];
            photos[i] = T;
        }
        else
        {
            T = photos[i - 1];
            photos[i - 1] = photos[i];
            photos[i] = T;

        }
    }

    public Vector2[] WiningPosition { get { return winingPosition; } }

}
