# Stacks and Queues

## 3.2 Stack Min
Design a stack which in addition to push and pop has, a function min which returns the minimum element. Push, Pop, Min must operate in O(1) time.

SOLUTION:
1) Override Stack class, add additional "supportStack" to keep track of mins.
2) Push in supportStack new min when pushing value in main stack <= supportStack current min
3) Pop from support stack when popping value from main stack equal current supportStack min

- implemented in "//LD Q3_02_StackMin"

## 3.3 Stack of Plates 
Design a list of stacks and threat them as a single stack with "push" and "pop" functionalities. This structure should have a system to create a new stack when the previous one is full and viceversa. So we should have methods like "setOfStacks.Push" and "setOfStacks.Pop" behaving identically as a single stack.

SOLUTION:
1) declare an arrayList of stacks
2) Push() will operate on the last stack adding to it, if full a new stack will be added to the arrayList, then the element will be added to the new stack.
3) Pop() will operate as well on the last stack, if it will be empty after popping, taht stack will be removed from the list of stacks.

- NOT implemented because trivial. Notes in the book.

## 3.4 Queue via Stacks
Implement a class which implements a queue using two stacks

SOLUTION:

Having original stack "A" with newest elements, we need of a support stack called "B" with oldest element.
  - perform swap at any peek, pop and then swap back
    - at any peek, pop we pop everything from "A" to "B" perform the peek, pop operation in  "B" and then pop back to "A" 
  - Perform swap only when needed (better because we move elements only when "B" gets empty, it's a kind of lazy approach)
    - at any push, pop, pick we try to reverse elements from "A" to "B" if "B" empty
    - we perform push in "A" and pop in "B".

- NOT implemented because trivial. Notes in the book.

## 3.5 Sort Stack
Need to sort the input stack having the smallest items on the top. It is possible to use a support stack. Supported operations are the common push, pop, peek, isEmpty.

SOLUTION:

Having original stack "A" to order, we need of a support stack called "B" that at the end of the procedure will contain the biggest element on the top.
  - while loop on "A" until thie stack is empty
    - pop top element from "A" in a tempVar
	- while loop in "B" until ("B"!=empty && topElementB > tempVar) 
	  - if condition verified -> pop from "B" and push in "A"
	- push tempVar in "B"
  - while loop on "B" until empty
    - pop all elements and push to "A"

- NOT implemented because trivial. Notes in the book.