using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

    [SerializeField]
    private Transform shootingPoint;

    [SerializeField]
    private GameObject _specialBulletPrefab;

    // Update is called once per frame
    /*    void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                // Instantiate(_bulletPrefab,
                //   transform.position, transform.rotation);
                Shoot();
            }
        }
        void Shoot()
        {
            // Instantiate the bullet
            GameObject bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);

        }*/

    public void FireBullets()
    {
        Instantiate(_bulletPrefab,
                shootingPoint.position, transform.rotation);

        /*Debug.Log("Normal attack coming!");*/
    }

    public void FireSpecialBullets()
    {
        Instantiate(_specialBulletPrefab,
                transform.position, transform.rotation);

        /*Debug.Log("Special attack coming!");*/
    }
}
