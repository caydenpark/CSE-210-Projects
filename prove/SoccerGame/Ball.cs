using System.Numerics;

public class Ball
{
    private Vector2 _position;

    public Ball(Vector2 position) 
    {
        _position = position;
    }

    public Vector2 GetPosition()
    {
        return _position;
    }

    public void Move(Vector2 velocity)
    {
        _position.X += velocity.X;
        _position.Y += velocity.Y;
    }
}