using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBee : MonoBehaviour
{
    public Sprite[] bee = new Sprite[5];
    public int beechange = 0;
  
    public void Left()
    {
        UpdateLeft();
    }
    public void Right()
    {
        UpdateRight();
    }
        
    private void UpdateLeft()
    {
        if (beechange == 4)
        {

            beechange = 0;
        }
        else
        {
            beechange++;
        }

        isSkin();
    }
    private void UpdateRight()
    {
        if (beechange == 0)
        {

            beechange = 4;
        }
        else
        {
            beechange--;
        }
        isSkin();
    }
    private void isSkin() { 
        GetComponent<Image>().sprite = bee[beechange];
    }
}
