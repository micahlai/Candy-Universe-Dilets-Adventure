using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCycle : MonoBehaviour {
    [SerializeField] private Light sun;
    [SerializeField] private float secondsInFullDay = 60f;

    [Range(0, 1)] [SerializeField] private float currentTimeOfDay = 0;
    private float timeMultiplier = 1f;
    private float sunInitialIntestity;
    public Material day;
    public Material sunset;
    public Material night;
    public int dayNum = 1;

    void Start(){
        sunInitialIntestity = sun.intensity;
    }

    void Update()
    {
        UpdateSun();

        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;

        if (currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
            dayNum = dayNum + 1;
        }
        if (currentTimeOfDay >= 0.25 && currentTimeOfDay <= 0.3)
        {
            RenderSettings.skybox = sunset;
        }else if(currentTimeOfDay >= 0.3 && currentTimeOfDay <= 0.7)
        {
            RenderSettings.skybox = day;
        }else if(currentTimeOfDay >= 0.7 && currentTimeOfDay <= 0.75)
        {
            RenderSettings.skybox = sunset;
        }
        else
        {
            RenderSettings.skybox = night;
        }
    }

    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);
        float intestityMultiplier = 1;
        if (currentTimeOfDay <= 0.2f || currentTimeOfDay >= 0.75f)
        {
            intestityMultiplier = 0;
           
        }
        else if (currentTimeOfDay <= 0.25f)
        {
            intestityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
            
        }
        else if (currentTimeOfDay >= 0.73f) {
            intestityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay -0.75f) * (1/0.02f)));
            
        }


        sun.intensity = sunInitialIntestity * intestityMultiplier;
    }
}
