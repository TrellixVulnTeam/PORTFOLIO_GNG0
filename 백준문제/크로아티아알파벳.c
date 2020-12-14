#include<stdio.h>
//2941번 크로아티아알파벳

main()
{
	char a[100];
	int result =0;
	scanf_s("%s", a, sizeof(a) / 1);
	for (int i = 0; a[i] != '\0'; i++)
	{
		if (a[i] == 'c')
			if (a[i+1] == '-' || a[i+1] == '=') i++;
		if (a[i] == 'd')
			if (a[i+1] == '-')i++;
			else if (a[i+1] == 'z' && a[i+2] == '=') i += 2;
		if (a[i] == 'l' && a[i + 1] == 'j')i++;
		if (a[i] == 'n' && a[i + 1] == 'j')i++;
		if (a[i] == 's' && a[i + 1] == '=')i++;
		if (a[i] == 'z' && a[i + 1] == '=')i++;
		result++;
	}
	printf("%d", result);
	return 0;
}