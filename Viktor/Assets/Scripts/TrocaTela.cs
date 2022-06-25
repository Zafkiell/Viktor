using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaTela : MonoBehaviour
{
    [SerializeField]
    GameObject MenuPopUp,LoadingPopUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Troca(string tela)
    {
        if (tela == "Tela1")
        {
            GameObject.Find("MusicaFundo").GetComponent<AudioSource>().Stop();
        }
        SceneManager.LoadScene(tela);
        LoadingPopUp.SetActive(true);
    }

    public void Sair()
    {
        MenuPopUp.SetActive(true);
    }

    public void Volta()
    {
        MenuPopUp.SetActive(false);
    }

    public void Desliga()
    {
        Application.Quit();
    }
}
