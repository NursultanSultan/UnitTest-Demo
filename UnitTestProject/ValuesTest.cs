using UnitTestingDemo.Controllers;

namespace UnitTestProject
{
    
    /// <summary>
    /// * IClassFixture inherit etmeyimizin sebebi odur ki xUnit.net her Unit test ucun 
    /// olduqu sinifin ferqli bir instancesin yaradir buda uretim maliyyetini artirir 
    /// bu maliyyeti duwurmey ucun IClassFixturedan miras aliriq
    /// 
    /// 
    /// * Testlerin Paralel iwleye bilmesi ucun heresini ayri bir classda yazmaq lazimdir 
    /// </summary>
    public class ValuesTest : IClassFixture<ItemsController>
    {
        ItemsController _itemsController;
        public ValuesTest()
        {
            _itemsController = new();
        }

        /// <summary>
        /// Test muddetinde methodumuz parametr qebul etmirse Fact keyword ile iwaretleyirik 
        /// bunun bize plus odurki TestExplorer Fact ile isaretlenmis methodlarin 
        /// Test methodlari olduqunu anlayir ve Assert e gore bize testin neticesin gosterir.
        /// </summary>
        [Fact]
        public void GetTest()
        {

            //Arrange
            int Id = 1;

            //Act
            string itemName = _itemsController.Get(Id);

            //Assert
            Assert.Equal(itemName, "Item1");

        }

        /// <summary>
        /// Test muddetinde methodumuz parametr qebul edirse Theory keyword ile iwaretleyirik
        /// InlineData keyword istifade ederek methoda parametrimizi oture bilerik 
        /// Test methoduna gondereceyimiz parametrler cox olduqda MemberData istifade olunur
        /// MemberData atributuna alternatif olaraq ClassData da istifade olunur
        /// </summary>
        [Theory]
        [InlineData(2)]
        public void GetCountTest(int count)
        {

            //Arrange
            

            //Act
            int result = _itemsController.GetCount();

            //Assert
            Assert.Equal(result , count);

        }
    }
}