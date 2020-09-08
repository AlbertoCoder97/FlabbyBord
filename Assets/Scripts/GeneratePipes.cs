using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GeneratePipes : MonoBehaviour
{
    public GameObject bottomPipe;
    public GameObject topPipe;

    public float respawnTime = 1.2f;

    public float positionX = 10000f;
    public int positionYbot = -9000;
    public int positionYtop = 11300;

    public int minDistance = 10000;
    System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PipeWave());
    }

    private void SpawnPipes()
    {
        GameObject pipe1 = Instantiate(bottomPipe) as GameObject;
        GameObject pipe2 = Instantiate(topPipe) as GameObject;;

        pipe1.transform.position = new Vector2(positionX, positionYbot + random.Next(0, -positionYbot/5) - minDistance);
        pipe2.transform.position = new Vector2(positionX, positionYtop - random.Next(0, positionYtop/5) + minDistance);
    }

    IEnumerator PipeWave()
    {
        //Initial waiting cause Unity can't apply correct physics to first 4 pipes.
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnPipes();
        }
            
    }
}
