using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    protected Color color;
    protected short scoreValue;
    protected string objectTag;
    public Vector3 location = new Vector3(Random.Range(-100f, 100f), Random.Range(0.5f, 2.5f), Random.Range(-100f,100f));
    //public abstract void healthEffect();
    public short getScoreValue()
    {
        return scoreValue;
    }
    /*
    public Vector3 getLocation()
    {
        return location;
    }
    */
    public Color getColor()
    {
        return color;
    }
    public string getObjectTag()
    {
        return objectTag;
    }
}

public class Coal : Collectible
{
    public Coal()
    {
        this.color = new Color(0, 0, 0);
        this.objectTag = "Coal";
        //this.scoreValue = 1;
    }
}

public class Cherry : Collectible
{
    public Cherry()
    {
        this.color = new Color(255, 0, 0);
        this.objectTag = "Cherry";
        //this.scoreValue = 3;
    }
}

/*
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
*/