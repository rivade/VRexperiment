using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    Transform barrelPoint;

    public void PullTrigger()
    {
        Instantiate(bulletPrefab, barrelPoint.position, barrelPoint.rotation);
    }
}
