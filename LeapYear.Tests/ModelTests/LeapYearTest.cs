using Microsoft.VisualStudio.TestTools.UnitTesting;//imports the MSTest framework for us to use.
using LeapYear;//imports the LeapYear namespace from the LeapYear project for use in our tests.

namespace LeapYear.Tests
{
  [TestClass]// tells MSTest that the following class contains tests to be run.
  public class LeapYearTest
  {
    [TestMethod]//tells the compiler that the following code block is an individual test that should be run by MSTest.

    // test1
    // public void IsLeapYear_NumberDivisibleByFour_True()//is the first test, because MSTest tests are actually methods. They should always start with public void. The naming convention we are using here is basically: MethodToBeTested_BehaviorToBeTested_ExpectedResultOfTest. You can read more about this naming convention here.
    // {
    //   LeapYear testLeapYear = new LeapYear();
    //   Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));// second test, to test failing example, eventually your testing code will go hereTo test our IsLeapYear() method we need to create an instance of our LeapYear class. We do this with the line LeapYear testLeapYear = new LeapYear();.
    //   // We write our first assertion using the Assert class’s AreEqual() method.
    //   // The AreEqual() method simply checks whether its two arguments are equal. In our case, whether true and testLeapYear.isLeapYear(2012) are equal.
    //   // The first argument is what we expect the result of the test to be, and the second is the expression to be evaluated.
    //   // For example, Assert.AreEqual(true, 1 == 1) would be a passing test, since the first argument, true, is equal to the second argument, 1 == 1.
    // }
    // test2
    // public void IsLeapYear_NumberNotDivisibleByFour_False()
    // {
    //   LeapYear testLeapYear = new LeapYear();
    //   Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    //   //third test. This should still be green. We want to have a test for both True and False statements to make sure when we are adding more code to our method later, we don't break our method.
    // }
    // test3
    // public void IsLeapYear_MultiplesOfOneHundred_False()
    // {
    //   LeapYear testLeapYear = new LeapYear();
    //   Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    //   //Now, we want to make sure that numbers divisible by 100 will return False. We can add a test for that too.
    // }
    //test4
    public void IsLeapYear_MultiplesOfFourHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
