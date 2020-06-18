using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderController : MonoBehaviour
{
    public static colliderController instantiate;


    public GameObject basketHoopLeft;
    float randY;
    public Animation reverseAnim;
    public bool isSayi = false;


    private void Awake()
    {
        instantiate = this;
    }

    void Start()
    {

        
    }

    
    void Update()
    {
          
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        
        ballController.instantiate.ballDir *= -1;
        reverseAnim.Play();
        randY = Random.Range(3.15f, -2.5f);
        
        isSayi = true;
    }
}
