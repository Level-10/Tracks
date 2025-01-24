using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static T instance = null;
    public static T Instance => instance;

    protected virtual void Awake()
    {
        Init();
    }

    protected virtual void Start()
    {
        //Init();
    }

    void Init()
    {
        // Check if already have an instance
        if (instance)
        {
            // If yes destroy it
            Destroy(this);
            return;
        }
        // If not create it
        // "this as T" means cast this to the Template needed
        instance = this as T;
        // Name will adapt when Singleton will be used
        instance.name += $"[{GetType().Name}]";
    }
}
