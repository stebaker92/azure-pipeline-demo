using azure_pipeline_demo.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace AzurePipelineDemo.Tests
{
    public class ValuesControllerTests
    {
        private readonly ValuesController controller;

        public ValuesControllerTests()
        {
            controller = new ValuesController();
        }

        [Fact]
        public void TestGetResults()
        {
            var result = controller.Get();

            Assert.IsNotType<ActionResult<IEnumerable<string>>>(result);
        }
    }
}
