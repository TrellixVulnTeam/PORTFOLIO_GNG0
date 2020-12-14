#include <stdio.h>
//1110문제 더하기 사이클
main() {
	int number = 0; // 입력값 0~99
	int cycle = 0, result = 0;  // 사이클숫자, 결과값
	int num1 = 0, num2 = 0;// 첫번째 두번째 숫자.
	do
	{
		scanf_s("%d", &number, sizeof(number) / sizeof(int));
	}while (0 > number || number > 99);
	result = number;
	do {
		if (result >= 10)
		{
			num1 = result / 10;
			num2 = result % 10;
		}
		else if (result < 10)
		{
			num1 = 0;
			num2 = result;
		}
		result = ((num1 + num2) % 10) + num2 * 10;
		cycle++;
	} while (result != number);
	printf("사이클 = %d", cycle);
}