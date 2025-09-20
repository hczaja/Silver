using Core.Collisions;
using SFML.Graphics;
using SFML.System;

namespace Core.Units
{
    public class Swordsman : Unit
    {
        internal const int Size = 32;

        private readonly Sprite _sprite;
        private readonly CollisionBox _collisionBox;

        public Swordsman(int x, int y, Sprite sprite)
        {
            XPos = x;
            YPos = y;

            _sprite = sprite;
            _collisionBox = new CollisionBox(
                new Vector2f(Size, Size), _sprite.Position, Id);
        }

        public int XPos { get; }

        public int YPos { get; }

        public Guid Id { get; }

        public override FloatRect TargetArea => throw new NotImplementedException();

        public override bool CheckCollisions()
        {
            throw new NotImplementedException();
        }

        public override void DrawBy(RenderTarget render)
        {
            render.Draw(_sprite);
        }
    }
}
