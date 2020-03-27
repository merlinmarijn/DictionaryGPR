using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public enum ItemTypes {Wood,Stone,Iron,Coins};
    public ItemTypes items;
    public Dictionary<ItemTypes, int> inventory = new Dictionary<ItemTypes, int>();
    public List<TextMeshProUGUI> textmesh;
    // Start is called before the first frame update
    void Start()
    {
        inventory.Add(ItemTypes.Wood, 0);
        inventory.Add(ItemTypes.Stone, 0);
        inventory.Add(ItemTypes.Iron, 0);
        inventory.Add(ItemTypes.Coins, 0);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGui(ItemTypes.Wood, textmesh[0]);
        UpdateGui(ItemTypes.Stone, textmesh[1]);
        UpdateGui(ItemTypes.Iron, textmesh[2]);
        UpdateGui(ItemTypes.Coins, textmesh[3]);
        //ADD ITEM COUNT
        if (Input.GetKeyDown(KeyCode.F))
        {
            PickupItem(ItemTypes.Wood, Random.Range(1, 10));
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            PickupItem(ItemTypes.Stone, Random.Range(1, 5));
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            PickupItem(ItemTypes.Iron, Random.Range(1, 3));
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            PickupItem(ItemTypes.Coins, Random.Range(1, 100));
        }
        //RESET ITEM COUNT
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ResetItem(ItemTypes.Wood);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            ResetItem(ItemTypes.Stone);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            ResetItem(ItemTypes.Iron);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            ResetItem(ItemTypes.Coins);
        }

    }


    void PickupItem(ItemTypes i, int Count)
    {
        inventory[i] = inventory[i] += Count;
    }
    void UpdateGui(ItemTypes i, TextMeshProUGUI T)
    {
        T.text = i+": "+inventory[i].ToString();
    }
    void ResetItem(ItemTypes i)
    {
        inventory[i] = 0;
    }
}
