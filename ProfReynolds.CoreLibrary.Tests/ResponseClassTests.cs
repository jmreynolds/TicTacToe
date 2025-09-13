/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-28
 */

namespace ProfReynolds.CoreLibrary.Tests;

[TestClass]
public class ResponseClassTests
{
    [TestMethod]
    public void ContractsBaseResponseClassTest()
    {
        void SubMethod()
        {
            var baseResponseClass = new CoreLibrary.ResponseClass();
            baseResponseClass.Success.ShouldBeFalse();
            baseResponseClass.FailureInformation.ShouldBeNullOrWhiteSpace();
            baseResponseClass.ImplementedInModule.ShouldContain("ContractsBaseResponseClassTest");
        }

        SubMethod();
    }

    [TestMethod]
    public void ResponseClassConstructors()
    {
        var responseClass1 = new CoreLibrary.ResponseClass(true);
        responseClass1.Success.ShouldBeTrue();
        responseClass1.FailureInformation.ShouldBeNullOrWhiteSpace();

        var responseClass2 = new CoreLibrary.ResponseClass(false);
        responseClass2.Success.ShouldBeFalse();
        responseClass2.FailureInformation.ShouldBeNullOrWhiteSpace();

        var testFailureInformation = "testing failure information";
        var responseClass3 = new CoreLibrary.ResponseClass(testFailureInformation);
        responseClass3.Success.ShouldBeFalse();
        responseClass3.FailureInformation.ShouldBe(testFailureInformation);

        var testException = "exception failure information";
        var responseClass4 = new CoreLibrary.ResponseClass(new NotImplementedException(testException));
        responseClass4.Success.ShouldBeFalse();
        responseClass4.FailureInformation.ShouldBe(testException);

    }

}