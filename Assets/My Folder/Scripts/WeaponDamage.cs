using UnityEngine;

public class WeaponDamage : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collided)
    {
        if (collided.tag == "Enemy")
        {
            collided.GetComponent<EnemyBehavior>().HitBy(gameObject);
            collided.GetComponent<EnemyBehavior>().RecieveDamage(10);
        }
    }

}
