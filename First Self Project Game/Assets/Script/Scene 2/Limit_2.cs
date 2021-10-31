using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit_2 : MonoBehaviour
{
    [SerializeField] Player_2 player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player_2"))
        {
            player.isDead();
        }
    }

}
