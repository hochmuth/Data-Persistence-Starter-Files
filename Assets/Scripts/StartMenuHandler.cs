using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartMenuHandler : MonoBehaviour
{
    public TMP_InputField usernameInput;

    // Start is called before the first frame update
    void Start()
    {
        usernameInput.onEndEdit.AddListener(delegate{ProcessInput(usernameInput);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void ProcessInput(TMP_InputField input)
    {
        MainManager.ManagerInstance.username = input.text;
    }

}
