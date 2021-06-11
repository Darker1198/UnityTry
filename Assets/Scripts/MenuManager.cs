using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private InputField nameFiedl;
    public string Name;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void OnStartButtonClick()
    {
        Name = nameFiedl.text;
        SceneManager.LoadScene("main");
    }
}
