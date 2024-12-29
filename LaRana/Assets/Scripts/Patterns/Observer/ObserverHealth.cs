using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverHealth : MonoBehaviour, ISubject<int>
{
    private List<IObserver<int>> _observers = new List<IObserver<int>>();

    public int health = 10;

    public void OnTriggerEnter(Collider other)
    {
        IEnemy enemy = other.GetComponent<IEnemy>();
        
        if (enemy != null)
        {
            health -= enemy.Hit();
            NotifyObservers();
        }
    }
    public void AddObserver(IObserver<int> observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach(IObserver<int> observer in _observers)
        {
            observer.update(health, items.enemy);
            Debug.Log(health);
        }
    }

    public void RemoveObserver(IObserver<int> observer)
    {
        _observers.Remove(observer);
    }


}
