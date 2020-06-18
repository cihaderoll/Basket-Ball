using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballController : MonoBehaviour
{
    public static ballController instantiate;

    public Rigidbody2D fizik;
    public GameObject ball;
    public int ballDir = 20;
    public AudioSource ses;
    public AudioClip swish;
    public AudioClip sekme;
    public AudioClip finish;
    public GameObject ballFlame;
    public GameObject ballSmoke;
    public GameObject pointText;
    public Text point;


    private void Awake()
    {
        instantiate = this;
    }

    void Start()
    {
        fizik = ball.GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !(UIController.instantiate.paused))
        {

            if(Input.mousePosition.y < 1750)
            {
                basketHoopController.instantiate.isHit = false;
                fizik.velocity = new Vector2(0, 0);
                fizik.AddForce(new Vector2(ballDir, 60));
                ballController.instantiate.ses.volume = 1f;
                ses.PlayOneShot(sekme);
                sayiKontrol1.instantiate.isBallEnter = false;
                sayiKontrolLeft1.instantiate.isBallEnter = false;
            }
            
            
        }

        if(ball.transform.position.x >= 3.18f)
        {
            ball.transform.position += new Vector3(-6.36f, 0);
        }
        else if(ball.transform.position.x <= -3.18f)
        {
            ball.transform.position += new Vector3(6.36f, 0);
        }

        
       
    }

    

    
}
