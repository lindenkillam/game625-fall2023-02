using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public GameManager gm;
    //public TextMeshProUGUI gradeDisplay; //Can't get these to work right now for some reason
    //public TextMeshProUGUI winDisplay;
    [SerializeField] Text gradeDisplay;
    [SerializeField] Text winDisplay;
    [SerializeField] Text timerDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerDisplay.text = gm.timer.ToString ("0");
        gradeDisplay.text = "Grade: " + gm.score.ToString ("0");

        if(gm.timer <= 0)
        {
            if(gm.score < 70)
            {
                winDisplay.text = "You failed your midterm!";
            }
            else if(gm.score < 80)
            {
                winDisplay.text = "You got a C on your midterm.";
            }
            else if(gm.score < 90)
            {
                winDisplay.text = "You got a B on your midterm.";
            }
            else
            {
                winDisplay.text = "You got an A on your midterm!";
            }
        }
    }
}
