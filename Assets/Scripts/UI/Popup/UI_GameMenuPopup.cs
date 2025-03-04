using UnityEngine;

public class UI_GameMenuPopup : UI_Popup
{
    enum Buttons
    {
        ItemInventoryButton,
        EquipmentInventoryButton,
        SkillTreeButton,
        QuestButton,
        ResetPopupPositionButton,
        GameOptionButton,
        MainMenuButton,
        ExitButton,
        CloseButton,
    }

    protected override void Init()
    {
        base.Init();

        BindButton(typeof(Buttons));

        GetButton((int)Buttons.ItemInventoryButton).onClick.AddListener(() =>
        {
            Managers.UI.Show<UI_ItemInventoryPopup>();
            Managers.UI.Close<UI_GameMenuPopup>();
        });

        GetButton((int)Buttons.EquipmentInventoryButton).onClick.AddListener(() =>
        {
            Managers.UI.Show<UI_EquipmentInventoryPopup>();
            Managers.UI.Close<UI_GameMenuPopup>();
        });

        GetButton((int)Buttons.SkillTreeButton).onClick.AddListener(() =>
        {
            Managers.UI.Show<UI_SkillTreePopup>();
            Managers.UI.Close<UI_GameMenuPopup>();
        });

        GetButton((int)Buttons.QuestButton).onClick.AddListener(() =>
        {
            Managers.UI.Show<UI_QuestPopup>();
            Managers.UI.Close<UI_GameMenuPopup>();
        });

        GetButton((int)Buttons.ResetPopupPositionButton).onClick.AddListener(() =>
        {
            foreach (Transform child in Managers.UI.GetRoot(UIType.Popup))
            {
                var popup = child.GetComponent<UI_Popup>();
                popup.PopupRT.anchoredPosition = popup.DefaultPosition;
            }
        });

        GetButton((int)Buttons.GameOptionButton).onClick.AddListener(() =>
        {
            Managers.UI.Show<UI_GameOptionPopup>();
            Managers.UI.Close<UI_GameMenuPopup>();
        });

        GetButton((int)Buttons.MainMenuButton).onClick.AddListener(() =>
        {
            Managers.Scene.LoadScene(SceneType.MainMenuScene);
        });

        GetButton((int)Buttons.ExitButton).onClick.AddListener(() =>
        {
            Managers.Data.Save();
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        });

        GetButton((int)Buttons.CloseButton).onClick.AddListener(Managers.UI.Close<UI_GameMenuPopup>);
    }

    private void Start()
    {
        Managers.UI.Register<UI_GameMenuPopup>(this);
    }
}
