using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenuHandler : MonoBehaviour
{
    public TMP_InputField userNameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GetUserName()
    {
        UserNameManager.UserNameInstance.username = userNameInput.text;
    }

}
