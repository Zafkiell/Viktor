using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SobeCreditos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 5f * Time.deltaTime, 0);
        Invoke("TrocaTela", 63f);
    }

    void TrocaTela()
    {
        SceneManager.LoadScene("Menu");
    }
}
