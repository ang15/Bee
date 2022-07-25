using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeController : MonoBehaviour
{
    [SerializeField]
    private Collor material;
    private float score;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private GameObject thisPole;

    void Update()
    { 
        scoreText.text = "" + score;
        if (PlayerPrefs.HasKey("Monets"))
        {

            material.beechange = PlayerPrefs.GetInt("Monets");

        }
        else
        {
            material.beechange = 0;
        }
        GetComponent<Image>().sprite = material.bee[material.beechange];
    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "flower")
        {
            score++;
            collision.gameObject.SetActive(false);
        }
    }
}
