using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] players;
    public GameObject currentPlayer;

    public Transform[] spawnPoints;
    public int currentSpawnPoint = 0;
    public bool isSpawning = false;

    void Update()
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (!players[i].activeInHierarchy)
            {
                currentPlayer = players[i];
            }
        }
        if(currentPlayer)
        {
            if(!currentPlayer.activeInHierarchy)
            {
                if(!isSpawning)
                {
                    isSpawning = true;
                    StartCoroutine(RespawnPlayer());
                }
            }
        }
    }

    void RandomizeSpawnPoint()
    {
        currentSpawnPoint = Random.Range(0, spawnPoints.Length);
    }

    IEnumerator RespawnPlayer()
    {
        RandomizeSpawnPoint();
        yield return new WaitForSecondsRealtime(1.0f);
        currentPlayer.SetActive(true);
        currentPlayer.gameObject.transform.position = spawnPoints[currentSpawnPoint].position;
        isSpawning = false;
        StopCoroutine(RespawnPlayer());
    }

}
