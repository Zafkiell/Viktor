using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ParaMusica()
    {
        GameObject.Find("SomFundoTenso").GetComponent<AudioSource>().Stop();
        GameObject.Find("SomPiano").GetComponent<AudioSource>().Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (this.name == "FLAG1" && GameObject.Find("SomFundoCalmo").GetComponent<AudioSource>().isPlaying == false)
            {
                GameObject.Find("SomFundoCalmo").GetComponent<AudioSource>().Play();
                GameObject.Find("SomPiano").GetComponent<AudioSource>().Stop();
            }
            if (this.name == "FLAG2" && GameObject.Find("SomFundoTenso").GetComponent<AudioSource>().isPlaying == false)
            {
                GameObject.Find("SomFundoTenso").GetComponent<AudioSource>().Play();
                GameObject.Find("SomFundoCalmo").GetComponent<AudioSource>().Stop();
            }
            if (this.name == "FLAGPIANO" && GameObject.Find("SomPiano").GetComponent<AudioSource>().isPlaying == false)
            {
                GameObject.Find("SomPiano").GetComponent<AudioSource>().Play();
                GameObject.Find("SomFundoCalmo").GetComponent<AudioSource>().Stop();
            }
            if (this.name == "FLAGFARO" && GameObject.Find("SomFaro").GetComponent<AudioSource>().isPlaying == false)
            {
                GameObject.Find("SomFaro").GetComponent<AudioSource>().Play();
            }
        }
    }
}
