using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public GameManager gm;
    //public TextMeshProUGUI gradeDisplay; //Didn't get this format to work previously
    public TMP_Text scoreDisplay;
    public TMP_Text winDisplay;
    public TMP_Text timerDisplay;
    public TMP_Text coalDisplay;
    public TMP_Text cherryDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerDisplay.text = gm.timer.ToString ("0");
        scoreDisplay.text = "Score: " + gm.score.ToString ("0");
        coalDisplay.text = "Coal: " + gm.coals.ToString("0");
        cherryDisplay.text = "Cherries: " + gm.cherries.ToString("0");

        if (gm.timer <= 0)
        {
            if(gm.score < gm.numCollectibles/10)
            {
                winDisplay.text = "Not exactly fast.";
            }
            else if(gm.score < gm.numCollectibles/5)
            {
                winDisplay.text = "Meh.";
            }
            else if(gm.score < gm.numCollectibles/4)
            {
                winDisplay.text = "You did okay.";
            }
            else
            {
                winDisplay.text = "Not bad!";
            }
        }
    }
}
