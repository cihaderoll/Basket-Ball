using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public static UIController instantiate;

    public Slider slider;
    public Text scoreText;
    public GameObject pausePanel;
    public bool paused = false;

    private void Awake()
    {
        instantiate = this;
    }

    void Start()
    {
        slider.value = 1.0f;

    }

    
    void Update()
    {
        scoreText.text = "" + basketHoopController.instantiate.score;
        if(basketHoopController.instantiate.score > 0 && !(paused))
        {
            slider.value -= 0.005f;
        }
        if(slider.value <= 0)
        {
            //ballController.instantiate.ses.PlayOneShot(ballController.instantiate.finish);
        }
        
    }

    public void  pauseButton()
    {
        ballController.instantiate.fizik.velocity = new Vector2(0, 0);
        ballController.instantiate.fizik.gravityScale = 0;
        paused = true;
        pausePanel.gameObject.SetActive(true);   
    }

    public void pausedPlayButton()
    {
        ballController.instantiate.fizik.gravityScale = 3;
        paused = false;
        pausePanel.gameObject.SetActive(false);
    }
}
