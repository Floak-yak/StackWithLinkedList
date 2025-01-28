using StackWithLinkedListProject;

namespace TestStackWithLinkedListWithLinkedList
{
    public class UnitTest1
    {

        [Fact]
        public void Push_AddAnValue_AddSuccess()
        {
            //Arrange
            StackWithLinkedList stack = new  StackWithLinkedList();
            int item = 5;
            int expectedResult = item;

            //Act
            stack.Push(item);
            Node actualResult = stack.Peek();

            //Assert
            Assert.Equal(expectedResult, actualResult.DataOfNote);
        }

        [Fact]
        public void Pop_StackIsEmpty_ThrowInvalidOperationException()
        {
            //Arrange
            StackWithLinkedList stack = new StackWithLinkedList();

            //Act
            InvalidOperationException actualResult = Assert.Throws<InvalidOperationException>(() => stack.Pop());

            //Assert
            Assert.Equal("Stack is empty", actualResult.Message);
        }

        [Fact]
        public void Pop_GetTopValue_GetSuccess()
        {
            //Arrange
            int item = 0;
            StackWithLinkedList stack = new StackWithLinkedList();
            stack.Push(item);
            stack.Push(item + 1);
            int expectedResult = item;

            //Act
            Node actualResult = stack.Pop();

            //Assert
            Assert.Equal(expectedResult, actualResult.DataOfNote - 1);
        }

        [Fact]
        public void Pop_CheckElementCountAfterPop_CountWillDecreaseBy1()
        {
            //Arrange
            int item = 0;
            StackWithLinkedList stack = new StackWithLinkedList();
            stack.Push(item);
            stack.Push(item);
            int expectedResult = 1;

            //Act
            stack.Pop();
            int actualResult = stack.Count();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Peek_StackIsEmpty_ThrowInvalidOperationException()
        {
            //Arrange
            StackWithLinkedList stack = new StackWithLinkedList();

            //Act
            InvalidOperationException actualResult = Assert.Throws<InvalidOperationException>(() => stack.Peek());

            //Assert
            Assert.Equal("Stack is empty", actualResult.Message);
        }

        [Fact]
        public void Peek_GetTopValue_GetSuccess()
        {
            //Arrange
            int item = 0;
            StackWithLinkedList stack = new StackWithLinkedList();
            int expectedResult = item;

            //Act
            stack.Push(item);
            Node actualResult = stack.Peek();

            //Assert
            Assert.Equal(expectedResult, actualResult.DataOfNote);
        }

        [Fact]
        public void IsEmpty_StackIsEmpty_ReturnTrue()
        {
            //Arrange
            StackWithLinkedList stack = new StackWithLinkedList();
            bool expectedResult = false;

            //Act
            bool actualResult = stack.IsEmpty();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IsEmpty_StackIsNotEmpty_ReturnFalse()
        {
            //Arrange
            int item = 0;
            StackWithLinkedList stack = new StackWithLinkedList();
            bool expectedResult = true;

            //Act
            stack.Push(item);
            bool actualResult = stack.IsEmpty();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}