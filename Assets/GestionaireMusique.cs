using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionaireMusique : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    public void ChangerVolumeMusique(float nouveauVolume)
    {
        audioMixer.SetFloat("VolumeMusique", nouveauVolume);
    }
}
