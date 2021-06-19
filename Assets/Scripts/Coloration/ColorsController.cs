using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorsController : GGame
{

    public List<GameObject> photosWithoutCl = new List<GameObject>();
    public List<GameObject> photoWithColers = new List<GameObject>();

    List<SpriteRenderer> CurentColer = new List<SpriteRenderer>();
    List<SpriteRenderer> correstedColer = new List<SpriteRenderer>();

    float Timer = 1f;

    Score score;
    int curIndice = 0;
    public Color curColer;
    public GameObject chosenColor;
    SpriteRenderer SpriteRenderers;
    public Color[] colors;
    public Transform positiooon;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e

    public GameObject[] fin;
    public GameObject fin2;
    public GameObject winning;
    public GameObject pauseScean;
    public AudioSource[] colorsVoice;
<<<<<<< HEAD


=======
<<<<<<< HEAD

=======
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e

=======
>>>>>>> 98836b612aa80a02c223aac82f5f7bc2ecd264b5

    public GameObject[] fin;
    public GameObject[] fin2;
    public GameObject winning;
    public AudioSource winnig;
    public AudioSource draw;
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e

    /// <summary>

    public Color tryColor1;
    
    //

    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
        score.initialiserStars(photosWithoutCl.Count);

        foreach(GameObject gameObject in photosWithoutCl)
        {
            gameObject.SetActive(false);
        }
        photosWithoutCl[0].SetActive(true);

        photoWithColers[0] = Instantiate(photoWithColers[0], new Vector2(photosWithoutCl[curIndice].transform.position.x - 7.5f, photosWithoutCl[curIndice].transform.position.y), Quaternion.identity);
        SpriteRenderers = chosenColor.GetComponent<SpriteRenderer>();
        SpriteRenderers.color = curColer;

        

        for(int i=0; i<photoWithColers[0].transform.childCount; i++)
        {
            correstedColer.Add(photoWithColers[0].transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>());
        }
        for (int i = 0; i < photosWithoutCl[0].transform.childCount; i++)
        {
            CurentColer.Add(photosWithoutCl[0].transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>());
        }
    }
    void updateList()
    {
        List<SpriteRenderer> Corr = new List<SpriteRenderer>();
        for (int i = 0; i < photoWithColers[curIndice].transform.childCount; i++)
        {
            Corr.Add(photoWithColers[curIndice].transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>());
        }
        correstedColer = Corr;

        List<SpriteRenderer> Cur = new List<SpriteRenderer>();
        for (int i = 0; i < photosWithoutCl[curIndice].transform.childCount; i++)
        {
            Cur.Add(photosWithoutCl[curIndice].transform.GetChild(i).gameObject.GetComponent<SpriteRenderer>());
        }
        CurentColer = Cur;
    }

    bool  check()
    {
        bool resultat = true;
        for (int i = 0; i < CurentColer.Count; i++)
        {
            if (CurentColer[i].color != correstedColer[i].color)
            {
                resultat = false;
            }
        }
        return resultat;
    }


    public void nextPhoto()
    {
        photosWithoutCl[curIndice].SetActive(false);
        photoWithColers[curIndice].SetActive(false);
<<<<<<< HEAD
        score.AddStar();
=======
<<<<<<< HEAD
        score.AddStar();
=======
<<<<<<< HEAD
        score.AddStar();
=======
>>>>>>> 98836b612aa80a02c223aac82f5f7bc2ecd264b5
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e
        if (curIndice < photosWithoutCl.Count-1)
        {
            curIndice++;
            photoWithColers[curIndice] = Instantiate(photoWithColers[curIndice], new Vector2(photosWithoutCl[curIndice].transform.position.x - 7.5f, photosWithoutCl[curIndice].transform.position.y), Quaternion.identity); ;
            photosWithoutCl[curIndice].SetActive(true);
            updateList();
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e
            
        }
        else if(!finish)
        {
           
                fin2.SetActive(false);

            finish_game();
            finish = true;
            add_Score_Db = FindObjectOfType<Add_Score_db>();
            if (PlayerPrefs.GetInt("id_user") != 0)
                add_Score_Db.UpdateData(PlayerPrefs.GetInt("id_user"), 16, 0, timer_to_finish);
            
            
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
        }
        else
        {
            for (int i = 0; i < fin.Length; i++)
            {
                fin2[i].SetActive(false);
                winning.SetActive(true);

            }
            winnig.Play();
>>>>>>> 98836b612aa80a02c223aac82f5f7bc2ecd264b5
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e
        }
    }
     public void ChooseColer(int nbr)
    {
        curColer = colors[nbr];
        colorsVoice[nbr].Play();
    }

    public void changeScene(int n)
    {
        SceneManager.LoadScene(n, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        if(!finish && !pause) timer_to_finish += Time.deltaTime;
        SpriteRenderers.color = curColer;

        updateList();

        

        if (check())
        {
<<<<<<< HEAD
            
=======
<<<<<<< HEAD
            
=======
<<<<<<< HEAD
            
=======
            draw.Play();
>>>>>>> 98836b612aa80a02c223aac82f5f7bc2ecd264b5
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e
            for(int i=0; i < fin.Length; i++)
            {
                fin[i].SetActive(true);
            }
<<<<<<< HEAD
            Timer -= Time.deltaTime;
=======
<<<<<<< HEAD
            Timer -= Time.deltaTime;
=======
<<<<<<< HEAD
            Timer -= Time.deltaTime;
=======
>>>>>>> 98836b612aa80a02c223aac82f5f7bc2ecd264b5
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e
        }
        else
        {
            for (int i = 0; i < fin.Length; i++)
            {
                fin[i].SetActive(false);
            }
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e
        }

        if (Timer <= 0 && !finish)
        {
            nextPhoto();
            Timer = 1;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
>>>>>>> 98836b612aa80a02c223aac82f5f7bc2ecd264b5
>>>>>>> cef7472e5250545940b1b97e00a1b679f2173c4e
>>>>>>> 5c73e8350f3eb868ac30216fb778ab9d9c7f316e
        }
        
    }


}