using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is responsible for Diactive this gameobject after 8 Sec.
/// </summary>
public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody Rigidbody;

    private void OnEnable()
    {
        Invoke("DisableAfterDelay", 8);
    }

    void DisableAfterDelay()
    {
        Rigidbody.velocity = Vector3.zero;
        gameObject.SetActive(false);
    }
}
