using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    [SerializeField]
    private Collor material;
    public void left()
    {
        if (material.beechange == 4)
        {

          PlayerPrefs.SetInt("matirial",0);

            material.beechange = 0;
        }
        else
        {
            material.beechange++;
        PlayerPrefs.SetInt("matirial", 0);
        }
        GetComponent<Image>().sprite = material.bee[material.beechange];
    }
    public void Right()
    {
        if (material.beechange == 0)
        {
            material.beechange = 4;
        }
        else
        {
            material.beechange--;
        }
        GetComponent<Image>().sprite = material.bee[material.beechange];
    }

  
}
