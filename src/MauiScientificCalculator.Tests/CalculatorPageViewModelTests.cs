using JetBrains.Annotations;
using MauiScientificCalculator.ViewModels;

namespace MauiScientificCalculator.Tests;

[TestSubject(typeof(CalculatorPageViewModel))]
public class CalculatorPageViewModelTests
{
    private readonly CalculatorPageViewModel sut = new(); 
    
    [Fact]
    public void ResetCommand_ResetsCalculatedResultToZero()
    {
        // Arrange: Create an instance of the ViewModel and set a non-zero calculated result
        sut.CalculatedResult = "123";

        // Act: Execute the Reset command
        sut.ResetCommand.Execute(null);

        // Assert: Ensure the calculated result is reset to "0"
        Assert.Equal("0", sut.CalculatedResult);
    }
}