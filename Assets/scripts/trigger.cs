using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Rigidbody player;
    public Vector3 scale = new Vector3(0.1f, 0.1f, 0.1f);
    public Vector3 eatlist;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == const_item.REWARDING)
        {
            //Destroy(other.gameObject);
            player.transform.localScale += scale;
            eatlist = other.transform.position;

        }

        if (other.tag == const_item.PUNISHMENT)
        {
            //Destroy(other.gameObject);
            player.transform.localScale -= scale;
            eatlist = other.transform.position;
        }
    }
}