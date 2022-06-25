using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorteScript : MonoBehaviour
{
    [SerializeField]
    GameObject Dormir,Mensagem,Dono;
    Color txt;
    bool aparece = false;

    bool ativaDelay;
    float delay;
    bool rodou;

    // Start is called before the first frame update
    void Start()
    {
        ativaDelay = false;
        delay = 0;
        rodou = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ativaDelay)
        {
            delay += Time.deltaTime;
        }

        if (delay >= 10 && rodou == false)
        {
            Dormir.SetActive(true);
            Dono.GetComponent<Animator>().Play("Morto");
            txt = Mensagem.GetComponent<Text>().color;
            aparece = true;
            rodou = true;
        }

        if(aparece)txt.a +=  0.1f * Time.deltaTime;
        Mensagem.GetComponent<Text>().color = txt;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ativaDelay = true;
        }
    }
}
