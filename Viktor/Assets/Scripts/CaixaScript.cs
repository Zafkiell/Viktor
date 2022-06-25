using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Corda")
        {
            GameObject.Find("ColisaoViga").GetComponent<Rigidbody>().useGravity = true;
            GameObject.Find("ColisaoViga").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("TrocaCameras").GetComponent<TrocaCamera>().LigaCamViga();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
