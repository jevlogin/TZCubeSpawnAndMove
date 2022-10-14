using System;
using System.Collections.Generic;

internal sealed class Controller : IInitialization, IExecute, ICleanup, IDisposable
{
    #region Fields

    private readonly List<IDisposable> _disposableControllers;
    private readonly List<IInitialization> _initializationControllers;
    private readonly List<IExecute> _executeControllers;
    private readonly List<ICleanup> _cleanupControllers;

    #endregion


    #region ClassLifeCycles

    public Controller()
    {
        _disposableControllers = new List<IDisposable>();
        _initializationControllers = new List<IInitialization>();
        _executeControllers = new List<IExecute>();
        _cleanupControllers = new List<ICleanup>();
    }

    #endregion


    #region Methods

    public Controller Add(IController controller)
    {
        if (controller is IInitialization initialization)
        {
            _initializationControllers.Add(initialization);
        }
        if (controller is IExecute execute)
        {
            _executeControllers.Add(execute);
        }
        if (controller is ICleanup cleanup)
        {
            _cleanupControllers.Add(cleanup);
        }
        if (controller is IDisposable disposable)
        {
            _disposableControllers.Add(disposable);
        }
        return this;
    }

    #endregion


    #region ICleanup

    public void Cleanup()
    {
        for (int i = 0; i < _cleanupControllers.Count; i++)
        {
            _cleanupControllers[i].Cleanup();
        }
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


    #region IExecute

    public void Execute(float deltaTime)
    {
        for (int i = 0; i < _executeControllers.Count; i++)
        {
            _executeControllers[i].Execute(deltaTime);
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