using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintData : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI Number;

    public void GetDataButtan()
    {
        Debug.LogError(Number.text);
    }
}
