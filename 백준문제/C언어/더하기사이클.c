#include <stdio.h>
//1110���� ���ϱ� ����Ŭ
main() {
	int number = 0; // �Է°� 0~99
	int cycle = 0, result = 0;  // ����Ŭ����, �����
	int num1 = 0, num2 = 0;// ù��° �ι�° ����.
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
	printf("����Ŭ = %d", cycle);
}