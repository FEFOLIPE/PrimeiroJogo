using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public AudioSource coletarSound;
    public float forceMultiplier = 10f;
    public float maxForce = 10f;
    public GameManager gameManager;
    private Rigidbody rb;
    public TMPro.TextMeshProUGUI scoreText;
    private int coin;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        if (rb.velocity.magnitude <= maxForce)
        {
            rb.AddForce(new Vector3(horizontalInput * forceMultiplier, 0, 0));
            rb.AddForce(new Vector3(0, 0, verticalInput * forceMultiplier));
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazzard"))
        {
            Destroy(gameObject);
            gameManager.GameOver();
        }

        if(collision.gameObject.CompareTag("Bomba"))
            {
            Destroy(gameObject);
            gameManager.GameOver();
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            for (int c = 0; c < 1; c++)
            {
                coin++;
            }

            scoreText.text = coin.ToString();
            coletarSound.Play();

            if(coin >= 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); ;
            }

        }
    }
}
