#include<stdio.h>

//숫자로만 이루어진 문자열을 입력으로 받는다
//각숫자 사이에 연산자를 넣어서 최대값을 만든다.
//모든연산은 왼쪽부터 이루어진다.

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