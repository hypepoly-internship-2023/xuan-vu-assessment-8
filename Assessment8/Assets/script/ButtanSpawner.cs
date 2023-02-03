using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtanSpawner : MonoBehaviour
{
    [SerializeField] protected Transform Level;
    [SerializeField] protected Transform LevelFame;
    [SerializeField] protected TextMeshProUGUI Number;
    [SerializeField] protected List<Transform> star;
    private void Awake()
    {
        for (int i = 0; i < 100; i++)
        {
            spawn(i);
        }
    }
    void spawn(int index)
    {
        CreateStar();
        Number.text = index.ToString();
        Transform newLevel = Instantiate(Level);
        newLevel.transform.SetParent(LevelFame,false);
        newLevel.gameObject.SetActive(true);
    }
    void CreateStar()
    {
        int random = Random.Range(0, 4);
        {
            for (int i = 0; i < random; i++)
            {
                star[i].transform.gameObject.SetActive(true);
            }
            for (int i = 2; i >= random; i--)
            {
                star[i].transform.gameObject.SetActive(false);
            }
        }
    }
}
