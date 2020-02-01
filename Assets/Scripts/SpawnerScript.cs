using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    private Transform Player;

    [SerializeField]
    private GameObject[] enemies;
    [SerializeField]
    private Vector3 spawnAxisValue;
    [SerializeField]
    private float spawnWait = 1f;
    [SerializeField]
    private float startWait = 1;

    private int randAsteroid;

    [SerializeField]
    private float minSpawnPositionX = 10f;
    [SerializeField]
    private float minSpawnPositionY = 10f;


    // Use this for initialization
    private void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        SpawnAsteroids();
    }

    private IEnumerator SpawnAsteroids()
    {
        yield return new WaitForSeconds(startWait);

        while(true)
        {
            randAsteroid = Random.Range(0, 2);

            Vector3 spawnPosition = new Vector3(RandomSpawnValues().x, RandomSpawnValues().y, 0);
            Debug.Log(Player.position.x);

            Instantiate(enemies[randAsteroid], spawnPosition, gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }

    private Vector3 RandomSpawnValues()
    {
        float spawnValueX = Random.Range(-spawnAxisValue.x, spawnAxisValue.x) + Player.position.x;
        float spawnValueY = Random.Range(-spawnAxisValue.y, spawnAxisValue.y) + Player.position.y;

        if (spawnValueX >= 0)
            spawnValueX += minSpawnPositionX;
        else spawnValueX -= minSpawnPositionX;

        if (spawnValueY >= 0)
            spawnValueY += minSpawnPositionY;
        else spawnValueY -= minSpawnPositionY;

        return new Vector3(spawnValueX, spawnValueY, 0);
    }

    
}
