using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] private Transform weapon;
    
    private Transform _target;

    private void Start()
    {
        _target = FindObjectOfType<EnemyMover>().transform;
    }

    private void Update()
    {
        AimWeapon();
    }

    private void AimWeapon()
    {
        weapon.LookAt(_target);
    }
}
