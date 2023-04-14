using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorBehaviourScript : MonoBehaviour
{
    int countDna;
    GameObject Dna;
    public float speed = 0.4f;
    private Vector2 dest = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
        Dna = GameObject.FindGameObjectWithTag("Dna");
        countDna = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition (p);

        if (Input.GetKey (KeyCode.UpArrow)) {
            dest = (Vector2)transform.position + Vector2.up;
            transform.eulerAngles = new Vector3 (0, 0, 90);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            dest = (Vector2)transform.position + Vector2.right;
            transform.eulerAngles = new Vector2 (0, 0);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            dest = (Vector2)transform.position + - Vector2.up;
            transform.eulerAngles = new Vector3 (0, 0, 270);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            dest = (Vector2)transform.position + Vector2.left;
            transform.eulerAngles = new Vector2 (0, 180);
        }
    }

    bool valid(Vector2 dir) {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast (pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Dna")
        {
            Destroy(other.gameObject);
            countDna++;
            Debug.Log(countDna);

            if (countDna == 4)
            {
               Application.LoadLevel("VenceuScene");
            }
        }
    }

    //Application.LoadLevel("VenceuScene");
}
