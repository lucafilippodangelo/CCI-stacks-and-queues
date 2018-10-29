# Stacks and Queues

## 3.2 Stack Min: 
Design a stack that in addition to Push() and Pop(), has a function "min" which returns the minimum element. Push(), Pop() and Min() should operate in (1) 

SOLUTION:
1) Override Stack class, add additional "supportStack" to keep track of mins.
2) push in supportStack new min when pushing value in main stack <= supportStack current min.
3) pop from support stack when popping value from main stack equal current supportStack min.

Implemented in "//LD Q3_02_StackMin"