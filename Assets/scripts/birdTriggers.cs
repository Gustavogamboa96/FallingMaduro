using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class birdTriggers : MonoBehaviour {
    public coincounter counter;
    Text vidas, puntos;
	// Use this for initialization
	void Start () {
        counter = GameObject.Find("coincounter").GetComponent<coincounter>();
        vidas = GameObject.Find("Vidas").GetComponent<Text>();
        puntos = GameObject.Find("Puntos").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        vidas.text = "Vidas: " + counter.lives;
        puntos.text = "Puntos: " + counter.coins;
        if (counter.lives == 0)
            SceneManager.LoadScene("endofgame");
        //Debug.Log(counter.lives);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision.gameObject.name == "tuxedocapriles")
        {
            Destroy(gameObject);
            counter.lives--;
            //Debug.Log(counter.lives);
            
        }
       if(collision.gameObject.name == "endOfFrame")
        {
            Destroy(gameObject);
            //gameObject.SetActive(false);
            counter.coins++;
        }
    }
}
