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
        //GetComponent�� ���� ������Ʈ ���� �ִ� ��ũ��Ʈ�� ��ɸ� �����ü� ����, �ڽĵ� �ȵ�, TMP�� ���������� TMP�� �ִ� ������Ʈ �ȿ� �־�� ��
    }
    private void Start()
    {
        Score.scoreButton.onClick.AddListener(RefreshUI);
    }
    void RefreshUI()
    {
        Scoretext.text = Score.Score.ToString();
        //ToString �ϼ� �Ŀ��� () ���̱�
        //Scoretext.text = $"{Score}"; ������ $�� �ٿ��� �׳� �ؽ�Ʈ�� �ƴ� �Լ��� �Է��Ѱŷ� �ν���
    }
}