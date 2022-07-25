using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField]
    private Transform bee;

    public void Move()
    {
        StartCoroutine(OnMove());
    }
   
    private void OnMoveLeft()
    {
        Vector3 pozition = bee.localPosition;
         pozition.x -= 10;
            bee.localPosition = pozition;
        
    } 
    private void OnMoveRight()
    {
        Vector3 pozition = bee.localPosition;
            pozition.x += 10;
            bee.localPosition = pozition;
        

    }
    IEnumerator OnMove()
    {
        if (bee.position.x > Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
        {
            for(int i = 0; i < 21; i++) 
            {
                OnMoveLeft();
            }
        }
        else 
        {
            for (int i = 0; i < 21; i++)
            {
                yield return new WaitForSeconds(0.2f*Time.deltaTime);
                OnMoveRight();
            }

        }

    }
}
