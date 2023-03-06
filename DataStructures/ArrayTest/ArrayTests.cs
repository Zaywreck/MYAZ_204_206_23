namespace ArrayTest
{
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Mert");
            array.Add("Sena");

            // Act
            int count = array.Count;

            //
            Assert.Equal(2, count);
        }
    }
}