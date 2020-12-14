#include<stdio.h>
//1152번 단어의 개수
void convert(char* str)
{
	for (int i = 0; str[i] != '\0'; i++)
	{
		if ('A' <= str[i] && str[i] <= 'Z')
			str[i] += 'a' - 'A';
	}
}
main()
{
	char str[1000001];
	int len = 0;
	int cnt = 0;
	scanf_s("%[^\n]s", str, sizeof(str) / 1);
	convert(str);
	for (int i = 0; str[i] != '\0'; i++)
	{
		if (('a' <= str[i] && str[i] <= 'z') && !('a' <= str[i + 1] && str[i + 1] <= 'z'))
			cnt++;
	}
	printf("%d", cnt);
	return 0;
}
