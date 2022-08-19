using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject Uimanager;
    [SerializeField] private GameObject GameManager;
    public void GamePaly()
    {
        Uimanager.SetActive(false);
        GameManager.SetActive(true);

    }

    public void ExitButton()
    {
        Application.Quit();
    }

}
