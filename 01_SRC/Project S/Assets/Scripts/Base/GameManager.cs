using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // UI
    public GameObject StoreUI;
    public StoreManager storeManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenStore()
    {
        StoreUI.SetActive(true);
    }



}
