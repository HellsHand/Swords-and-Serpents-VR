using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    TextMesh textMesh;

    private EnemySpawner spawn;
    private int hitpoints;
    private int dodgeChance;

    void Start()
    {
        textMesh = GameObject.Find("DialogBox").GetComponent<TextMesh>();
        dodgeChance = 15;
        hitpoints = 10;
    }

    public void DeathStrike()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        spawn.RemoveEnemy(this);
    }

    public void SetSpawner(EnemySpawner spawner)
    {
        spawn = spawner;
        spawn.AddEnemy(this);
    }

    private void RecieveDamage(int damage)
    {
        hitpoints -= damage;
        if (hitpoints <= 0)
        {
            DeathStrike();
        }
    }

    private void MissedHit()
    {
        textMesh.text = "Missed Me!" + gameObject.name;
    }

    public void Attacked(int damage)
    {
        int random = Random.Range(0, 100);
        if (random > dodgeChance)
        {
            RecieveDamage(damage);
        }
        else
        {
            MissedHit();
        }
    }
}
