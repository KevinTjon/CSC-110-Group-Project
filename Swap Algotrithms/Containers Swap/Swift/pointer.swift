func swapTwoInts(_ a: inout Int, _ b: inout Int) {
  let temporaryA = a
  a = b
  b = temporaryA
}

var a = 1
var b = 2

swapTwoInts(&a,&b);
print(a)
print(b)
