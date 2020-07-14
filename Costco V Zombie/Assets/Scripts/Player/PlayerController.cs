using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region
    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            gameObject.transform.position += (new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += (new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += (new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += (new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
    }
}
