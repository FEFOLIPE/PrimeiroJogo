using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menuControles, menuOpcoes;
    public void PlayGame()
    {
        SceneManager.LoadScene("prefase1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }
    public void ProximaFase1()
    {
        SceneManager.LoadScene("level01");
    }
    public void ProximaFase2()
    {
        SceneManager.LoadScene("level02");
    }
    public void ProximaFase3()
    {
        SceneManager.LoadScene("level03");
    }
    public void MenuControles()
    {
        menuControles.SetActive(true);
    }
    public void MenuControlesVoltar()
    {
        menuControles.SetActive(false);
    }
    public void MenuOpcoes()
    {
        menuOpcoes.SetActive(true);
    }
    public void MenuOpcoesVoltar()
    {
        menuOpcoes.SetActive(false);
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
