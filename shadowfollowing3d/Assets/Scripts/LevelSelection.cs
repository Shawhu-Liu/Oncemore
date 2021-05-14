using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{

    [SerializeField] private bool unlocked; //Default calue is false;
    public Image unlockImage;
    public GameObject[] stars;

    private void Start()
    {
        UpdateLevelImage();
    }

    private void UpdateLevelImage()
    {
        if(!unlocked) //This level is locked
        {
            unlockImage.gameObject.SetActive(true);
            for(int i = 0;i<stars.Length;i++)
            {
                stars[i].gameObject.SetActive(false);
            }
        }
        else //This level is unlocked
        {
            unlockImage.gameObject.SetActive(false);
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(true);
            }
        }
    }

}
