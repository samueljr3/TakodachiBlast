using UnityEngine;

public class Tako1Spawner : MonoBehaviour
{
    public GameObject tako1Prefab;
    public GameObject tako2Prefab;
    public float minSpawnTime;
    public float maxSpawnTime;
    private float timeUntilSpawn;
    
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
            
            Instantiate(tako1Prefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        timeUntilSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
