using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private ICommand _moveCommand;
    private ICommand _shootCommand;

    private Stack<ICommand> moveStack = new Stack<ICommand>();

    public void SetCommands(ICommand moveCommand, ICommand shootCommand)
    {
        this._moveCommand = moveCommand;
        this._shootCommand = shootCommand;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _moveCommand.Execute();
            moveStack.Push(_moveCommand);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _moveCommand.Execute();
            moveStack.Push(_shootCommand);
        }
    }
}
