// <copyright file="ProgramTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace Test.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest
    {
        /// <summary>Test stub for TriangleArea(Double)</summary>
        [PexMethod]
        public double TriangleAreaTest(double length)
        {
            double result = Program.TriangleArea(length);
            return result;
            // TODO: add assertions to method ProgramTest.TriangleAreaTest(Double)
        }
    }
}
