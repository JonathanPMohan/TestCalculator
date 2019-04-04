using System;
using Xunit;

namespace Calculator.Tests // Tests Sometimes Have Long Names //
{
    public class adding_numbers_from_user_input
    {
        // Any method marked with FACT will be ran as a user test //
        [Fact]

        // Must be public, must be void and must not have any parameters or it won't work //
        public void adding_2_and_2_should_be_4()
        {
            // Arrange (building context for our text, arranging the context // BUILD // GIVEN
            var calculator = new CalculationEngine();
            var input = "2+2";
            var expectedResult = 4;

            // Act (this is where we do the thing, take action // WHEN // )
            var actualResult = calculator.DoMath(input);

            // Assert (Checking the result // THEN // )
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void addition_with_only_one_number_throws_an_invalid_input_exception()
        {
            //Arrange           --Context                   -- Given
            var calculator = new CalculationEngine();
            var input = "2+";

            //Act               --Do the thing              -- When
            var result = calculator.DoMath(input);

            //Assert            --Checking the result       -- Then
            Assert.Throws<InvalidInputException>(() => /*act*/ calculator.DoMath(input));
        }

        [Fact]
        public void adding_3_numbers_they_should_be_added_successfully()
        {
            //Arrange           --Context                   -- Given
            var calculator = new CalculationEngine();
            var input = "2+5+10";

            //Act               --Do the thing              -- When
            var result = calculator.DoMath(input);

            //Assert            --Checking the result       -- Then
            Assert.Throws<InvalidInputException>(() => /*act*/ calculator.DoMath(input));
        }
    }
}
