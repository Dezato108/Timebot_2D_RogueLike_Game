using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] Image imageToFade;

    [SerializeField] Image weaponImage;
    [SerializeField] Text weaponName;

    public Slider healthSlider;
    public TextMeshProUGUI healthText;

    [SerializeField] GameObject deathScreen;

    [SerializeField] TextMeshProUGUI btcText;

    [SerializeField] GameObject pauseMenu;

    [SerializeField] GameObject bossMenu;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        if (FindObjectOfType<BossController>() != null)
        {
            bossMenu.SetActive(true);
        }
        else
        {
            bossMenu.SetActive(false);
        }
    }

    public void FadeImage()
    {
        imageToFade.GetComponent<Animator>().SetTrigger("Start Fade");
    }

    public void ChangeWeaponUI(Sprite gunImage, string gunText)
    {
        weaponImage.sprite = gunImage;
        weaponName.text = gunText;
    }

    public void TurnDeathScreenOn()
    {
        deathScreen.SetActive(true);        
    }

    public void UpdateBitcoinText(int amountOfBTC)
    {
        btcText.text = amountOfBTC.ToString();
    }

    public void RestarLevel()
    {
        LevelManager.instance.RestarLevel();
    }

    public void ReturnToMainMenu()
    {
        LevelManager.instance.ReturnToMainMenu();        
    }

    public void TurnPauseMenuOnOff(bool onOff)
    {
        pauseMenu.SetActive(onOff);
    }
}
