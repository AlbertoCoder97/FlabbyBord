using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipes : MonoBehaviour
{
    public GameObject bottomPipe;
    public GameObject topPipe;

    public float respawnTime = 1.0f;

    public float positionX = 10000f;
    public int positionYbot = -9000;
    public int positionYtop = 11300;

    public int minDistance = 600;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PipeWave());
    }

    private void SpawnPipes()
    {
        GameObject pipe1 = Instantiate(bottomPipe) as GameObject;
        GameObject pipe2 = Instantiate(topPipe) as GameObject;;

        pipe1.transform.position = new Vector2(positionX * 1.2f, positionYbot);
        pipe2.transform.position = new Vector2(positionX * 1.2f, positionYtop);
    }

    IEnumerator PipeWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnPipes();
        }
            
    }
}
