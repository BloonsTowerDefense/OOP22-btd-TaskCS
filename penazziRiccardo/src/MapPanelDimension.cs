using System.Drawing;
namespace penazziRiccardo.src
{
    public class MapPanel
    {
        private static readonly int ORIGINAL_SPRITE_SIZE = 16;
        private static readonly int SCALE = 3;
        public static readonly int FINAL_SPRITE_SIZE = ORIGINAL_SPRITE_SIZE * SCALE;
        public static readonly int GAME_COL = 25;
        public static readonly int GAME_ROW = 15;
        public static readonly int SCREEN_WIDTH = FINAL_SPRITE_SIZE * GAME_COL;
        public static readonly int SCREEN_HEIGHT = FINAL_SPRITE_SIZE * GAME_ROW;
    }
}
