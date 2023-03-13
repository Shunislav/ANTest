namespace WSUniversalLib
{
    [TestClass]
    public class UnitsProduct
    {
        [TestMethod]
        
        public void All_Data_Negative()
        {
            // arrange
            int count = -15;
            int width = -20;
            int lenght = -45;
            int productType = -3;
            int materialType = -1;

            int expected = -1;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void All_Data_Correct()
        {
            // arrange
            int count = 15;
            int width = 20;
            int lenght = 45;
            int productType = 3;
            int materialType = 1;

            int expected = 114147;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ProductType_Over_Three() 
        {
            // arrange
            int count = 11;
            int width = 11;
            int lenght = 11;
            int productType = 2;
            int materialType = 4;

            int expected = -1;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MaterialType_Over_Two() 
        {
            // arrange
            int count = 2;
            int width = 2;
            int lenght = 2;
            int productType = 1;
            int materialType = 3;

            int expected = -1;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void All_Data_Zero() 
        {
            // arrange
            int count = 0;
            int width = 0;
            int lenght = 0;
            int productType = 0;
            int materialType = 0;

            int expected = -1;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Material_Type1()
        {
            // arrange
            int count = 2;
            int width = 2;
            int lenght = 2;
            int productType = 1;
            int materialType = 1;

            int expected = 9;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Material_Type2()
        {
            // arrange
            int count = 2;
            int width = 2;
            int lenght = 2;
            int productType = 1;
            int materialType = 2;

            int expected = 9;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Product_Type1()
        {
            // arrange
            int count = 2;
            int width = 2;
            int lenght = 2;
            int productType = 1;
            int materialType = 1;

            int expected = 9;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Product_Type2()
        {
            // arrange
            int count = 2;
            int width = 2;
            int lenght = 2;
            int productType = 2;
            int materialType = 1;

            int expected = 21;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Product_Type3()
        {
            // arrange
            int count = 2;
            int width = 2;
            int lenght = 2;
            int productType = 3;
            int materialType = 1;

            int expected = 68;

            //act
            int actual = Calc.GetQuaForProd(count, width, lenght, productType, materialType);

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}