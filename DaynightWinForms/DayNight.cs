using System;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TelerikWinFormsApp1;

internal class DayNight
{
    private bool themeDay;
    private RadImageButtonElement daynightButton;

    public DayNight(RadForm form)
    {
        new Telerik.WinControls.Themes.FluentTheme().DeserializeTheme();
        new Telerik.WinControls.Themes.FluentDarkTheme().DeserializeTheme();
         
        CreateDayNightButton(form);        

        themeDay = Telerik.WinControls.WindowsSettings.AppsUseLightTheme;

        SetDayNight();
    }


    private void CreateDayNightButton(RadForm form)
    {
        daynightButton = new RadImageButtonElement
        {
            ThemeRole = "TitleBarMinimizeButton",
            Text = "☾",
            DisplayStyle = DisplayStyle.Text,
            ShowBorder = false,
            AutoSize = false,
            Size = form.FormElement.TitleBar.MinimizeButton.Size
        };
        daynightButton.Click += DayNight_Click;
        form.FormElement.TitleBar.SystemButtons.Children.Insert(0, daynightButton);
    }

    private void DayNight_Click(object sender, EventArgs e)
    {
        themeDay = !themeDay;
        SetDayNight();
    }
    private void SetDayNight()
    {
        if (themeDay)
        {
            ThemeResolutionService.ApplicationThemeName = "Fluent";
            daynightButton.Text = "☾"; 
        }
        else
        {
            ThemeResolutionService.ApplicationThemeName = "FluentDark";
            daynightButton.Text = "☼"; 
        }
    }
}
