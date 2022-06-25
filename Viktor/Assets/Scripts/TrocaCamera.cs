using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MalbersAnimations;

public class TrocaCamera : MonoBehaviour
{

    public GameObject Cachorro,ZonaDormir,CameraNormal, CameraViga, CameraLabirinto,CameraInicial,CameraFinal;

    private void Start()
    {
        Invoke("VoltaCamera", 30f);
    }

    private void Update()
    {
    }

    public void LigaCamViga()
    {
        CameraNormal.SetActive(false);
        CameraViga.SetActive(true);
        Invoke("VoltaCamera", 3f);
        Invoke("TocaSomViga", 1f);
    }

    void TocaSomViga()
    {
        GameObject.Find("SomVigaCai").GetComponent<AudioSource>().Play();
        GameObject.Find("SomVigaAgua").GetComponent<AudioSource>().Play();
    }

    public void VoltaCamera()
    {
        CameraViga.SetActive(false);
        CameraLabirinto.SetActive(false);
        CameraInicial.SetActive(false);

        CameraNormal.SetActive(true);
        ZonaDormir.SetActive(true);
        GameObject.Find("Wolf Grey Magic").GetComponent<MalbersInput>().CameraBaseInput = true;
        GameObject.Find("Wolf Grey Magic").GetComponent<MalbersInput>().enabled = true;
        GameObject.Find("Wolf Grey Magic").GetComponent<Animal>().enabled = true;
        //if(GameObject.Find("Wolf Grey Magic").GetComponent<CheatScript>() != null) GameObject.Find("Wolf Grey Magic").GetComponent<CheatScript>().enabled = true;
    }
    public void UltimaCamera()
    {
        CameraNormal.SetActive(false);
        CameraFinal.SetActive(true);
        GameObject.Find("Wolf Grey Magic").GetComponent<MalbersInput>().CameraBaseInput = false;
        GameObject.Find("Wolf Grey Magic").GetComponent<MalbersInput>().enabled = false;
        GameObject.Find("Wolf Grey Magic").GetComponent<Animal>().enabled = false;
        //if (GameObject.Find("Wolf Grey Magic").GetComponent<CheatScript>() != null) GameObject.Find("Wolf Grey Magic").GetComponent<CheatScript>().enabled = false;
        GameObject.Find("VaiDeitar").SetActive(false);
        GameObject.Find("SomPiano").GetComponent<AudioSource>().Play();
    }
}
