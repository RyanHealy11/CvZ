using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    #region
    public static Score instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public int curScore = 0;
    public int multiplier = 1;
    public int curMoney = 0;

    public Text displayScore;
    public Text displayMultiplier;
    public Text displayMoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayScore.text = "Score: " + curScore;
        displayMultiplier.text = "multiplier: " + multiplier;
        displayMoney.text = "Money: " + curMoney + "$";
    }
}
