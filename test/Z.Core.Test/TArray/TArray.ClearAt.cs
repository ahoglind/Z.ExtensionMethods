// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class TArray_ClearAt
    {
        [TestMethod]
        public void ClearAt()
        {
            // Type
            var @this = new[] {"Fizz", "Buzz"};

            // Exemples
            @this.ClearAt(0); // Clear index 0;

            // Unit Test
            Assert.AreEqual(null, @this[0]);
            Assert.AreEqual("Buzz", @this[1]);
        }
    }
}