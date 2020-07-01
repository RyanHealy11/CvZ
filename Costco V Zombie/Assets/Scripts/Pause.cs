using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Canvas GameCanvas;
    public Canvas PauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            GameCanvas.gameObject.SetActive(!GameCanvas.gameObject.activeSelf);
            PauseCanvas.gameObject.SetActive(!PauseCanvas.gameObject.activeSelf);
        }
               
    }
}
