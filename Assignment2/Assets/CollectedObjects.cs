using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedObjects : MonoBehaviour
{
    public abstract class Collectible
    {
        protected Color color;
        protected short scoreValue;
        public abstract void healthEffect();
    }

    public class Coal : Collectible
    {
        public Coal()
        {
            this.color = new Color(0, 0, 0);
            this.scoreValue = 1;
        }
        public override void healthEffect()
        {
            throw new System.NotImplementedException();
        }
        public short getScoreValue()
        {
            return scoreValue;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
