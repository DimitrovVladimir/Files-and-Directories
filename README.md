
# Files-and-Directories

With solving this problems, I practice working with files.

## Problem: Advertisement Message
Write a program that generate random fake advertisement message to extol some product. The messages must consist of 4 parts: laudatory phrase + event + author + city. Use the following predefined parts:

•	Phrases – {“Excellent product.”, “Such a great product.”, “I always use that product.”, “Best product of its category.”, “Exceptional product.”, “I can’t live without this product.”}

•	Events – {“Now I feel good.”, “I have succeeded with this product.”, “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”, ”Try it yourself, I am very satisfied.”, “I feel great!”}

•	Author – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}

•	Cities – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}

The format of the output message is: {phrase} {event} {author} – {city}.

As an input, you take the number of messages to be generated. Print each random message at a separate line.

### Example:
#### input:
3
#### output:
Such a great product. Now I feel good. Elena – Ruse

Excelent product. Makes miracles. I am happy of the results! Katya – Varna

Best product of its category. That makes miracles. Eva - Sofia


## Problem: Book Library Modification
To model a book library, define classes to hold a book and a library. The library must have a name and a list of books. The books must contain the title, author, publisher, release date, ISBN-number and price.

Read a list of books, add them to the library and print the total sum of prices by author, ordered descending by price and then by author’s name lexicographically.

Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.

### Example:
#### input:
5

LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00

Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25

HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50

HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00

AC OBowden PenguinBooks 20.11.2009 0395082555 14.00
#### output:
Tolkien -> 40.25

JKRowling -> 35.50

OBowden -> 14.00

## Problem: Index of Letters

Write a program  which read a file and print count of every letter.

### Example:
#### input:
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
#### output:
A -> 1

I -> 6

L -> 5

M -> 1

P -> 1

a -> 28

b -> 5

c -> 10

d -> 16

e -> 59

f -> 6

g -> 11

h -> 14

i -> 32

k -> 7

l -> 17

m -> 18

n -> 38

o -> 25

p -> 18

r -> 24

s -> 39

t -> 43

u -> 17

v -> 5

w -> 6

x -> 2

y -> 13


