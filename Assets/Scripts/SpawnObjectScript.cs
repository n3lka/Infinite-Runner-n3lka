using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private GameManager gm;

    private float timer;
    void Start()
        //gameobject with gamemanager script in editor, on gameobject it has component which is gamemanager script
        //everytime object spawns it will call this function
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 6)
        {
            Destroy(gameObject);
        }

        rb.velocity = Vector2.left * (speed + gm.speedMultiplier);
    }
}
