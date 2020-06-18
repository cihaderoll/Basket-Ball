using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitControl : MonoBehaviour
{
    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        basketHoopController.instantiate.isHit = true;
        
    }
}
