using MartignaniDaniele.utils;

namespace MartignaniDaniele.entity
{
    // An enumeration representing different types of Bloons in the tower defense game.
    // Each BloonType specifies its attributes such as speed, health, money, and associated image.
    public enum BloonType
    {
        RedBloon,
        BlueBloon,
        BlackBloon
    }

    public static class BloonTypeExtensions
    {
        public static double GetSpeed(this BloonType bloonType)
        {
            switch (bloonType)
            {
                case BloonType.RedBloon:
                    return BloonValues.RedBloonSpeed;
                case BloonType.BlueBloon:
                    return BloonValues.BlueBloonSpeed;
                case BloonType.BlackBloon:
                    return BloonValues.BlackBloonSpeed;
                default:
                    return 0; // Default value for unsupported types
            }
        }

        public static int GetHealth(this BloonType bloonType)
        {
            switch (bloonType)
            {
                case BloonType.RedBloon:
                    return BloonValues.RedBloonHealth;
                case BloonType.BlueBloon:
                    return BloonValues.BlueBloonHealth;
                case BloonType.BlackBloon:
                    return BloonValues.BlackBloonHealth;
                default:
                    return 0; // Default value for unsupported types
            }
        }

        public static int GetMoney(this BloonType bloonType)
        {
            switch (bloonType)
            {
                case BloonType.RedBloon:
                    return BloonValues.RedBloonMoney;
                case BloonType.BlueBloon:
                    return BloonValues.BlueBloonMoney;
                case BloonType.BlackBloon:
                    return BloonValues.BlackBloonMoney;
                default:
                    return 0; // Default value for unsupported types
            }
        }
    }
}
