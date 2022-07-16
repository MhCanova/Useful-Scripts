using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSound : MonoBehaviour
{
    public static ManagerSonido unicainstancia;
    
    void Awake() 
    {
        if(ManagerSonido.unicainstancia == null)
        {
            ManagerSonido.unicainstancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}