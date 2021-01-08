#include<stdio.h>
//8958¹®Á¦ OXÄûÁî
main()
{
	char str[80] = {0,};
	int n = 0, cnt = 0, sum = 0;
	scanf_s("%d", &n);
	for (int i = 0; i < n; i++)
	{
		sum = 0;
		cnt = 0;
		scanf_s("%s", str, sizeof(str) / sizeof(char));
		for (int j = 0; str[j] != 0; j++)
		{
			if (str[j] == 'O')
			{
				cnt++;
			}
			else if (str[j] == 'X')
			{
				cnt = 0;
			}
			sum += cnt;
		}
		printf("%d\n", sum);
	}
	return 0;
}