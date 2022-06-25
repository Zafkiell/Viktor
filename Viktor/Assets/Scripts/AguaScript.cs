using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaScript : MonoBehaviour
{
    [SerializeField]
    GameObject ObjetoAgua;
    public bool rodaAgua;
    bool rodaCano;
    public bool tocou;
    float posY;

    // Start is called before the first frame update
    void Start()
    {
        posY = ObjetoAgua.transform.position.y;
        rodaCano = false;
        tocou = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rodaAgua)
        {
            ObjetoAgua.transform.Translate(0, posY/300 * Time.deltaTime, 0);   
            posY+= 1 * Time.deltaTime;

            if (rodaCano == true && tocou == false)
            {
                GameObject.Find("SomVigaCai").GetComponent<AudioSource>().Play();
                tocou = true;
                rodaCano = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rodaAgua = true;
            rodaCano = true;
            ObjetoAgua.SetActive(true);
        }
    }
}
