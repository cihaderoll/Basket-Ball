using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayiKontrolLeft1 : MonoBehaviour
{

    public static sayiKontrolLeft1 instantiate;

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
