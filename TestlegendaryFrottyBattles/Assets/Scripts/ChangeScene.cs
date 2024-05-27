using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textActive;

    private void Start()
    {
        textActive.text = SceneManager.GetActiveScene().name;
    }

    public void ChangeSceneName(string name)
    {
        SceneManager.LoadScene(name);
    }
}
