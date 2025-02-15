def factorial(n):
    """Hàm tính giai thừa của một số nguyên dương."""
    if n < 0:
        return "Không có giai thừa cho số âm"
    if n == 0 or n == 1:
        return 1
    result = 1
    for i in range(2, n + 1):
        result *= i
    return result

def factorial_recursive(n):
    """Hàm tính giai thừa bằng phương pháp đệ quy."""
    if n < 0:
        return "Không có giai thừa cho số âm"
    if n == 0 or n == 1:
        return 1
    return n * factorial_recursive(n - 1)

def factorial_memoization(n, memo={}):
    """Hàm tính giai thừa sử dụng memoization để tối ưu hoá."""
    if n < 0:
        return "Không có giai thừa cho số âm"
    if n in memo:
        return memo[n]
    if n == 0 or n == 1:
        memo[n] = 1
    else:
        memo[n] = n * factorial_memoization(n - 1, memo)
    return memo[n]

if __name__ == "__main__":
    num = int(input("Nhập một số nguyên dương: "))
    print(f"Giai thừa của {num} (vòng lặp) là: {factorial(num)}")
    print(f"Giai thừa của {num} (đệ quy) là: {factorial_recursive(num)}")
    print(f"Giai thừa của {num} (memoization) là: {factorial_memoization(num)}")
