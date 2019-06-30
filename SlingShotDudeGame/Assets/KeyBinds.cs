using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBinds : MonoBehaviour
{

    private Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>(); 
    // Start is called before the first frame update
    void Start()
    {
        keys.Add("Up", KeyCode.Space);
        keys.Add("Down", KeyCode.s);
        keys.Add("Right", KeyCode.d);
        keys.Add("Left", KeyCode.a); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static KeyCode getKey(String keyName) {
        return keys[keyName];
    }
}
