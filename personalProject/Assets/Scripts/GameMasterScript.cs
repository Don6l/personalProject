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

    void Start()
    {
        moon.intensity = 0;
        isGamePaused = true; 
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
        Debug.Log("Start game");
        moon.GetComponent<MoonLightScript>().MoonBrighter();
        isGamePaused = false;
    }

    public void ExitButtonClick()
    {
        Debug.Log("Exit Button Clicked");
        Application.Quit();
    }

}
