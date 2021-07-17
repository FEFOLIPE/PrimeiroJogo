using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pausar, menuOpcoes, menuControles, endGame;
    private bool gameOver;
    public GameObject prefabHazzard, prefabCoin, prefabBomba;
    private int randomRange, x;
    private Vector3 position, rotation;
    public AudioSource gameOverMusic, levelMusic;

    void Start()
    {
        StartCoroutine(SpawnHazzards());
        StartCoroutine(SpawnCoin());
        StartCoroutine(SpawnBomba());
    }

    private IEnumerator SpawnHazzards()
    {
        var hazzardToSpawn = Random.Range(1, 4);

        for (int i = 0; i < hazzardToSpawn; i++)
        {
            var x = Random.Range(-7, 7);
            var drag = Random.Range(0f, 2f);
            var hazzard = Instantiate(prefabHazzard, new Vector3(x, 20, 0), Quaternion.Euler(x, x, x));
            hazzard.GetComponent<Rigidbody>().drag = drag;

            yield return new WaitForSeconds(1f);

            yield return SpawnHazzards();
        }
        
    }

    private IEnumerator SpawnCoin()
    {
        var coinToSpawn = Random.Range(1, 4);

        for (int i = 0; i < coinToSpawn; i++)
        {
            var x = Random.Range(-7, 7);
            var drag = Random.Range(0f, 2f);
            var coin = Instantiate(prefabCoin, new Vector3(x, 20, 0), Quaternion.Euler(x, x, x));
            coin.GetComponent<Rigidbody>().drag = drag;

            yield return new WaitForSeconds(4f);

            yield return SpawnCoin();
        }
    }
    private IEnumerator SpawnBomba()
    {
        var bombaToSpawn = Random.Range(1, 4);

        for (int i = 0; i < bombaToSpawn; i++)
        {
            var x = Random.Range(-7, 7);
            var drag = Random.Range(0f, 2f);
            var bomba = Instantiate(prefabBomba, new Vector3(x, 20, 0), Quaternion.Euler(x, x, x));
            bomba.GetComponent<Rigidbody>().drag = drag;

            yield return new WaitForSeconds(2f);

            yield return SpawnBomba();
        }

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pausar();
        }
    }

    private bool Application_wantsToQuit()
    {
        throw new System.NotImplementedException();
    }

    public void GameOver()
    {
        endGame.SetActive(true);
        gameOverMusic.Play();
        levelMusic.Stop();
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        endGame.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1;
    }
    public void Pausar()
    {
        pausar.SetActive(true);
        Time.timeScale = 0;
    }
    public void Despausar()
    {
        pausar.SetActive(false);
        Time.timeScale = 1;
    }
    public void MenuOpcoes()
    {
        menuOpcoes.SetActive(true);
    }
    public void MenuOpcoesVoltar()
    {
        menuOpcoes.SetActive(false);
    }
    public void MenuControles()
    {
        menuControles.SetActive(true);
    }
    public void MenuControlesVoltar()
    {
        menuControles.SetActive(false);
    }
    
}
