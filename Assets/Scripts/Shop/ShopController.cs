using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShopController : MonoBehaviour
{
        [SerializeField] private List<DealData> _availableDeals;

        public DealData GetDeal(int dealId)
        {
            return _availableDeals.Find(x => x.InAppId == dealId);
        }
}
