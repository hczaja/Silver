using Core.Statistics;
using Core.Units.Actions;
using SFML.Graphics;

namespace Core.Units
{
    public class Swordsman : Unit
    {
        internal const int Size = 32;

        private readonly Sprite _sprite;

        public Swordsman(int x, int y, Sprite sprite)
        {
            XPos = x;
            YPos = y;

            _sprite = sprite;

            Statistics = new UnitStatistics()
            {
                BaseAttack = new Attack() { Value = 4 },
                BaseDefense = new Defense() { Value = 3 },
            };

            Actions = new List<ActionType>()
            {
                ActionType.Move,
                ActionType.Attack,
                ActionType.Defense
            };
        }

        public int XPos { get; }

        public int YPos { get; }

        public Guid Id { get; }

        public override FloatRect TargetArea => throw new NotImplementedException();

        public override UnitStatistics Statistics { get; }

        public override IEnumerable<ActionType> Actions { get; }

        public override void DrawBy(RenderTarget render)
        {
            render.Draw(_sprite);
        }

        public override string? ToString()
        {
            string result = $"{nameof(Swordsman)} [" +
                $"A:{Statistics.BaseAttack.Value}|" +
                $"D:{Statistics.BaseDefense.Value}]";

            return result;
        }
    }
}
