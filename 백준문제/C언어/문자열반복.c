#include<stdio.h>
//2675번 문자열반복
main()
{
	int t = 0; //1<=t<=1000
	int r = 0; //1<=r<=8
	int cnt = 0;
	char s[20] = { 0, }; //최대20글자
	char p[160] = { 0, };//최대160글자
	scanf_s("%d", &t);
	for (int i = 0; i < t; i++)
	{
		scanf_s("%d", &r,sizeof(r)/4);
		scanf_s("%s", s,sizeof(s)/1);
		for (int j = 0; s[j] != 0; j++)
		{
			for (int k = 0; k < r; k++)
			{
				p[k] = s[j];
				printf("%c", p[k]);
			}
		}
		printf("\n");
	}
	return 0;
}