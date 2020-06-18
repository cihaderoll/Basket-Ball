using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayiKontrol1 : MonoBehaviour
{
    public static sayiKontrol1 instantiate;

    public bool isBallEnter = false;


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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isBallEnter = true;
    }
}
