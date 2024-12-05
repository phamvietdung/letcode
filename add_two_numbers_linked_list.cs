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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var r = 0;

        var t = new ListNode(0);

        while (l1 != null || l2 != null || r > 0)
        {
            var p1 = l1 == null ? 0 : l1.val;

            var p2 = l2 == null ? 0 : l2.val;


            var sum = p1 + p2 + r;

            r = 0;

            var d = 0;

            if (sum >= 10)
            {
                r = 1;

                d = sum - 10;


            }
            else
            {
                d = sum;
            }

            var a = t;

            while (a != null)
            {
                if (a.next == null)
                {
                    a.next = new ListNode(d);
                    break;
                }

                a = a.next;
            }


            if (l1 != null) l1 = l1.next;

            if (l2 != null) l2 = l2.next;
        }

        return t.next;
    }
}