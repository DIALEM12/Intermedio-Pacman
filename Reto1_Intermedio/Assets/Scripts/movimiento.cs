using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    public float speedRotation = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");
        float jumpinput = Input.GetAxis("Jump");

        Vector3 move = new Vector3(horizontalInput, jumpinput, verticalinput);
        move.Normalize();
        transform.position = transform.position + move * speed * Time.deltaTime;

        if (move != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(move), speedRotation * Time.deltaTime);
        }

    }
}
