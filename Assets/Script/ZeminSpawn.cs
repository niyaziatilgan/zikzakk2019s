using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawn : MonoBehaviour
{
    public GameObject sonZemin;
    
    public void Start()
    {
        for (int i = 0; i < 25; i++)
        {
            zeminOluþtur();
        }
    }

    
    void Update()
    {
       
    }

    public void zeminOluþtur()
    {
        //spawn yönü veriliyo
        Vector3 yön;
        if (Random.Range(0, 2) == 0)
        {
            yön = Vector3.left;
        }
        else
        {
            yön = Vector3.forward;
        }

        //spawn kodu
       sonZemin = Instantiate(sonZemin, sonZemin.transform.position + yön, sonZemin.transform.rotation);
    }
}
