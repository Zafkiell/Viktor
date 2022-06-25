using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigaCamera : MonoBehaviour
{
    [SerializeField]
    GameObject teste;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            teste.GetComponent<TrocaCamera>().VoltaCamera();
        }
    }
}
