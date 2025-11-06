using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timer = 50f;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI balonText;
    public GameObject patlama;
    int patlayanBalon =0;

    void Start()
    {
        balonText.text += patlayanBalon;
        Application.targetFrameRate = 60;
    }



    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = "ZAMAN \n" + (int)timer;
        }else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i=0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
            
        }
    }

    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text ="PUAN\n" + patlayanBalon;
    }
}
