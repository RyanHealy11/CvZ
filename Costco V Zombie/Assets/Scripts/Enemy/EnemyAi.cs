using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public GameObject Target;

    public int Health = 1;
    public int scorValue = 1;
    private int StartHealth;
    public bool Dead = false;

    public Vector3 SpawnCorner1;
    public Vector3 SpawnCorner2;

    public float Speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartHealth = Health;
        Target = PlayerController.instance.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(Target.transform.position);

        gameObject.transform.position += (gameObject.transform.forward * Speed * Time.deltaTime);
        if (Health <= 0) 
        {
            Dead = true;
        }
        if (Dead) 
        {
            Respawn();
        }
    }

    public void Respawn() 
    {
        gameObject.transform.position = new Vector3(Random.Range(SpawnCorner1.x, SpawnCorner2.x), transform.position.y, Random.Range(SpawnCorner1.z, SpawnCorner2.z));
        Dead = false;
        Health = StartHealth;
    }
}
