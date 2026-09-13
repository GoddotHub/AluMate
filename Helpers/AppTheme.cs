using System.Drawing;

namespace AluMate.Helpers
{
    public static class AppTheme
    {
        public static Color Background => ColorTranslator.FromHtml("#121212");
        public static Color CardBackground => ColorTranslator.FromHtml("#1E1E1E");
        public static Color MicrosoftBlue => ColorTranslator.FromHtml("#0078D4");
        public static Color TextPrimary => Color.FromArgb(240, 240, 240);
        public static Color TextSecondary => Color.FromArgb(160, 160, 160);

        public static Color StatusGreen => ColorTranslator.FromHtml("#107C41");
        public static Color StatusAmber => ColorTranslator.FromHtml("#D83B01");
        public static Color StatusRed => ColorTranslator.FromHtml("#E81123");
        public static Color StatusBlue => ColorTranslator.FromHtml("#0078D4");
    }
}