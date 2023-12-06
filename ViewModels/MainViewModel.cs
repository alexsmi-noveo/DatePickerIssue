using CommunityToolkit.Mvvm.ComponentModel;

namespace DatePickerIssue.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    DateTime startDate = DateTime.Today;

    [ObservableProperty]
    DateTime endDate = DateTime.Today;

    [ObservableProperty]
    DateTime minimumDateStart = DateTime.Today;

    [ObservableProperty]
    DateTime minimumDateEnd = DateTime.Today;

    partial void OnStartDateChanged(DateTime oldValue, DateTime newValue)
    {
        MinimumDateEnd = newValue;

        if (newValue > EndDate)
            EndDate = newValue; 
    }
}
