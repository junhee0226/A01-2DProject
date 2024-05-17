using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }

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
        // ���� ������ �������� ������ ����Ʈ�� �߰�
        itemList.Add(item);

        // ���� ������ �����ۿ� �̵� ��ũ��Ʈ �߰�
        item.AddComponent<ItemMove>();

        //���� ������ �����ۿ� �浹 ��ũ��Ʈ �߰�
        item.AddComponent<ItemCollider>();
    }
}
    
