using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public static ItemController Instance { get; private set; }

    private List<GameObject> itemList = new List<GameObject>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void RandomItem(GameObject item)
    {
        itemList.Add(item);

        // �����ۿ� �̵� ��ũ��Ʈ �߰�
        item.AddComponent<ItemMove>();
    }       

    public virtual void ItemUse() 
    {

    }
}
