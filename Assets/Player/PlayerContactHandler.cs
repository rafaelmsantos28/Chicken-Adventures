using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerContactHandler : MonoBehaviour
{

    public string nextLevelName = "Level1";
    public Image itemImage;

    public PlayerAudioController audioController;

    bool canWinLevel = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Destroy(collision.gameObject);
            itemImage.color = Color.white;
            canWinLevel = true;
            audioController.PlayGetItem();
        }

        if (collision.gameObject.CompareTag("FinalPoint"))
        {
            if (canWinLevel)
            {
                SceneManager.LoadScene(nextLevelName);
            } else
            {
                
            }
        }
    }
}
