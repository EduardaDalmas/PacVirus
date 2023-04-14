using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacdotBehaviourScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.name == "Doutor") {
            Destroy (gameObject);
        }
    }
}
