using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    bool paused;
    [SerializeField]
    GameObject ObjetoPausa;

    // Start is called before the first frame update
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = MenuPausa();
        }
    }

    bool MenuPausa()
    {
        if (Time.timeScale == 0f)
        {
            ObjetoPausa.SetActive(false);
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            ObjetoPausa.SetActive(true);
            Time.timeScale = 0f;
            return (true);
        }
    }
}
