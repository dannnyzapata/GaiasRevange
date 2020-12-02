using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DentedPixel; 

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI tipText;
    public CanvasGroup alphaCanvas;
    public string[] tips;
    public GameObject loadingScree;
    public GameObject bar;
    public int time;



    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        StartCoroutine(GenereteTip());
        
        AnimarBar();

    }
    public int tipCount;
    public IEnumerator GenereteTip()
    {

        tipCount = Random.Range(0, tips.Length);
        tipText.text = tips[tipCount];
        while (loadingScree.activeInHierarchy)
        {
            yield return new WaitForSeconds(3f);
            LeanTween.alphaCanvas(alphaCanvas, 0, 0.5f);
            yield return new WaitForSeconds(0.5f);
            tipCount++;
            if (tipCount > tips.Length)
            {
                tipCount = 0;
            }
            tipText.text = tips[tipCount];
            LeanTween.alphaCanvas(alphaCanvas, 1, 0.5f);
        }


    }
    
    public void AnimarBar()
    {
        LeanTween.scaleX(bar, 1, time);
    }

  
}
