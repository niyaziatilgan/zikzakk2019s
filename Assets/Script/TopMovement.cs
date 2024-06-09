using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    //h�z ve yn veriyoruz
    Vector3 y�n;
    public float h�z;
    public ZeminSpawn zeminSPAWN;
    public static bool fall;
    public float run;

    public GameObject  GameOverScreen;
    public Animator gameoverBackground;


    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        GetComponent<score>();
       
    //�ncelikle topa ileri gitmesini istiroyuz
    y�n = Vector3.forward;

        fall = false;
    }


    void Update()
    {
     

        if (transform.position.y <= -1f)
        {
            fall = true;
            //�lme:::
            
            GameOverScreen.SetActive(true);
            if(GameOverScreen == true)
            {    
              gameoverBackground.SetBool("dead", true);
                
                if(transform.position.y <= -25f)
                {
                    Time.timeScale = 0;
                }
            }
            
            


        }
        if (fall == true)
        {
            return;

        }
       


        //y�n de�i�tirices
        if (Input.GetMouseButtonDown(0))
        {
            if (y�n.x == 0)
            {
                y�n = Vector3.left;
            }
            else
            {
                y�n = Vector3.forward;
            }
            h�z += run * Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        Vector3 hareket = y�n * Time.deltaTime * h�z;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            score.Score++;
            collision.gameObject.AddComponent<Rigidbody>();
            zeminSPAWN.zeminOlu�tur();
            StartCoroutine(ZeminSil(collision.gameObject));
            
        }
    }


    IEnumerator ZeminSil(GameObject silinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(silinecekZemin);
    }


 
}
