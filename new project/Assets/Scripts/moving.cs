using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] Player player;
    //[SerializeField] GameObject playerObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Wall"))
    //     {
    //         speed = speed * -1;
    //     }
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            speed = speed * -1;
        }

        if(other.gameObject.CompareTag("Player"))
        {
            player.isDead();
            
        }
    }

}
