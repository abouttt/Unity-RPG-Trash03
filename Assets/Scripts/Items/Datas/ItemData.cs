using UnityEngine;

public abstract class ItemData : ScriptableObject
{
    [field: SerializeField]
    public string ItemId { get; private set; }

    [field: SerializeField]
    public string ItemName { get; private set; }

    [field: SerializeField]
    public Sprite ItemImage { get; private set; }

    [field: SerializeField, ReadOnly]
    public ItemType ItemType { get; protected set; }

    [field: SerializeField]
    public ItemQuality ItemQuality { get; private set; }

    [field: SerializeField, TextArea]
    public string Description { get; private set; }

    [field: SerializeField]
    public bool CanSell { get; private set; } = true;

    [field: SerializeField]
    public int BuyPrice { get; private set; }

    [field: SerializeField]
    public int SellPrice { get; private set; }

    public abstract Item CreateItem();

    public bool Equals(ItemData other)
    {
        if (other == null)
        {
            return false;
        }

        if (GetType() != other.GetType())
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return ItemId.Equals(other.ItemId);
    }
}
