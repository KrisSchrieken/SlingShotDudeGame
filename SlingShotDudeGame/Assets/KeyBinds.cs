using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBinds : MonoBehaviour
{

    private static Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>(); 
    // Start is called before the first frame update
    void Start()
    {
        keys.Add("Up", KeyCode.Space);
        keys.Add("Down", KeyCode.S);
        keys.Add("Right", KeyCode.D);
        keys.Add("Left", KeyCode.A); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static KeyCode getKey(string keyName) {
        return keys[keyName];
    }
}
