using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesScript : MonoBehaviour
{
    public int lives = 3;
    public Image[] lifeUI;
    public GameObject explosionPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy"){
            lives -= 1;
            Destroy(collision.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            for (int i = 0; i < lifeUI.Length; i++)
            {
                if (i < lives)
                {
                    lifeUI[i].enabled = true;
                }
                else
                {
                    lifeUI[i].enabled = false;
                }
            }

            if (lives == 0)
            {
                Destroy(gameObject);
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                SceneManager.LoadSceneAsync(2);
            }
        }
    }
}
