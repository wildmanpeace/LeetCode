using LeetCode;

namespace LeetCodeTests;

public class AddTwoNumberTests
{
    [Fact]
    public void AddTwoNumber_Case1_Test()
    {
        //Arrange
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        var expectedstr = expected.ToString();

        var solver = new AddTwoNumbers();

        //Act
        var result = solver.AddNodes(l1, l2, 0);
        var resultstr = result.ToString();

        //Assert
        Assert.Equal(expectedstr, resultstr);
    }
    
    [Fact]
    public void AddTwoNumber_Case2_Test()
    {
        //Arrange
        var l1 = new ListNode();
        var l2 = new ListNode();
        var expected = new ListNode();
        var expectedstr = expected.ToString();

        var solver = new AddTwoNumbers();

        //Act
        var result = solver.AddNodes(l1, l2, 0);
        var resultstr = result.ToString();

        //Assert
        Assert.Equal(expectedstr, resultstr);
    }
    
    [Fact]
    public void AddTwoNumber_Case3_Test()
    {
        //Arrange
        var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        var expected = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));
        var expectedstr = expected.ToString();

        var solver = new AddTwoNumbers();

        //Act
        var result = solver.AddNodes(l1, l2, 0);
        var resultstr = result.ToString();

        //Assert
        Assert.Equal(expectedstr, resultstr);
    }
}