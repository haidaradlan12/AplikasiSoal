using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuBurunghantu, MenuButton, MenuInformasi, MenuGuide;
    // Start is called before the first frame update
    void Start()
    {
        MenuBurunghantu.DOAnchorPos(new Vector2(0,0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void MenuKembali()
    {
        MenuBurunghantu.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void MenuInformasibutton()
    {
        MenuBurunghantu.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -1500), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    public void MenuGuidebutton()
    {
        MenuBurunghantu.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuButton.DOAnchorPos(new Vector2(0, -1500), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuGuide.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }

}
