using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is responsible for Logic of Item Spawning and Object Pooling for Apple ,Banana ,Cherry Items.
/// </summary>
public class ItemSpawner : MonoBehaviour
{
    public int AppleCount;
    public int bananaCount;
    public int CherryCount;

    [Space(8)]
    [SerializeField] Transform[] SpawnPosition;// positions of Spawn.

    [Space(8)]
    [SerializeField] GameObject[] AppleItems;
    [SerializeField] GameObject[] BananItems;
    [SerializeField] GameObject[] CherryItems;


    private void Start()
    {
        AppleCount = AppleItems.Length;
        bananaCount = BananItems.Length;
        CherryCount = CherryItems.Length;
    }

    //------------------------------------
    int i_Apple;
    public void SpawnApple()
    {
        Spawn(AppleItems, ref i_Apple, ref AppleCount);
    }
    //------------------------------------
    int i_Cherry;
    public void SpawnCherry()
    {
        Spawn(CherryItems, ref i_Cherry, ref CherryCount);
    }
    //------------------------------------
    int i_Banana;
    public void SpawnBanana()
    {
        Spawn(BananItems, ref i_Banana, ref bananaCount);
    }
    //------------------------------------

    void Spawn(GameObject[] item, ref int i_Increasement, ref int ItemCount)
    {
        if (i_Increasement != item.Length)
        {
            if (item[i_Increasement].activeSelf == false)
            {
                ItemCount -= 1;
                item[i_Increasement].SetActive(true);
                item[i_Increasement].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                item[i_Increasement].transform.position = RandomPosition();
                i_Increasement++;
            }
        }
    }

    int R;
    Vector3 RandomPosition()
    {
        R = Random.Range(0, 3);
        return SpawnPosition[R].position;
    }
}
