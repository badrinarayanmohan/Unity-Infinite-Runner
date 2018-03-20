using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {

    ScoreScript Health;

    private void OnTriggerEnter2D(Collider2D pts)
    {
        if (pts.tag == "Player")
        {
            Health = GameObject.Find("Main Camera").GetComponent<ScoreScript>();
            Health.IncreaseHealth(3);
            Destroy(this.gameObject);
        }
    }
}
