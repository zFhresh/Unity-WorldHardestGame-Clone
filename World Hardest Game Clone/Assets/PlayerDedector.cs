using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDedector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Debug.Log("Your Lose");
        }
    }
}
