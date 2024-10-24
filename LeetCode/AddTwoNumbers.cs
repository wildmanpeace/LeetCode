namespace LeetCode;

public class AddTwoNumbers
{
    public int Solve()
    {
        var first = new ListNode(2, new ListNode(4, new ListNode(3)));
        var second = new ListNode(5, new ListNode(6, new ListNode(4)));

        var answer = AddNodes(first, second, 0);

        return 0;
    }

    public ListNode AddNodes(ListNode first, ListNode second, int carry)
    {
        ListNode result = new();

        //Resolving current node
        var sum = first.val + second.val + carry;
        carry = sum >= 10 ? 1 : 0;

        result.val = carry == 1 ? sum - 10 : sum;
        if (first.next is null && second.next is null)
        {
            result.next = new ListNode(1);
            return result;
        }
        result.next = AddNodes(first.next ?? new ListNode(), second.next ?? new ListNode(), carry);

        return result;
    }
}

public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode? next = next;

    public override string ToString()
    {
        string result = val.ToString();
        ListNode? current = next;
        while (current is not null)
        {
            result += current.val;
            current = current.next;
        }

        return result;
    }
}