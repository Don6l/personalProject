using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.Universal;

public class GameMasterScript : MonoBehaviour
{
    [SerializeField]
    Canvas menuCanvas;
    [SerializeField]
    SpriteMovementScript playerObject;
    public bool isGamePaused;
    [SerializeField]
    private Light2D moon;
    [SerializeField]
    private AudioSource levelMusic;

    void Start()
    {
        moon.intensity = 0;
        isGamePaused = true;
        levelMusic = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (!isGamePaused)
        { 
            menuCanvas.enabled = false;
           
        }
    }

    public void StartButtonClick()
    {
       
        moon.GetComponent<MoonLightScript>().MoonBrighter();
        isGamePaused = false;
        levelMusic.Play();
    }

    public void ExitButtonClick()
    {
        
        Application.Quit();
    }

}
