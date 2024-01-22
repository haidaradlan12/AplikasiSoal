using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonQwerty : MonoBehaviour
{
    public GameObject Nyawa1, Nyawa2, Nyawa3;
    private int benarnya, salahnya;
    public int quizindex;
    public RectTransform PopUpNext, PopUpGame;
    public AudioSource audiobenar, audiosalah;
    // Update is called once per frame
    void Start()
    {
        PopUpGame.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        PopUpNext.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
    }
    void Update()
    {
        if (salahnya > 2)
        {
            PopUpGame.DOAnchorPos(new Vector2(0, 0), 1.0f);
        }
        else if (salahnya == 1)
        {
            Nyawa1.SetActive(false);
            Nyawa2.SetActive(true);
            Nyawa3.SetActive(true);
            PopUpGame.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        }
        else if (salahnya == 2)
        {
            Nyawa1.SetActive(false);
            Nyawa2.SetActive(false);
            Nyawa3.SetActive(true);
            PopUpGame.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
            audiosalah.Play();
        }
        else
        {
            Nyawa1.SetActive(true);
            Nyawa2.SetActive(true);
            Nyawa3.SetActive(true);
            PopUpGame.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        }

        if (benarnya == quizindex)
        {
            PopUpNext.DOAnchorPos(new Vector2(0, 0), 1.0f);
        }
        else if ((benarnya+1) == quizindex)
        {
            audiobenar.Play();
            PopUpNext.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        }
        else
        {
            PopUpNext.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        }
    }
    public void Salah()
    {
        salahnya = salahnya + 1;
    }
    public void Benar()
    {
        benarnya = benarnya + 1;
    }
}
