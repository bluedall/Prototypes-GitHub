using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/// <summary>
/// This class is responsible for Item Spawning from Ui side, Spawn Item After click on Specific Item Button.
/// </summary>
public class Ui_ItemSpawner : MonoBehaviour
{
    [SerializeField] ItemSpawner itemSpawner;
    [Space(8)]
    [Header("Properties of TextMeshPro Component")]
    [SerializeField] TMP_Text Text_AppleCount;
    [SerializeField] TMP_Text Text_BananaCount;
    [SerializeField] TMP_Text Text_CherryCount;
    public void AppleSpawn()//----------this method called in UnityEvent (Ui Button).
    {
        itemSpawner.SpawnApple();
        Text_AppleCount.text = itemSpawner.AppleCount.ToString();
    }
    public void BananaSpawn()//----------this method called in UnityEvent (Ui Button).
    {
        itemSpawner.SpawnBanana();
        Text_BananaCount.text = itemSpawner.bananaCount.ToString();
    }
    public void CherrySpawn()//----------this method called in UnityEvent (Ui Button).
    {
        itemSpawner.SpawnCherry();
        Text_CherryCount.text = itemSpawner.CherryCount.ToString();
    }
}
