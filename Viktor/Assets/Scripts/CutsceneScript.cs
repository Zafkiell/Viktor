using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneScript : MonoBehaviour
{

    [SerializeField]
    GameObject EndCard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.name == "CameraInicial") transform.position = Vector3.Lerp(transform.position, new Vector3(1.7f, 0.8f, 2.4f), 0.2f * Time.deltaTime);
        if (this.name == "CameraFinal")
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(9f, 37f, 373.24f), 0.05f * Time.deltaTime);
            Invoke("Fim", 14f);
        }
    }

    void Fim()
    {
        EndCard.SetActive(true);
        StartCoroutine(Fade());
        Invoke("TrocaTela", 15f);
    }

    IEnumerator Fade()
    {
        Image fade = GameObject.Find("TelaFinal").GetComponent<Image>();
        Color atual = fade.color;
        while (fade.color.a < 1)
        {
            atual.a += Time.deltaTime;
            fade.color = atual;
            yield return null;
        }
    }

    void TrocaTela()
    {
        SceneManager.LoadScene("Creditos");
    }
}
