using Lab4.Interfaces;

namespace Lab4.Models;

public class Room : BaseRoom, IObservable
{
    private List<IObserver> observers = new List<IObserver>();

    private bool isBooked;
    private double rating;

    public bool IsBooked
    {
        get { return isBooked; }
        set
        {
            isBooked = value;
            NotifyObservers();
        }
    }

    public double Rating
    {
        get { return rating; }
        set
        {
            rating = value;
            NotifyObservers();
        }
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }
}
