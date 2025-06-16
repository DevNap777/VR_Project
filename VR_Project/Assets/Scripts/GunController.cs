using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] Transform _muzzlePoint;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _bulletSpeed;

    // Grab Interactable�� Activate �ȿ� ���� �ϱ� ������ public���� ������ ��.
    public void Fire()
    {
        GameObject bullet = Instantiate(_bullet, _muzzlePoint.position, Quaternion.identity);
        _bullet.GetComponent<Rigidbody>().AddForce(_muzzlePoint.forward * _bulletSpeed, ForceMode.Impulse);
    }
}
