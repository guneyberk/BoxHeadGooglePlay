using UnityEngine;

public class MoveCommand : ICommand
{
    Player _player;
    Vector3 _direction;

    public MoveCommand(Player player, Vector3 direction)
    {
        _player = player;
        _direction = direction;
    }


    public void Execute()
    {
        _player.Move(_direction);
    }

    public void undo()
    {
        Debug.Log("Undo MoveCmmd");
    }
}

public class ShootCommand : ICommand
{
    Player _player;
    public ShootCommand(Player player) 
    {
        _player = player;
    }


    public void Execute()
    {
        _player.Shoot();
    }

    public void undo()
    {
        Debug.Log("Undo ShootCmmd");
    }
}