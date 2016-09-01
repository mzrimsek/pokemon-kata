# pokemon-kata

## Description

You work in a toy store that is selling Pokemon. Each Pokemon costs $8.00. Customers who
buy more than one type of Pokemon get a discount. The same type of Pokemon cannot be
added to a discount group.

| Number of Different Pokemon Purchased | Discount Amount |
| ------------------------------------- | --------------- |
| 2                                     | 5%              |
| 3                                     | 10%             |
| 4                                     | 15%             |
| 5                                     | 25%             |
| 6                                     | 30%             |
| 7                                     | 35%             |

## Requirements

The completed program should be able to calculate the best possible discount for any collection
of Pokemon. Be aware that in cases such as example eight, larger percentages may not always
be better.

Each example should be translated into a Unit Test. No UI component is required, each test
scenario may be hard coded. Additional Unit Tests are encouraged.

## Competitive Advantage

We will be looking to interview those individuals whose completed exercise most closely
adheres to the principles listed in the book “Clean Code”. If you are unfamiliar with this book, do
not worry. Just try to write your code in a manner which leaves you feeling proud of the end
product.

## Examples

### Example One

Purchased 1 Pikachu  
**Should yield $8.00**  

### Example Two

Purchased 2 Pikachu  
**Should yield $16.00**  

### Example Three

Purchased 1 Pikachu  
Purchased 1 Squirtle  
**Should yield $15.20**  

### Example Four *note that the 5% discount does not apply to the second Pikachu.

Purchased 2 Pikachu  
Purchased 1 Squirtle  
**Should yield $23.20**  

### Example Five *note that each group of two Pokemon receives a 5% discount.

Purchased 2 Pikachu  
Purchased 2 Squirtle  
**Should yield $30.40**  

### Example Six

Purchased 1 Pikachu  
Purchased 1 Squirtle  
Purchased 1 Charmander  
**Should yield $21.60**  

### Example Seven *note that the 10% discount applies to the three grouped Pokemon, but not the additional ungrouped Pikachu.

Purchased 2 Pikachu  
Purchased 1 Squirtle  
Purchased 1 Charmander  
**Should yield $29.60**  

### Example Eight *note that using the largest percentages does not yield the lowest price.

Purchased 1 Snorlax  
Purchased 2 Zapdos  
Purchased 2 Scyther  
Purchased 2 Charmander  
Purchased 2 Squirtle  
Purchased 1 Pikachu  
**Should Yield $60.80**
