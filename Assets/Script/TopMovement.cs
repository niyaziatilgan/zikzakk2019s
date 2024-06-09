using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    //hýz ve yn veriyoruz
    Vector3 yön;
    public float hýz;
    public ZeminSpawn zeminSPAWN;
    public static bool fall;
    public float run;

    public GameObject  GameOverScreen;
    public Animator gameoverBackground;


    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        GetComponent<score>();
       
    //öncelikle topa ileri gitmesini istiroyuz
    yön = Vector3.forward;

        fall = false;
    }


    void Update()
    {
     

        if (transform.position.y <= -1f)
        {
            fall = true;
            //ölme:::
            
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
       


        //yön deðiþtirices
        if (Input.GetMouseButtonDown(0))
        {
            if (yön.x == 0)
            {
                yön = Vector3.left;
            }
            else
            {
                yön = Vector3.forward;
            }
            hýz += run * Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hýz;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            score.Score++;
            collision.gameObject.AddComponent<Rigidbody>();
            zeminSPAWN.zeminOluþtur();
            StartCoroutine(ZeminSil(collision.gameObject));
            
        }
    }


    IEnumerator ZeminSil(GameObject silinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(silinecekZemin);
    }


 
}
