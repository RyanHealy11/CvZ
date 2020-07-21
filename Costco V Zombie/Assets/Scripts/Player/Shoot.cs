using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    #region
    public static Shoot instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public Camera playerCamera;
    private Score score;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        score = Score.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {            
            RaycastHit hit;
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.TryGetComponent(out EnemyAi bob))
                {
                    bob.Health -= damage;
                    if (bob.Health <= 0)
                    {
                        score.curScore += (bob.scorValue * score.multiplier);
                        score.curMoney += bob.moneyValue;
                    }
                    score.multiplier++;
                }
                else
                {
                    score.multiplier = 1;
                }
            }
            else 
            {
                score.multiplier = 1;
            }
        }        
    }
}
