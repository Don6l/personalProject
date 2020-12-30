using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class MoonLightScript : MonoBehaviour
{
    private int countUpTime = 0;
    [SerializeField]
    private Light2D moon;
    
    public void MoonBrighter(){
        StartCoroutine("CountUp");
    }

    public void MoonDarker()
    {

    }

    //Counts to 50 and raising intensitiy of moon objects brightness to give spot light affect at begining of scene.
    private IEnumerator CountUp(){
        while (countUpTime < 50){
            moon.intensity += 0.025f;
            yield return new WaitForSeconds(.15f);
            countUpTime++;
        }
    }
}