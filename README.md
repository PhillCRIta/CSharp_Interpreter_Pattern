### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Interpreter pattern
Pattern used for interpretate the code. \
GO4 said The Interpreter pattern doesn't explain how to create an abstract syntax tree. \
Turn your language into an Abstract Syntax Tree(AST)\
Parser function is very complex.
Exixts many type of parser inside a package like nuget 

**Base example** \
1 + 2 * 3 \
In  our case I haven't use a parser logic, I create directly the expression tree. \
Input = "1 + 2 * 3"; \
**Operand is the numbers** >> NumberExpression \
**Operator is a operation to do** >> Addition, Substraction, Multiplication Expression (termiinal expression)