using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserNameManager : MonoBehaviour
{
    public static UserNameManager UserNameInstance;
    // Start is called before the first frame update

    public string username;

    private void Awake()
    {
        if (UserNameInstance != null)
        {
            Destroy(gameObject);
            return;
        }

        UserNameInstance = this;
        DontDestroyOnLoad(gameObject);
    }
}
