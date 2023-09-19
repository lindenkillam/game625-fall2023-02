using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timer = 0f;
    //private bool holdTimer = false; 
    public float timerDuration = 60f;
    public int grade = 0;
    public float moveSpeed = 10f;
    public float rotateSpeed = 120f;
    public PlayerController player;
    //public EnemyController greenZombie;
    //public EnemyController grayZombie;
    //public EnemyController ghoul;
    public UI ui;
    public GameObject failPaper;
    public GameObject passPaper;
    public GameObject paper;
    Vector3 vector;
    public GameObject mainMusicObject;
    public AudioSource mainMusic;

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
        int i;

        for(i = 0; i < 2000; ++i)
        {
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(0.01f, 1f), Random.Range(-100f,100f));
            paper = Instantiate(passPaper, vector, Quaternion.identity);

        }

        for(i = 0; i < 500; ++i)
        {
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(0.01f, 1f), Random.Range(-100f,100f));
            paper = Instantiate(failPaper, vector, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }
}
