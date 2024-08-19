using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private ICommand _moveCommand;
    private ICommand _shootCommand;
    private PlayerController _controller;

    Stack<ICommand> _commands = new Stack<ICommand>();

    [SerializeField] Player _player;
    private void Start()
    {

        ICommand moveCommand = new MoveCommand(_player, Vector3.forward);
        ICommand shootCommnad = new ShootCommand(_player);
        SetCommands(moveCommand, shootCommnad);
    }

        public void SetCommands(ICommand moveCommand, ICommand shootCommand)
        {
            _controller = new PlayerController();
            _moveCommand = moveCommand;
            _shootCommand = shootCommand;
        }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _shootCommand.Execute();
            _commands.Push(_shootCommand);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _controller.IsMoving();
            _moveCommand.Execute();
            _commands.Push(_moveCommand);
        }
    }
}
