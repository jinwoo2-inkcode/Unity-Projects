using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_moving : MonoBehaviour
{
    [SerializeField] float trap_speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * Time.deltaTime * trap_speed);
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
