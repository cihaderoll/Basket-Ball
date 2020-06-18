using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayiKontrol2 : MonoBehaviour
{

    //public Animation pointAnim;
    
    void Start()
    {
        //pointAnim.playAutomatically = false;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (sayiKontrol1.instantiate.isBallEnter)
        {
            if (!(basketHoopController.instantiate.isHit))
            {
                
                if (ballController.instantiate.ballSmoke.activeSelf == true)
                {
                    ballController.instantiate.ballSmoke.SetActive(false);
                    ballController.instantiate.ballFlame.SetActive(true);
                }
                else if(ballController.instantiate.ballFlame.activeSelf == false)
                {
                    ballController.instantiate.ballSmoke.SetActive(true);
                }

                if(ballController.instantiate.ballFlame.activeSelf == true)
                {
                    basketHoopController.instantiate.score += 5;
                    CreatePointText(5);
                }
                else if (ballController.instantiate.ballSmoke.activeSelf == true)
                {
                    basketHoopController.instantiate.score += 2;
                    CreatePointText(2);
                }
                else
                {
                    basketHoopController.instantiate.score ++;
                    
                }
   
            }
            else
            {
                basketHoopController.instantiate.score++;
                CreatePointText(1);
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
            sayiKontrol1.instantiate.isBallEnter = false;
        }
    }

    private void animationPlay()
    {
        PotaRightScript.instantiate.PotaExitAnim.Play();
    }

    public void CreatePointText(int point)
    {
        if(basketHoopController.instantiate.basketHoopRight.activeSelf == true)
        {
            //ballController.instantiate.pointText.transform.position = new Vector3(basketHoopController.instantiate.basketHoopRight.transform.position.x +500, basketHoopController.instantiate.basketHoopRight.transform.position.y +1000, basketHoopController.instantiate.basketHoopRight.transform.position.z);
            //ballController.instantiate.point.text = "+" + point;
            //ballController.instantiate.pointText.SetActive(true);
            ////pointAnim.Play();
            Debug.Log("girildi");
            //Invoke("closePointTextAnim", 0.4f);
        }
        else
        {

        }
    }
    public void closePointTextAnim()
    {
        ballController.instantiate.pointText.SetActive(false);
    }
}
