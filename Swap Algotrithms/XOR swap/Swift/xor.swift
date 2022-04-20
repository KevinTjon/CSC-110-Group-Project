var num1 = 5;
var num2 = 8;

print("Numbers before swapping:");
print("\tNum1: ",num1);
print("\tNum2: ",num2);

num1 = num1 ^ num2;
num2 = num1 ^ num2;
num1 = num1 ^ num2;

print("Numbers after swapping:");
print("\tNum1: ",num1);
print("\tNum2: ",num2);
