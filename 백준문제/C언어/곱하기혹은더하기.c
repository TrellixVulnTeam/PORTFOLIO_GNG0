#include<stdio.h>

//���ڷθ� �̷���� ���ڿ��� �Է����� �޴´�
//������ ���̿� �����ڸ� �־ �ִ밪�� �����.
//��翬���� ���ʺ��� �̷������.

int main(void)
{
	char str[20];
	scanf_s("%s", str, sizeof(str) / 1);
	int result = str[0] - '0';
	for (int i = 1; str[i] != '\0'; i++)
	{
		int num = str[i] - '0';
		if (result <= 1 || num <= 1)
			result += num;
		else
			result *= num;
	}
	printf("%d", result);
}