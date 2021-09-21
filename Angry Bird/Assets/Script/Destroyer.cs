using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroyer : MonoBehaviour
{
     public UnityAction<GameObject> OnEnemyDestroyed = delegate { };

    void OnTriggerEnter2D(Collider2D col)
    {
        string tag = col.gameObject.tag;
        if (tag == "Bird" || tag == "Obstacle")
        {
            Destroy(col.gameObject);
        }

        if (tag == "Enemy")
        {
            OnEnemyDestroyed(col.gameObject);
            Destroy(col.gameObject);
        }
    }
}
