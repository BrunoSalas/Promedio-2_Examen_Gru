using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    public void Attach(IObserver observer);
    public void Remove(IObserver observer);

}
