# Stacks and Queues

## 3.2 Stack Min
Design a stack which in addition to push and pop has, a function min which returns the minimum element. Push, Pop, Min must operate in O(1) time.

SOLUTION:
1) Override Stack class, add additional "supportStack" to keep track of mins.
2) Push in supportStack new min when pushing value in main stack <= supportStack current min
3) Pop from support stack when popping value from main stack equal current supportStack min

- implemented in "//LD Q3_02_StackMin"