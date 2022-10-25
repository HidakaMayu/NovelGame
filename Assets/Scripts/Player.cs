using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb = default;
    [SerializeField]float speed = 1.0f;
    float x, z;
    Vector3 kakoPos;
    // Start is called before the first frame update
    //[SerializeField] Text text;

    [SerializeField] GameObject canvas;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //text.text = "a";
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        Vector3 dir = Vector3.forward * z + Vector3.right * x;
        Vector3 idou =transform.position - kakoPos;
        kakoPos = transform.position;
        if(idou.magnitude > 0.01f)transform.rotation = Quaternion.LookRotation(idou);
        rb.velocity = dir.normalized * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
    }
}
