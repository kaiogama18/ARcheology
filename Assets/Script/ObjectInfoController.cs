using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInfoController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private Image descriptionIcon;
    [SerializeField] private GameObject panel;
    
    public void SetVisible(bool isVisible = true)
    {
        Debug.Log("Raycast hit: " + isVisible);
        panel.SetActive(isVisible);
    }
    public void SetObjectInfo(SOObjectInfo info)
    {
        titleText.text = info.title;
        descriptionText.text = info.description;
        descriptionIcon.sprite = info.icon;
    }
}
