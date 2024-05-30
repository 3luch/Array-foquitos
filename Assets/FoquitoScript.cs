using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoquitoScript : MonoBehaviour
{
    public GameObject[] colors;
    public int currentLightIndex =-1;
    private int cyclecount = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateNextLight()
    {
        currentLightIndex++;
        if (currentLightIndex >= colors.Length)
        {
            currentLightIndex = 0;
            cyclecount++;
            if (cyclecount >= 3)
            {
                foco();
            }
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    public void ActivatePreviousLight()
    {
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    void DeactivateAllLights()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i].SetActive(false);
        }
    }

    public void ActivateRepeating(float time)
    {
        InvokeRepeating(nameof(ActivateNextLight),0,time);
    }
    void foco()
    {
        Destroy(gameObject);
    }
}
