using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeController : MonoBehaviour
{
    [SerializeField]
    private ChangeBee skins;
    private int points;
    [SerializeField]
    private Text PointsText;
    [SerializeField]
    private GameObject Pole;

    void Update()
    { 
        PointsText.text = "" + points;
        Save();
        IsCollor();
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "flower")
        {
            collision.gameObject.SetActive(false);
            UpdateScore();
        }
    }
    public void IsCollor()
    {
        GetComponent<Image>().sprite = skins.bee[skins.beechange];
    }
    private void UpdateScore()
    {
        points++;

    }
    public void Save()
    {
        if (PlayerPrefs.HasKey("Monets"))
        {

            skins.beechange = PlayerPrefs.GetInt("Monets");

        }
        else
        {
            skins.beechange = 0;
        }
    }

}
