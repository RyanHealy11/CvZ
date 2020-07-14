using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int curScore = 0;
    public int multiplier = 1;

    public Text displayScore;
    public Text displayMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayScore.text = "Score: " + curScore;
        displayMultiplier.text = "multiplier: " + multiplier;
    }
}
