using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class MoonLightScript : MonoBehaviour
{
    private int countUpTime = 0;
    [SerializeField]
    private Light2D moon;
    public void MoonBrighter()
    {
        Debug.Log("MoonBrighter Start");
        StartCoroutine("CountUp");
    }

    public void MoonDarker()
    {

    }

    private IEnumerator CountUp()
    {
        while (countUpTime < 10)
        {
            Debug.Log(countUpTime);
            moon.intensity += 0.1f;
            yield return new WaitForSeconds(.1f);
            countUpTime++;
        }
    }

}
