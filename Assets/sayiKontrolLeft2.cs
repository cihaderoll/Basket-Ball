using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayiKontrolLeft2 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (sayiKontrolLeft1.instantiate.isBallEnter)
        {
            if (!(basketHoopController.instantiate.isHit))
            {

                if (ballController.instantiate.ballSmoke.activeSelf == true)
                {
                    ballController.instantiate.ballSmoke.SetActive(false);
                    ballController.instantiate.ballFlame.SetActive(true);
                }
                else if (ballController.instantiate.ballFlame.activeSelf == false)
                {
                    ballController.instantiate.ballSmoke.SetActive(true);
                }

                if (ballController.instantiate.ballFlame.activeSelf == true)
                {
                    basketHoopController.instantiate.score += 5;
                }
                else if (ballController.instantiate.ballSmoke.activeSelf == true)
                {
                    basketHoopController.instantiate.score += 2;
                }
                else
                {
                    basketHoopController.instantiate.score++;
                }

            }
            else
            {
                basketHoopController.instantiate.score++;
                ballController.instantiate.ballSmoke.SetActive(false);
                ballController.instantiate.ballFlame.SetActive(false);
            }
            
            ballController.instantiate.ses.volume = 0.75f;
            ballController.instantiate.ses.PlayOneShot(ballController.instantiate.swish);
            UIController.instantiate.slider.value = 1.0f;
            basketHoopController.instantiate.i++;
            Invoke("animationPlay", 0.2f);
            
            ballController.instantiate.ballDir *= -1;
            basketHoopController.instantiate.setInactive();
            sayiKontrolLeft1.instantiate.isBallEnter = false;
        }
        
    }

    private void animationPlay()
    {
        PotaLeftScript.instantiate.PotaExitAnim.Play();
    }
}
