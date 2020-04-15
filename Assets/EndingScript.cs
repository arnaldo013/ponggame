using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI endingText;
    void Start()
    {
        if(ScoringScript.scoreP1 > ScoringScript.scoreP2)
        {
            endingText.text = "Player 1 Wins";
        }else if(ScoringScript.scoreP2 > ScoringScript.scoreP1)
        {
            endingText.text = "Player 2 Wins";
        } 
        else
        {
            endingText.text = "Tie";
        }


    }

    
}
