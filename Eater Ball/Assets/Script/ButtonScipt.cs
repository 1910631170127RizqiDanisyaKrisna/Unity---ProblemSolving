using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScipt : MonoBehaviour
{
    public void Goplay()
    {
        SceneManager.LoadScene("Menu Selection");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void P1()
    {
        SceneManager.LoadScene("Problem 1");
    }

    public void P2()
    {
        SceneManager.LoadScene("Problem 2");
    }
    public void P3()
    {
        SceneManager.LoadScene("Problem 3");
    }
    public void P4()
    {
        SceneManager.LoadScene("Problem 4");
    }
    public void P5()
    {
        SceneManager.LoadScene("Problem 5");
    }
    public void P6()
    {
        SceneManager.LoadScene("Problem 6");
    }
    public void P7()
    {
        SceneManager.LoadScene("Problem 7");
    }
    public void P8()
    {
        SceneManager.LoadScene("Problem 8");
    }
    public void P9()
    {
        SceneManager.LoadScene("Problem 9");
    }
}
