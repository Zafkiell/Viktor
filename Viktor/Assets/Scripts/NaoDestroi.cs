using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaoDestroi : MonoBehaviour
{
    public static bool tocando;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if (!tocando)
        {
            GetComponent<AudioSource>().Play();
            tocando = true;
        }
    }
}
