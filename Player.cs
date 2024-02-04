using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points = 0;
    public GameObject bullet;
    public Transform shoot;
    public float shootInterval = 1f;
    public float shootTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        Move();
        Shoot();
    }
    void Move() {
        Vector2 pos = Input.mousePosition;
        Vector2 converted_pos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = converted_pos;
    
    }
    void Shoot(){
        shootTimer-= Time.deltaTime;
        if (shootTimer <= 0){
            Instantiate(bullet, shoot.position, shoot.rotation);
            shootTimer = shootInterval;
        }
    }
}
