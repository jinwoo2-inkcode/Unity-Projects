using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private int count;
    private int deathCount;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI deathCountText;
    [SerializeField] Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        deathCount = 0;
        SetCountText();
        SetDeathCountText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }

        if(other.gameObject.CompareTag("Finish"))
        {
            if(count == 4)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                isDead();
            }
        }
    }

    void SetCountText()
	{
		countText.text = "Coins Left: " + (4 - count);
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
        Physics.SyncTransforms();
    }

}
