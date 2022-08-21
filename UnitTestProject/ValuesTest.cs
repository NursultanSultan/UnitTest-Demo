using UnitTestingDemo.Controllers;

namespace UnitTestProject
{
    public class ValuesTest : IClassFixture<ItemsController>
    {
        ItemsController _itemsController;
        public ValuesTest()
        {
            _itemsController = new();
        }


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