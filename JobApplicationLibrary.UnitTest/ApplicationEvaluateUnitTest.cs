using JobApplicationLibrary.Models;
using NUnit.Framework;

namespace JobApplicationLibrary.UnitTest
{
    public class ApplicationEvaluateUnitTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        [Test]
        public void Application_WithUnderAge_TransgeedToAutoRejected()
        {
            //Arrance
            var evaluator = new ApplicationEvuluator();
            var form = new JobApplication()
            {
                Applicant = new()
                {
                    Age = 17
                }
            };
            //Action
            var result = evaluator.Evalueate(form);
            //Assert
            Assert.AreEqual(result, ApplicationResult.AutoAccepted);

        }

    }
}