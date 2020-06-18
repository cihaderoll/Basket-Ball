using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enterSceneEvents : MonoBehaviour
{
    public Button playButton;
    public Sprite pressPlaySprite;
    Image sprite;

    public Button soundButton;
    public Sprite soundOffSprite;
    public Sprite soundOnSprite;
    Image soundSprite;
    int i = 0;

    public GameObject ball;
    Rigidbody2D fizik;

    void Start()
    {
        sprite = playButton.GetComponent<Image>();
        soundSprite = soundButton.GetComponent<Image>();
        fizik = ball.GetComponent<Rigidbody2D>();
        fizik.AddForce(new Vector2(10, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void startGame()
    {
        sprite.sprite = pressPlaySprite;
        SceneManager.LoadScene("GameScene");
    }

    public void soundOff()
    {
        if (i % 2 == 0)
        {
            soundSprite.sprite = soundOffSprite;
            i++;
        }
        else
        {
            soundSprite.sprite = soundOnSprite;
            i++;
        }
        
    }
}
