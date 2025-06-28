using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 5f;
    public GameObject explosionPrefab;
    private ScoreCounter scoreCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreCounter = GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * projectileSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            scoreCounter.AddScore(10);
            
            
        }

        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }

    }
}
