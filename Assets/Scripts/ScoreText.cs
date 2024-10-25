using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Scoretext;
    public ScoreButton Score;
    private void Awake()
    {
        Scoretext = GetComponent<TextMeshProUGUI>();
        //GetComponent는 같은 오브젝트 내에 있는 스크립트나 기능만 가져올수 있음, 자식도 안됨, TMP를 가져오려면 TMP가 있는 오브젝트 안에 넣어야 함
    }
    private void Start()
    {
        Score.scoreButton.onClick.AddListener(RefreshUI);
    }
    void RefreshUI()
    {
        Scoretext.text = Score.Score.ToString();
        //ToString 완성 후에는 () 붙이기
        //Scoretext.text = $"{Score}"; 에서는 $를 붙여야 그냥 텍스트가 아닌 함수를 입력한거로 인식함
    }
}