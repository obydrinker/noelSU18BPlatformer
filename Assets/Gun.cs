using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float rotationspeed = 5;
    public GameObject bullet;
    public Transform spawnPoint;
   

    public float bulletSpeed = 10;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        GunMovement();
        FireGun();
    }

    void GunMovement()
    {
        if (Input.GetKey(KeyCode.B))
        {
            transform.Rotate(0f, 0f, rotationspeed);

        }
        if (Input.GetKey(KeyCode.M))
        {
            transform.Rotate(0f, 0f, -rotationspeed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            transform.rotation = Quaternion.identity;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
            transform.rotation = Quaternion.identity;
        }
    }
    void FireGun()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            GameObject newbullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            if (transform.localScale.x > 0)
            {
            newbullet.GetComponent<Rigidbody2D>().velocity = (newbullet.transform.right * bulletSpeed);

            }
            else if ( transform.localScale.x < 0)
            {
                newbullet.GetComponent<Rigidbody2D>().velocity = (-newbullet.transform.right * bulletSpeed);
            }


            //addforce behöver rigidbody 
            //vector
            //vilket gameobject

        }
        // fuck u noel <3
    }

}
