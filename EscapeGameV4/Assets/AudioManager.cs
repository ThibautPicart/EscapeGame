using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider;
    private static readonly string FirstPlayPref = "FirstPlayPref";
    private static readonly string VolumePref = "VolumePref";
    private int firstPlayInt;
    private float volumeFloat;
    public AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlayPref);

        if(firstPlayInt == 0)
        {
            print("First time");
            volumeFloat = 10;
            volumeSlider.value = volumeFloat;
            PlayerPrefs.SetFloat(VolumePref, volumeFloat);
            PlayerPrefs.SetInt(FirstPlayPref, -1);
            
        }
        else
        {
            volumeFloat = PlayerPrefs.GetFloat(VolumePref);
            volumeSlider.value = volumeFloat;
            volumeSlider.value = volumeFloat;

        }
    }


    // Fonction qui sauvegarde dans playerPrefs les valeurs des sliders
    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(VolumePref, volumeSlider.value);
    }


    // Quand on quitte l'application, on appelle la fonction qui sauvegarde les données du slider
    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSettings();
        }
    }







}
