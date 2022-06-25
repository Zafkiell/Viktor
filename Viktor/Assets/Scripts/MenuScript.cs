using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Dropdown resl;
    public Dropdown quald;
    public Slider slid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        print("funciona");
    }

    public void Resolucao()
    {
        if (resl.value == 0)
        {
            Screen.SetResolution(800, 600, Screen.fullScreen);
        }

        if (resl.value == 1)
        {
            Screen.SetResolution(1024, 768, Screen.fullScreen);
        }
        if (resl.value == 2)
        {
            Screen.SetResolution(1280, 720, Screen.fullScreen);
        }

        if (resl.value == 3)
        {
            Screen.SetResolution(1366, 768, Screen.fullScreen);
        }

        if (resl.value == 4)
        {
            Screen.SetResolution(1440, 900, Screen.fullScreen);
        }
        if (resl.value == 5)
        {
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
        }
    }

    public void MudaAudio()
    {
        AudioListener.volume = slid.value;
    }

    public void MudaQualidade()
    {
        if (quald.value == 0)
        {
            QualitySettings.SetQualityLevel(0);
        }
        if (quald.value == 1)
        {
            QualitySettings.SetQualityLevel(1);
        }
        if (quald.value == 2)
        {
            QualitySettings.SetQualityLevel(2);
        }
        if (quald.value == 3)
        {
            QualitySettings.SetQualityLevel(3);
        }
        if (quald.value == 4)
        {
            QualitySettings.SetQualityLevel(4);
        }
        if (quald.value == 5)
        {
            QualitySettings.SetQualityLevel(5);
        }
    }
}
