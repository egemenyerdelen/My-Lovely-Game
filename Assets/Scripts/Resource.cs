using UnityEngine;
using TMPro;

public class Resource : MonoBehaviour
{
    [SerializeField] private GameObject playerGameObject;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private TextMeshProUGUI resourceText;
    private int resourceCount;
    
    // Start is called before the first frame update
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        playerGameObject = FindObjectOfType<Player>().gameObject;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == playerGameObject)
        {
            if (gameObject.name == "Money")
            {
                gameManager.moneyCount++;
            }
            else if (gameObject.name == "Wood")
            {
                gameManager.woodCount++;
            }
            else if (gameObject.name == "Stone")
            {
                gameManager.stoneCount++;
            }
            
            Destroy(gameObject);
        }
    }
}
