using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Camera camera;
    public Score score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {            
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.TryGetComponent(out EnemyAi bob))
                {
                    bob.Health--;
                    if (bob.Health <= 0)
                    {
                        score.curScore += (bob.scorValue * score.multiplier);
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
