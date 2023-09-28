using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "bullet")
        {
            Vector3 pos = transform.position;

            pos.x = Random.Range(-5f, 5f);
            
            transform.position = pos;
        }
    }
}
