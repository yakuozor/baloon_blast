using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonSpawner : MonoBehaviour
{
    public GameObject balon;
    float spawnTime = 1f;
    float timer = 0;
    GameManager GameManagerScript;

    void Start()
    {
        GameManagerScript = this.gameObject.GetComponent<GameManager>();



    }

    void Update()
    {
        timer -= Time.deltaTime;
        int multipiler = (int)(GameManagerScript.timer / 10)-5;
        multipiler *= -1;

        if (timer < 0 && GameManagerScript.timer > 0)
        {
            GameObject sahnedekibalon = Instantiate(balon, new Vector3(Random.Range(-2.2f, 2.2f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            sahnedekibalon.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30f*multipiler, 80f*multipiler), 0));
            timer = spawnTime;
        }



    }
}
