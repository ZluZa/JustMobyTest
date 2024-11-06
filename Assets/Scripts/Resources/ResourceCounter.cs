using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceCounter : MonoBehaviour
{
    [SerializeField] private Image _resourceImage;
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Button _buyResourcesButton;

    public void Initialize(ResourceData data, Action<int> buyWindowEvent)
    {
        if (data.ResourceSprite != null)
            _resourceImage.sprite = data.ResourceSprite;
        if (_buyResourcesButton != null)
            _buyResourcesButton.onClick.AddListener(() => buyWindowEvent?.Invoke(data.ItemId));
    }

    public void UpdateCount(int amount)
    {
        _counterText.SetText(amount.ToString());
    }
}