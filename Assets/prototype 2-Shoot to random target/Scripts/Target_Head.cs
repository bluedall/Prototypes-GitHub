using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is responsible for Disable this Gameobject after Collider with Bullet.
/// </summary>
public class Target_Head : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
        }
    }
}
