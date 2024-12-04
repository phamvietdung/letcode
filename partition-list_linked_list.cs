/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode Partition(ListNode head, int x)
    {
        ListNode leftNode = new ListNode(0);
        ListNode _tmpLeftNode = leftNode;
        ListNode rightNode = new ListNode(0);
        ListNode _tmpRightNode = rightNode;

        while (head != null)
        {
            Console.WriteLine($"val: {head.val} - x: {x}");

            if (head.val >= x)
            {
                _tmpRightNode.next = head;
                _tmpRightNode = _tmpRightNode.next;
            }
            else
            {
                _tmpLeftNode.next = head;
                _tmpLeftNode = _tmpLeftNode.next;
            }

            head = head.next;

        }

        _tmpRightNode.next = null;

        _tmpLeftNode.next = rightNode.next;

        return leftNode.next;
    }

    public void CreateTestCase()
    {
        ListNode linkedNode = null;

        var arr = new int[6]{1, 4, 3, 2, 5, 2};

        foreach (var a in arr)
        {
            ListNode tmp = new ListNode(a);

            if (linkedNode == null)
            {
                linkedNode = tmp; continue;
            }

            ListNode last = linkedNode;

            while (last.next != null)
            {
                last = last.next;
            }

            last.next = tmp;
        }

        Partition(linkedNode, 3);
    }
}