using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is responsible for Shoot the Bullets using left click and object pooling for bullet.
/// </summary>
public class Player_ShootBullet : MonoBehaviour
{
    [SerializeField] Rigidbody[] _rigidbody;
    [SerializeField] Transform GunOrigin;
    [SerializeField] float BulletSpeed;

    int i;
    void FixedUpdate()
    {
        Shoot();
    }

    float shootingInterval = 0.15f;
    private float timer;
    void Shoot()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0) && timer >= shootingInterval)
        {
            timer = 0;
            print("Input.GetMouseButtonDown(0))");
            for (int i = 0; i < _rigidbody.Length; i++)
            {
                if (_rigidbody[i].gameObject.activeSelf == false)
                {
                    _rigidbody[i].gameObject.SetActive(true);
                    _rigidbody[i].transform.parent = null;
                    _rigidbody[i].transform.position = GunOrigin.position;
                    _rigidbody[i].AddForce(GunOrigin.forward * BulletSpeed * Time.fixedDeltaTime);
                    print("return");
                    return;
                }
            }
        }
    }

}
