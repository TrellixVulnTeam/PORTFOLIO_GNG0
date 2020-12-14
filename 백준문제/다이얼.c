#include<stdio.h>
#include<stdlib.h>
//5622번 다이얼
main()
{
	char str[16];//2~15글자
	int cnt=0,result=0;
	int len = 0;
	while (len < 2)
	{
		scanf_s("%s", str, sizeof(str) / 1);
		len = strlen(str);
	}
	for (int i = 0; str[i] != '\0'; i++)
	{
		 if ('A' <= str[i] && str[i] <= 'C')
			cnt = 3;
		else if ('D' <= str[i] && str[i] <= 'F')
			cnt = 4;
		else if ('G' <= str[i] && str[i] <= 'I')
			cnt = 5;
		else if ('J' <= str[i] && str[i] <= 'L')
			cnt = 6;
		else if ('M' <= str[i] && str[i] <= 'O')
			cnt = 7;
		else if ('P' <= str[i] && str[i] <= 'S')
			cnt = 8;
		else if ('T' <= str[i] && str[i] <= 'V')
			cnt = 9;
		else if ('W' <= str[i] && str[i] <= 'Z')
			 cnt = 10;
		 result += cnt;
	}
	printf("%d", result);
	
}