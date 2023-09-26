using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    protected Color color;
    protected short scoreValue;
    Vector3 location = new Vector3(Random.Range(-100f, 100f), Random.Range(0.5f, 1f), Random.Range(-100f,100f));
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