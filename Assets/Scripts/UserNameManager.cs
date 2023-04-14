using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserNameManager : MonoBehaviour
{
    public static UserNameManager UserNameInstance;
    // Start is called before the first frame update

    private void Awake()
    {
        UserNameInstance = this;
        DontDestroyOnLoad(gameObject);
    }
}
