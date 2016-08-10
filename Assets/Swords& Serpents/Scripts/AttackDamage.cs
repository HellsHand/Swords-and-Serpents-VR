using UnityEngine;
using System.Collections.Generic;

public class AttackDamage : MonoBehaviour {

    void OnTriggerEnter(Collider collided)
    {
        if (collided.tag == "Enemy")
        {
            collided.GetComponent<EnemyBehaviour>().Attacked(10);
        }
    }
}
