using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcoolBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.name == "Doutor") {
            Destroy (gameObject);
            {
                //Application.LoadLevel("VenceuScene");
            }
        }
    }
}
