using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField]
    private Transform car;

    public void Move()
    {
        StartCoroutine(OnMove());
    }
    IEnumerator OnMove()
    {
        Vector3 pozition = car.localPosition;
        if (car.position.x > Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
        {
            for(int i = 0; i < 21; i++) 
            { 
                yield return new WaitForSeconds(0.2f*Time.deltaTime);
                pozition.x -= 10;
                car.localPosition = pozition;
            }
        }
        else 
        {
            for (int i = 0; i < 21; i++)
            {
                yield return new WaitForSeconds(0.2f*Time.deltaTime);
                pozition.x += 10;
                car.localPosition = pozition;
            }

        }

    }
}
