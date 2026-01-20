using MudBlazor;
using MudBlazor.Utilities;

namespace dev_portfolio.Components
{
    public class CustomTheme : MudTheme
    {
        public CustomTheme()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = Colors.Blue.Default,
                Secondary = "#4CAF50", // Green.Accent400
                Background = "#F5F5F5", // Grey.Lighten5
                AppbarBackground = Colors.Blue.Default,
                DrawerBackground = Colors.Shades.White,
                Surface = Colors.Shades.White,
                TextPrimary = Colors.Shades.Black,
                TextSecondary = new MudColor(Colors.Shades.Black).SetAlpha(0.5).ToString(MudColorOutputFormats.RGBA),
                ActionDefault = Colors.Shades.Black,
                ActionDisabled = new MudColor(Colors.Shades.Black).SetAlpha(0.26).ToString(MudColorOutputFormats.RGBA),
                DrawerIcon = "#616161", // Grey.Darken2
                DrawerText = "#616161", // Grey.Darken2
                AppbarText = Colors.Shades.White,
            };

            PaletteDark = new PaletteDark()
            {
                Primary = Colors.Blue.Lighten1,
                Secondary = "#A5D6A7", // Green.Accent200
                Background = "#212121", // Grey.Darken4
                AppbarBackground = "#212121", // Grey.Darken4
                DrawerBackground = "#212121", // Grey.Darken4
                Surface = "#424242", // Grey.Darken3
                TextPrimary = Colors.Shades.White,
                TextSecondary = new MudColor(Colors.Shades.White).SetAlpha(0.5).ToString(MudColorOutputFormats.RGBA),
                ActionDefault = Colors.Shades.White,
                ActionDisabled = new MudColor(Colors.Shades.White).SetAlpha(0.26).ToString(MudColorOutputFormats.RGBA),
                DrawerIcon = Colors.Shades.White,
                DrawerText = Colors.Shades.White,
            };

            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px"
            };
        }
    }
}
