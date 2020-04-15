using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoringTextP1, scoringTextP2;
    public static int scoreP1=0, scoreP2=0;
    void Start()
    {
        scoringTextP1.text = scoreP1.ToString();
        scoringTextP2.text = scoreP2.ToString();    
    }

    public void updateScore(string namaDinding)
    {
        if(namaDinding == "DindingKiri")
        {
            scoreP2 += 1;
            scoringTextP2.text = scoreP2.ToString();
        }else if(namaDinding == "DindingKanan")
        {
            scoreP1 += 1;
            scoringTextP1.text = scoreP1.ToString();

        }
    }
}

