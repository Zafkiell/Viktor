using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class MudaSkyboxScript : MonoBehaviour
{
    bool explode;
    PostProcessVolume volume;
    bool anoitece;

    // Start is called before the first frame update
    void Start()
    {
        explode = false;
        volume = GameObject.Find("VolumesPostProcessing").GetComponent<PostProcessVolume>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (anoitece) {
            if (volume != null)
            {
                ColorGrading colorgrad;
                volume.profile.TryGetSettings(out colorgrad);
                if (colorgrad != null && colorgrad.temperature.value > -23f) { colorgrad.temperature.value -= 1f; }
            }
        }
    }
    public void Delay()
    {
        anoitece = true;
        Invoke("Anoitecer", 2f);
    }

    void Anoitecer()
    {
        anoitece = true;
        RenderSettings.fog = true;
        GameObject.Find("SomPiano").GetComponent<AudioSource>().Stop();
        if(GameObject.Find("ParedeInvisivel") != null) GameObject.Find("ParedeInvisivel").SetActive(false);
        if (GameObject.Find("Portao") != null) GameObject.Find("Portao").SetActive(false);
        Invoke("Explode", 2f);
    }

    void Explode()
    {
        if (!explode) GameObject.Find("Explosao").GetComponent<AudioSource>().Play();
        explode = true;
    }
}
