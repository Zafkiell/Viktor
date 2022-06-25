using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonoScript : MonoBehaviour
{
    bool podeAndar = false;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Carinho", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (podeAndar)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(2.19f, 1.05f, 4f), 0.2f * Time.deltaTime);
            Destroy(gameObject, 3f);
        }
    }

    void Carinho()
    {
        GetComponent<Animator>().Play("Carinho");
        Invoke("Andar", 11f);
    }
    void Andar()
    {
        transform.position = new Vector3(2.19f, 1.05f, 0);
        transform.rotation = Quaternion.Euler(0,0,0);
        GetComponent<Animator>().Play("Andando");
        podeAndar = true;
    }
}
