using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_mover : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vertic = Input.GetAxis("Vertical");

        transform.Translate(horiz * speed * Time.deltaTime, 0, vertic * speed * Time.deltaTime);
        

    }
}
