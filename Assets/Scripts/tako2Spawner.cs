using UnityEngine;

public class Tako2Spawner : MonoBehaviour
{
    public GameObject tako2Prefab;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timeUntilSpawn;
    private int counter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            Instantiate(tako2Prefab, transform.position, Quaternion.identity);
            counter++;
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        if (counter > 5.0f)
        {
            timeUntilSpawn = 1.0f;
        }
        else
        {
           timeUntilSpawn = Random.Range(minSpawnTime, maxSpawnTime); 
        }
        
    }
}
