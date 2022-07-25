using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    public bool clin;
    public GameObject[] flowers;
    void Start()
    {
        clin = true;
    }

    void Update()
    {
        Restart();
        
        if (clin == true)
        {
            clin = false;
            StartCoroutine(Move());
        }
    }
    IEnumerator Move()
    {
        yield return new WaitForSeconds(1.5f*Time.deltaTime);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y-10);
        clin = true;
    }
    public void Restart()
    {
        if (transform.localPosition.y <= -1602)
        {
            transform.localPosition = new Vector2(transform.localPosition.x, 1602);
            for (int i = 0; i < flowers.Length; i++)
            {
                flowers[i].gameObject.SetActive(true);
            }
        }
    }

}
