using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketHoopController : MonoBehaviour
{

    public static basketHoopController instantiate;


    public GameObject basketHoopRight;
    public GameObject basketHoopLeft;
    float randY;
    public int i = 1;
    public int score = 0;
    public bool isHit = false;


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

    public void setInactive()
    {
        Invoke("InactiveHoop", 0.5f);
        if(i % 2 == 0)
        {
            randY = Random.Range(-1.7f, 3.8f);
            basketHoopLeft.transform.position = new Vector3(basketHoopLeft.transform.position.x, randY, basketHoopLeft.transform.position.z);
            basketHoopLeft.SetActive(true);
        }
        else
        {
            randY = Random.Range(-1.7f, 3.8f);
            basketHoopRight.transform.position = new Vector3(basketHoopRight.transform.position.x, randY, basketHoopRight.transform.position.z);
            basketHoopRight.SetActive(true);
        }

    }

    private void InactiveHoop()
    {
        if(i%2 == 0)
        {
            basketHoopRight.SetActive(false);
           
        }
        else
        {
            basketHoopLeft.SetActive(false);
            
        }
        
    }
    
    
}
