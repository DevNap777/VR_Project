using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] Transform _muzzlePoint;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _bulletSpeed;

    // Grab Interactable의 Activate 안에 들어가야 하기 때문에 public으로 만들어야 함.
    public void Fire()
    {
        GameObject bullet = Instantiate(_bullet, _muzzlePoint.position, Quaternion.identity);
        _bullet.GetComponent<Rigidbody>().AddForce(_muzzlePoint.forward * _bulletSpeed, ForceMode.Impulse);
    }
}
