using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class eat : MonoBehaviour
{
    public Transform playertransform;
    private Vector3 offset;
    public trigger check;
    private bool flag = false;
    // Start is called before the first frame update
    
    void Start()
    {
        //Debug.Log(check.eatlist);
        //Debug.Log(this.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (check.eatlist == this.transform.position)
            flag = true;
        if (flag)
            transform.position = playertransform.position;
    }
}
