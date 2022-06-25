using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cavuca()
    {
        GameObject.Find("SomCavar").GetComponent<AudioSource>().Play();
        Destroy(gameObject,1f);
        Invoke("ParaSom",0.9f);
    }

    void ParaSom()
    {
        GameObject.Find("SomCavar").GetComponent<AudioSource>().Stop();
    }

    public void EmpurraCaixa()
    {
        Invoke("Caixa", 0.9f);      
    }

    void Caixa()
    {
        GameObject.Find("Caixa").GetComponent<Rigidbody>().AddForce(-transform.right * 100);
    }
}
