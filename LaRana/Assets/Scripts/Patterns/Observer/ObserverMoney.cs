using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverMoney : MonoBehaviour, ISubject<int>
{

    private List<IObserver<int>> _observers = new List<IObserver<int>>();
    public int money = 0;

    public void OnTriggerEnter(Collider other)
    {
        IPickable pickable = other.GetComponent<IPickable>();

        if (pickable != null)
        {
            money += pickable.getCurrency();
            pickable.pick();
            NotifyObservers();
        }
    }
    public void AddObserver(IObserver<int> observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver<int> observer in _observers)
        {
            observer.update(money, items.coin);
        }
    }

    public void RemoveObserver(IObserver<int> observer)
    {
        _observers.Remove(observer);
    }
}

