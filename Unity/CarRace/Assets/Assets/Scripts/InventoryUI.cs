//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventory;
    public GameObject inventoryEkran;
    //GameObject inventory = GameObject.Find("Inventory");
    ManaBar manaBar;
    //Inventory inventory;
    //var temp = GameObject.Find("Inventory");
    //public var a = GameObject.Invetory;
    
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallBack += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateUI()
    {
        Debug.Log("UPDATING UI");
    }

}
