#include<stdio.h>
#include<string.h>
//1316�� �׷�ܾ�üĿ

//���繮�� == �������� continue;
//���繮�� != �������� alphabet++;
//alphabet[i] == 1 �̸� ��� �����ؼ� ��Ÿ������.
main()
{
	char str[101];
	int input = 0, cnt =0,result=0;
	scanf_s("%d", &input, sizeof(input) / 4);
	for (int i = 0; i < input; i++)
	{
		scanf_s("%s", str, sizeof(str) / 1);
		int alphabet[26] = { 0, };
		cnt = 0;
		for (int j = 0; str[j] != '\0'; j++)
		{
			if (str[j] != str[j + 1])alphabet[str[j] - 'a']++;//�������� null����.
		}
		for (int k = 0; k < 26; k++)
		{
			if (alphabet[k] >= 2)
				cnt++;
		}
		if (cnt == 0)
			result++;
	}
	printf("%d", result);
	return 0;
}
