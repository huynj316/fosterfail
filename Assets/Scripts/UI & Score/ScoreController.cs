using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Transform HumanScoreTextW;
    public Transform HumanScoreTextB;

    public Transform DoggoScoreTextW;
    public Transform DoggoScoreTextB;

    public int HumanScore = 0;
    public int DoggoScore = 0;

    public DayTimer TimeController;

    public Transform WinStateText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HumanScoreTextW.GetComponent<Text>().text = HumanScore + " Points";
        HumanScoreTextB.GetComponent<Text>().text = HumanScore + " Points";

        DoggoScoreTextW.GetComponent<Text>().text = DoggoScore + " Points";
        DoggoScoreTextB.GetComponent<Text>().text = DoggoScore + " Points";

        if (TimeController.Phase == "PreRound")
        {
            HumanScore = 0;
            DoggoScore = 0;
            WinStateText.GetComponent<Text>().text = "Press Enter To Start";
        } else
        if (TimeController.Phase == "InRound")
        {
            WinStateText.GetComponent<Text>().text = "";
        } else
        if (TimeController.Phase == "EndRound")
        {
            if (HumanScore > DoggoScore)
            {
                WinStateText.GetComponent<Text>().text = "Human Wins! Press Enter";
            } else
            if (HumanScore < DoggoScore)
            {
                WinStateText.GetComponent<Text>().text = "Doggo Wins! Press Enter";
            } else
            if (HumanScore == DoggoScore)
            {
                WinStateText.GetComponent<Text>().text = "It's a Tie! Press Enter";
            }
        }
    }
}
