#include<stdio.h>
#include<string.h>
//1316번 그룹단어체커

//현재문자 == 다음문자 continue;
//현재문자 != 다음문자 alphabet++;
//alphabet[i] == 1 이면 계속 연속해서 나타난거임.
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
			if (str[j] != str[j + 1])alphabet[str[j] - 'a']++;//마지막은 null문자.
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
