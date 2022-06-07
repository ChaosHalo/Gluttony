using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveThePlayer();
    }

    void MoveThePlayer()
    {
        float h = Input.GetAxis(const_item.HORIZONTAL);
        float v = Input.GetAxis(const_item.VERTICAL);
        rb.AddForce(new Vector3(h, 0, v) * speed);
    }
}
