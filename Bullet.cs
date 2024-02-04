using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.up * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Meteorite") {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
