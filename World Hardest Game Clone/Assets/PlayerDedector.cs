using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDedector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            transform.position = new Vector3(-10.3500004f, -0.519999981f, -0.620000005f);
        }
    }
}
