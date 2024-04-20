using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] resourceTexts;
    public int moneyCount;
    public int woodCount;
    public int stoneCount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextUpdates();
    }

    private void TextUpdates()
    {
        // 0 = Money, 1 = Wood, 2 = Stone
        resourceTexts[0].text = resourceTexts[0].name + ": " + moneyCount;
        resourceTexts[1].text = resourceTexts[1].name + ": " + woodCount;
        resourceTexts[2].text = resourceTexts[2].name + ": " + stoneCount;
        
        
    }
}
