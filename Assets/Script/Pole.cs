using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    public bool move;
    public GameObject[] flowers;
    void Start()
    {
        move = true;
    }

    void Update()
    {
        if (transform.localPosition.y <= -1602)
        {
            transform.localPosition = new Vector2(transform.localPosition.x, 1602);
            for (int i = 0; i < flowers.Length; i++)
            {
                flowers[i].gameObject.SetActive(true);
            }
        }
        if (move == true)
        {
            move = false;
            StartCoroutine(Move());
        }
    }
    IEnumerator Move()
    {
        yield return new WaitForSeconds(1.5f*Time.deltaTime);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y-10);
        move = true;
    }

}
