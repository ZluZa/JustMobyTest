using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DealData", menuName = "Shop/DealData")]

public class DealData : ScriptableObject
{
    //Для тестового задания нет смысла делать целую систему инаппов, но по хорошему сюда бы айдишник покупки
    //А вообще по хорошему все не через скриптабл обджекты делать, а через конфигирируемые извне конфиги, но мы упрощаем
    [SerializeField] private int _inAppId;
    [SerializeField] private int _discountAmount;
    [SerializeField] private List<DealItem> _resourcesToSell;
    [SerializeField] private Sprite _dealImage;
    [SerializeField] private string _dealTitle;
    [SerializeField] private string _dealAdditionalText;

    
    public List<DealItem> ResourcesToSell => _resourcesToSell;
    public int InAppId => _inAppId;
    public Sprite DealImage => _dealImage;
    public string DealTitle => _dealTitle;
    public string DealAdditionalText => _dealAdditionalText;

    [Serializable]
    public struct DealItem
    {
        public ResourceData data;
        public int amount;
    }
}
