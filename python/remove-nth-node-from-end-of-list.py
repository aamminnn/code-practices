class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def removeNthNode(head:ListNode, n) -> ListNode:
    dummy = ListNode(0)
    dummy.next = head
    first = dummy
    second = dummy

    for _ in range(n+1):
        first = first.next

    while first is not None:
        first = first.next
        second = second.next

    second.next = second.next.next

    return dummy.next

def printList(head):
    current = head
    while current:
        print(current.val, end=" -> " if current.next else "")
        current = current.next
    print()

head = ListNode(1)
head.next = ListNode(2)
head.next.next = ListNode(3)
head.next.next.next = ListNode(4)
head.next.next.next.next = ListNode(5)

printList(head)
n = 2
newHead = removeNthNode(head, n)
print("Remove Node",n,"from end of list")
printList(newHead)
