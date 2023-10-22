using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("cambiarColor");


    }
    IEnumerator cambiarColor()
    {

        yield return new WaitForSeconds(1f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.red;
        yield return new WaitForSeconds(1.5f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
        yield return new WaitForSeconds(1f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.cyan;
        yield return new WaitForSeconds(1f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.black;
        yield return new WaitForSeconds(1f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.gray;
        yield return new WaitForSeconds(1.5f);
        GetComponent<Renderer>().material.color = UnityEngine.Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
