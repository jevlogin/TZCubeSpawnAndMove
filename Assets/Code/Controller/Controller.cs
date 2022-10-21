using System;
using System.Collections.Generic;


internal sealed class Controller : IInitialization, IDisposable
{
    #region Fields

    private readonly List<IDisposable> _disposableControllers;
    private readonly List<IInitialization> _initializationControllers;

    #endregion


    #region ClassLifeCycles

    public Controller()
    {
        _disposableControllers = new List<IDisposable>();
        _initializationControllers = new List<IInitialization>();
    }

    #endregion


    #region Methods

    public Controller Add(IInitialization controller)
    {
        if (controller is IInitialization initialization)
        {
            _initializationControllers.Add(initialization);
        }
        if (controller is IDisposable disposable)
        {
            _disposableControllers.Add(disposable);
        }
        return this;
    }

    #endregion


    #region IDispose

    public void Dispose()
    {
        for (int i = 0; i < _disposableControllers.Count; i++)
        {
            _disposableControllers[i].Dispose();
        }
    }

    #endregion


    #region IInitialization

    public void Initialization()
    {
        for (int i = 0; i < _initializationControllers.Count; i++)
        {
            _initializationControllers[i].Initialization();
        }
    }

    #endregion
}