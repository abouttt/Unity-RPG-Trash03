using System.Collections.Generic;
using UnityEngine;
using AYellowpaper.SerializedCollections;

public class FieldItem : Interactive
{
    public IReadOnlyDictionary<ItemData, int> Items => _items;

    [SerializeField]
    private bool _destroyWhenEmpty = true;

    [SerializeField]
    private SerializedDictionary<ItemData, int> _items;

    private void Start()
    {
        Util.InstantiateMinimapIcon("FieldItemMinimapIcon.sprite", "������", transform);

        if ((_items == null || _items.Count == 0) && _destroyWhenEmpty)
        {
            Managers.Resource.Destroy(gameObject);
        }
    }

    public override void Interaction()
    {
        base.Interaction();

        Managers.UI.Show<UI_LootPopup>().SetFieldItem(this);
    }

    public void AddItem(ItemData itemData, int count)
    {
        if (count == 0)
        {
            return;
        }

        if (!_items.ContainsKey(itemData))
        {
            _items.Add(itemData, 0);
        }

        _items[itemData] += count;
    }

    public virtual void RemoveItem(ItemData itemData, int count)
    {
        if (count == 0)
        {
            return;
        }

        if (_items.ContainsKey(itemData))
        {
            _items[itemData] -= count;

            if (_items[itemData] <= 0)
            {
                _items.Remove(itemData);
            }
        }

        if (_items.Count == 0 && _destroyWhenEmpty)
        {
            Managers.Resource.Destroy(gameObject);
        }
    }
}
