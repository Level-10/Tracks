using UnityEngine;
using UnityEngine.UI;

public class UI_Items : MonoBehaviour
{
    [SerializeField] Button button = null;

    void Start()
    {
        Init();
    }

    void Update()
    {
        
    }

    void Init()
    {
        button = GetComponent<Button>();
    }

    void ItemBehaviour()
    {
        
    }
}
