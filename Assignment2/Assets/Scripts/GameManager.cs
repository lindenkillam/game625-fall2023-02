using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    Vector3 vector;
    const int numCollectibles = 100;
    public float timer = 0f;
    //private bool holdTimer = false; 
    public float timerDuration = 120f;
    public int score = 0;
    public float moveSpeed = 10f;
    public float rotateSpeed = 120f;

    public PlayerController player;
    //public EnemyController ghoul;
    public UI ui;
    public EventObserver eo;
    public GameObject coal;
    public GameObject cherry;
    public GameObject sphere;
    public GameObject newCollectible;
    public Collectible[] collectibles = new Collectible[numCollectibles];
    Renderer renderer;
    Collider m_ObjectCollider;

    public GameObject mainMusicObject;
    public AudioSource mainMusic;

    public TMP_Text coalText;
    public TMP_Text cherryText;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerDuration;
        int i, rando;

        /*
        MaterialPropertyBlock props = new MaterialPropertyBlock();
        props.AddColor("_Color", Color.red);
        GetComponent<Renderer>().SetPropertyBlock(props);
        */

        for(i = 0; i < numCollectibles; ++i)
        {
            rando = Random.Range(1, 3);


            if (rando == 2)
            {
                collectibles[i] = new Cherry();
                Debug.Log("Cherry created.");
            }
            else
            {
                collectibles[i] = new Coal();
                Debug.Log("Coal created.");
            }
            sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            m_ObjectCollider = sphere.GetComponent<Collider>();
            m_ObjectCollider.isTrigger = true;
            renderer = sphere.GetComponent<Renderer>();
            renderer.material.SetColor("_Color", collectibles[i].getColor());
            sphere.tag = collectibles[i].getObjectTag();
            //Debug.Log(sphere.tag);
            newCollectible = Instantiate(sphere, collectibles[i].location, Quaternion.identity);
            newCollectible.AddComponent<CollectionNotifier>();


            /*
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(0.5f, 1f), Random.Range(-100f,100f));

            if (rando == 2)
                sphere = Instantiate(coal, vector, Quaternion.identity);
            else
                sphere = Instantiate(cherry, vector, Quaternion.identity);
            */

            /*
            UnityEngine.MonoBehaviour:.ctor ()
            Collectible:.ctor () (at Assets/Scripts/Collectible.cs:7)
            Coal:.ctor () (at Assets/Scripts/Collectible.cs:25)
            GameManager:Start () (at Assets/Scripts/GameManager.cs:57)
            */
        }
}

// Update is called once per frame
    void Update()
    {
        if(timer > 0)
        timer -= Time.deltaTime;
    }
}
