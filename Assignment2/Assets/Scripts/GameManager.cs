using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timer = 0f;
    //private bool holdTimer = false; 
    public float timerDuration = 60f;
    public int score = 0;
    public float moveSpeed = 10f;
    public float rotateSpeed = 120f;
    public PlayerController player;
    //public EnemyController greenZombie;
    //public EnemyController grayZombie;
    //public EnemyController ghoul;
    public UI ui;
    public EventObserver eo;
    public GameObject coal;
    public GameObject cherry;
    public GameObject sphere;
    Vector3 vector;
    public GameObject mainMusicObject;
    public AudioSource mainMusic;
    public TMP_Text coalText;
    public TMP_Text cherryText;

    public abstract class Collectible
    {
        protected Color color;
        protected short scoreValue;
        //public abstract void healthEffect();
        public short getScoreValue()
        {
            return scoreValue;
        }
    }

    public class Coal : Collectible
    {
        public Coal()
        {
            this.color = new Color(0, 0, 0);
            this.scoreValue = 1;
        }
    }

    public class Cherry : Collectible
    {
        public Cherry()
        {
            this.color = new Color(255, 0, 0);
            this.scoreValue = 3;
        }
    }

    public abstract class Enemy
    {
        protected short strength;
        protected short speed;
        public abstract void attack();
    }

    public class Lurker : Enemy
    {
        public Lurker()
        {
            this.strength = 5;
            this.speed = 3;
        }
        public override void attack()
        {
            throw new System.NotImplementedException();
        }
    }

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

        for(i = 0; i < 2000; ++i)
        {
            rando = Random.Range(1, 3);
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(0.5f, 1f), Random.Range(-100f,100f));

            if (rando == 2)
                sphere = Instantiate(coal, vector, Quaternion.identity);
            else
                sphere = Instantiate(cherry, vector, Quaternion.identity);

        }

        /*
        for(i = 0; i < 500; ++i)
        {
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(0.01f, 1f), Random.Range(-100f,100f));
            paper = Instantiate(failPaper, vector, Quaternion.identity);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
            timer -= Time.deltaTime;
    }
}
