# Addition
# Subtraction
# Multiplication
# Divison
# Integer Divison


# -3
# 2
#
# -1.00
# -5.00
# -6.00
# -1.50
# -2.00

import sys
import decimal

f1 = decimal.Decimal(sys.stdin.readline())
f2 = decimal.Decimal(sys.stdin.readline())

print("%.2f" % (f1 + f2))
print("%.2f" % (f1 - f2))
print("%.2f" % (f1 * f2))
print("%.2f" % (f1 / f2))
print("%.2f" % (int(f1) // int(f2)))

# a = -3
# b = 2
# print(a//b)