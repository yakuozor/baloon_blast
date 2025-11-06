using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonController : MonoBehaviour
{
    public GameObject patlama;
    GameManager GameManagerScripti;

    private void Start()
    {
        GameManagerScripti = GameObject.Find("Spawner").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        GameObject sahnedekipatlama = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(sahnedekipatlama, 0.36f);
        GameManagerScripti.BalonEkle();
    }
}
