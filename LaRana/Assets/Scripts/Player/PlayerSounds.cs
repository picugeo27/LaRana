using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour, IObserver<int>
{

    // Start is called before the first frame update
    void Start()
    {
        var observerHealth = GetComponent<ObserverHealth>();
        if (observerHealth != null)
            observerHealth.AddObserver(this);
        else
            Debug.Log("No hay observer de vida");

        var observerMoney = GetComponent<ObserverMoney>();
        if (observerMoney != null)
            observerMoney.AddObserver(this);
        else
            Debug.Log("No hay observer de dinero");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void update(int value, items who)
    {
        var audioService = ServiceLocator.GetService<IAudioService>();
        Debug.Log("Update de palyer sounds");
        if (who == items.enemy && value != 0)
        {
            audioService.PlayAudio(audios.RobloxMuerte);
        } else if(who == items.coin)
        {
            audioService.PlayAudio(audios.coin);
        }
    }
}
