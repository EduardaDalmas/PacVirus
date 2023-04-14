using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dnaBehaviourScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.name == "Doutor") {
            Destroy (gameObject);
            {
                //Application.LoadLevel("VenceuScene");
            }
        }
    }
}
