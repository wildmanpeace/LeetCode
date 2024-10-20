namespace LeetCode;

public class AddTwoNumbers
{
    public int Solve()
    {
        var first = new ListNode(2, new ListNode(4, new ListNode(3)));
        var second = new ListNode(5, new ListNode(6, new ListNode(4)));

        var result = new ListNode();

        result = AddNodes(first, second, 0);
        int answer = 0;
        


        return 0;
    }

    private ListNode AddNodes(ListNode first, ListNode second, int carry)
    {
        ListNode result = new();

        //Resolving current node
        var sum = first.Val + second.Val + carry;
        carry = sum >= 10 ? 1 : 0;

        result.Val = carry == 1 ? sum - 10 : sum;
        if (first.Next is null && second.Next is null)
        {
            return result;
        }
        result.Next = AddNodes(first.Next ?? new ListNode(), second.Next ?? new ListNode(), carry);

        return result;
    }
}

public class ListNode(int val = 0, ListNode next = null)
{
    public int Val = val;
    public ListNode? Next = next;
}