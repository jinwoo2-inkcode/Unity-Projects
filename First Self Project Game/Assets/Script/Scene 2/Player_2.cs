using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Player_2 : MonoBehaviour
{
    private int deathCount;
    public TextMeshProUGUI deathCountText;
    [SerializeField] Transform respawnPoint;
    [SerializeField] Transform TrapRespawnPoint;
    [SerializeField] trap_moving ballTrap;
    // Start is called before the first frame update
    void Start()
    {
        deathCount = 0;
        SetDeathCountText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Finish"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(other.gameObject.CompareTag("Trap"))
        {
            isDead();
            other.transform.position = TrapRespawnPoint.transform.position;
        }
    }

    void SetDeathCountText()
    {
        deathCountText.text = "Deaths: " + deathCount;
    }

    public void isDead()
    {
        deathCount++;
        SetDeathCountText();
        transform.position = respawnPoint.transform.position;
        ballTrap.transform.position = TrapRespawnPoint.transform.position;
        Physics.SyncTransforms();
        
    }

}
