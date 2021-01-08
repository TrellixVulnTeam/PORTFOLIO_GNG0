#include<stdio.h>

main()
{
	int n = 17;
	int k = 4;
	int cnt = 0;
	while (1)
	{
		printf("µø¿€¡ﬂ");
		if (n % k == 0)
			n /= k;
		else
			n--;
		cnt++;
		if (n == 1)
			break;
	}
	printf("%d", cnt);

}