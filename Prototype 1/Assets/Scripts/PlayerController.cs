using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;

    public float turnsped = 35f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputZ = Input.GetAxis("Vertical");

        float inputX = Input.GetAxis("Horizontal");

        transform.Translate(inputZ * speed * Vector3.forward * Time.deltaTime);

        transform.Rotate(inputX * turnsped * Vector3.up * Time.deltaTime);
    }
}
