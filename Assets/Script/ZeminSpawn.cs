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
            zeminOlu�tur();
        }
    }

    
    void Update()
    {
       
    }

    public void zeminOlu�tur()
    {
        //spawn y�n� veriliyo
        Vector3 y�n;
        if (Random.Range(0, 2) == 0)
        {
            y�n = Vector3.left;
        }
        else
        {
            y�n = Vector3.forward;
        }

        //spawn kodu
       sonZemin = Instantiate(sonZemin, sonZemin.transform.position + y�n, sonZemin.transform.rotation);
    }
}
