using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // [] piszemy by c# rozpoznal ze to array(szereg wielu rodzajow jedenj rzeczy 
    // np string[] cars;    
    // string[] cars = {"BMV", "Volvo"};

    public GameObject spawnObject;
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSpawns;

    public float speedMultiplier;
    private float distance;

    public Text distanceUI;
    void Start()
    {
        
    }

    //Time.deltaTime - time since the game has started
    //Quaternion - rotation of an object
    void Update()
    {

        distanceUI.text = "Distance:" + distance.ToString("F2");
        speedMultiplier += Time.deltaTime * 0.15f;

        timer += Time.deltaTime;

        distance += Time.deltaTime * 0.8f;


        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum = Random.Range(0, 3);
            Instantiate(spawnObject, spawnPoints[randNum].transform.position, Quaternion.identity);
        }
    }
}
