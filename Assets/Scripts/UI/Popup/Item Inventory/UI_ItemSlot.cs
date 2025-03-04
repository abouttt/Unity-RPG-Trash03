using UnityEngine;
using UnityEngine.EventSystems;

public class UI_ItemSlot : UI_BaseSlot, IDropHandler
{
    enum Texts
    {
        CountText,
    }

    enum CooldownImages
    {
        CooldownImage,
    }

    public ItemType ItemType { get; private set; }
    public int Index { get; private set; }

    protected override void Init()
    {
        base.Init();

        BindText(typeof(Texts));
        Bind<UI_CooldownImage>(typeof(CooldownImages));
    }

    private void Start()
    {
        Refresh();
    }

    public void Setup(ItemType itemType, int index)
    {
        ItemType = itemType;
        Index = index;
    }

    public void Refresh()
    {
        var item = Player.ItemInventory.GetItem<Item>(ItemType, Index);

        if (item != null)
        {
            if (ObjectRef != item)
            {
                if (HasObject)
                {
                    Clear();
                }

                SetObject(item, item.Data.ItemImage);

                if (item is IStackableItem stackable)
                {
                    stackable.StackChanged += RefreshCountText;
                }

                if (item.Data is ICooldownable cooldownable)
                {
                    Get<UI_CooldownImage>((int)CooldownImages.CooldownImage).SetCooldown(cooldownable.Cooldown);
                }

                RefreshCountText();
            }
        }
        else
        {
            Clear();
        }
    }

    protected override void Clear()
    {
        if (ObjectRef is Item item)
        {
            if (item is IStackableItem stackable)
            {
                stackable.StackChanged -= RefreshCountText;
            }

            if (item.Data is ICooldownable)
            {
                Get<UI_CooldownImage>((int)CooldownImages.CooldownImage).Clear();
            }
        }

        base.Clear();
        GetText((int)Texts.CountText).gameObject.SetActive(false);
    }

    private void RefreshCountText()
    {
        if (ObjectRef is IStackableItem stackable && stackable.Count > 1)
        {
            GetText((int)Texts.CountText).gameObject.SetActive(true);
            GetText((int)Texts.CountText).text = stackable.Count.ToString();
        }
        else
        {
            GetText((int)Texts.CountText).gameObject.SetActive(false);
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        Managers.UI.Get<UI_ItemInventoryPopup>().SetTop();
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        Managers.UI.Get<UI_TooltipTop>().ItemTooltip.SetSlot(this);
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        Managers.UI.Get<UI_TooltipTop>().ItemTooltip.SetSlot(null);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        if (!CanPointerUp())
        {
            return;
        }

        if (Managers.UI.IsShowed<UI_ShopPopup>())
        {
            NPCShop.SellItem(ItemType, Index);
        }
        else
        {
            var item = ObjectRef as Item;
            if (item is IUsableItem usable)
            {
                usable.Use(Player.ItemInventory, item);
            }
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == gameObject)
        {
            return;
        }

        if (eventData.pointerDrag.TryGetComponent<UI_BaseSlot>(out var otherSlot))
        {
            switch (otherSlot.SlotType)
            {
                case SlotType.Item:
                    OnDropItemSlot(otherSlot as UI_ItemSlot);
                    break;
                case SlotType.Equipment:
                    OnDropEquipmentSlot(otherSlot as UI_EquipmentSlot);
                    break;
                default:
                    break;
            }
        }
    }

    private void OnDropItemSlot(UI_ItemSlot otherItemSlot)
    {
        var otherItem = otherItemSlot.ObjectRef as Item;

        if (!HasObject && otherItem is IStackableItem otherStackable && otherStackable.Count > 1)
        {
            var splitPopup = Managers.UI.Show<UI_ItemSplitPopup>();
            splitPopup.SetEvent(() =>
                Player.ItemInventory.SplitItem(ItemType, otherItemSlot.Index, Index, splitPopup.Count),
                $"[{otherItem.Data.ItemName}] 아이템 나누기", 1, otherStackable.Count);
        }
        else
        {
            Player.ItemInventory.MoveItem(ItemType, otherItemSlot.Index, Index);
        }
    }

    private void OnDropEquipmentSlot(UI_EquipmentSlot otherEquipmentSlot)
    {
        var otherEquipmentItem = otherEquipmentSlot.ObjectRef as EquipmentItem;

        if (HasObject)
        {
            var equipmentItem = ObjectRef as EquipmentItem;

            if (equipmentItem.EquipmentData.EquipmentType != otherEquipmentItem.EquipmentData.EquipmentType)
            {
                return;
            }

            if (equipmentItem is not IUsableItem usable)
            {
                return;
            }

            usable.Use(Player.ItemInventory, equipmentItem);
        }
        else
        {
            Player.ItemInventory.SetItem(otherEquipmentItem.Data, Index);
            Player.EquipmentInventory.Unequip(otherEquipmentSlot.EquipmentType);
        }
    }
}
