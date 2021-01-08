# 알파벳 대문자와 숫자로만 이루어진 S가 주어진다
# 모든 알파벳은 오름차순 정렬 ABCD
# 모든 숫자는 합으로 나타낸뒤 알파벳 제일뒤에 출력

#문자면 리스트에 넣고, 숫자면 더한다

data = input()
list = []
result = 0
for x in data:
    if x.isalpha():   #알파벳 인지 확인
        list.append(x) # 맞으면 리스트에 추가
    else:
        result += int(x) # 아니면 결과값 추가

list.sort() # 리스트 정렬하고

if result != 0: # 0이 아니라면
    list.append(str(result)) # 결과값 추가

print(''.join(list)) # 문자열로 변환







