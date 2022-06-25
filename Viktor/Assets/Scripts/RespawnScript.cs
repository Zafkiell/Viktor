using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    Vector3 checkpointPos;
    Quaternion checkpointRot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MarcaCheckpoint()
    {
        checkpointPos = transform.position;
        checkpointRot = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Morte" || other.tag == "Water")
        {
            transform.position = checkpointPos;
            transform.rotation = checkpointRot;
            GameObject.Find("AtivaAgua").GetComponent<AguaScript>().rodaAgua = false;
            if(GameObject.Find("Agua") !=null ) GameObject.Find("Agua").transform.position = new Vector3(3.6f, 26f, 354.5f);
            GameObject.Find("AtivaAgua").GetComponent<AguaScript>().tocou = false;
        }

        if (other.tag == "Water") GameObject.Find("SomVigaAgua").GetComponent<AudioSource>().Play();
    }

    [System.Serializable]
    public class ArquivoSalvo
    {
        public float jogadorPos;
        public float jogadorRot;
    }

    public string Salva(ArquivoSalvo objeto)
    {
        string save;
        save = JsonUtility.ToJson(objeto);
        return save;
    }

    public ArquivoSalvo Load(string save)
    {
        ArquivoSalvo objeto;
        objeto = JsonUtility.FromJson<ArquivoSalvo>(save);
        return objeto;
    }
}
