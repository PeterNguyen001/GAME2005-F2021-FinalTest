using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadScence(string name)
    {
        SceneManager.LoadScene(name);
    }
}
