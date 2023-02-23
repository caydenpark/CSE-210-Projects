using System.Numerics;

public class Player
{
    private Vector2 _position;
    private Vector2 _velocity;

    public Player(Vector2 position)
    {
        _position = position;
    }

    public void Dribble(Ball ball)
    {
        ball.Move(_velocity);
    }

    public Vector2 GetPosition()
    {
        return _position;
    }

    public bool HasBall(Ball ball)
    {
        return ball.GetPosition() == this.GetPosition();
    }

    public void Move(Vector2 velocity)
    {
        _velocity = velocity;
        _position.X += velocity.X;
        _position.Y += velocity.Y;
    } 

    public void Pass(Ball ball, Player target)
    {
        Vector2 difference = target.GetPosition() - this.GetPosition();
        ball.Move(difference);
    }
}